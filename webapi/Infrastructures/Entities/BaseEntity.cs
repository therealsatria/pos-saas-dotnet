using System;
using System.ComponentModel.DataAnnotations;

namespace webapi.Infrastructures.Entities
{
    public abstract class BaseEntity
    {
        protected BaseEntity()
        {
            Id = Guid.NewGuid();
            CreatedAt = DateTime.UtcNow;
            IsDeleted = false;
        }

        [Key]
        public Guid Id { get; init; }

        [Required]
        public DateTime CreatedAt { get; init; }

        public DateTime? UpdatedAt { get; set; }

        [Required]
        public bool IsDeleted { get; set; }
    }
}
