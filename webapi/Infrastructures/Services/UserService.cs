using Infrastructures.DTOs.User;
using Infrastructures.Entities;
using Infrastructures.Repositories;
using Infrastructures.Exceptions;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using System.Security.Cryptography;
using System.Text;

namespace Infrastructures.Services
{
    public partial class UserService : GenericService<User>
    {
        private readonly IGenericRepository<User> _userRepository;

        public UserService(IGenericRepository<User> userRepository) 
            : base(userRepository)
        {
            _userRepository = userRepository ?? throw new ArgumentNullException(nameof(userRepository));
        }
        public override async Task<IEnumerable<User>> GetAllAsync()
        {
            var users = await _userRepository.GetQueryable()
                .ToListAsync();
                
            return users;
        }
        public async Task<User> AddAsync(UserCreateRequest createDto)
        {
            if (createDto == null)
                throw new ValidationException("Create data cannot be null");

            // Check if email already exists
            var existingUser = await _userRepository.GetQueryable()
                .FirstOrDefaultAsync(u => u.Email == createDto.Email && u.TenantId == createDto.TenantId);
                
            if (existingUser != null)
                throw new ValidationException($"Email '{createDto.Email}' is already registered for this tenant");

            // Create password hash menggunakan SHA256 (dalam implementasi nyata, gunakan metode hashing yang lebih aman)
            string passwordHash;
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(createDto.Password));
                passwordHash = Convert.ToBase64String(bytes);
            }

            var user = new User
            {
                TenantId = createDto.TenantId,
                Email = createDto.Email,
                PasswordHash = passwordHash,
                CreatedAt = DateTime.UtcNow,
                Status = createDto.Status
            };
            
            await _userRepository.AddAsync(user);
            return user;
        }
    }
}

