using Microsoft.AspNetCore.Mvc;
using Infrastructures.Services;
using Infrastructures.DTOs;
using Infrastructures.Entities;
using Infrastructures.Exceptions;
using System;

namespace Infrastructures.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TenantController : ControllerBase
    {
        private readonly TenantService _tenantService;

        public TenantController(TenantService tenantService)
        {
            _tenantService = tenantService ?? throw new ArgumentNullException(nameof(tenantService));
        }
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var tenants = await _tenantService.GetAllAsync();
            return Ok(tenants);
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(Guid id)
        {
            var tenant = await _tenantService.GetByIdAsync(id);
            return Ok(tenant);
        }
        [HttpPost]
        public async Task<IActionResult> Create(TenantCreateRequest request)
        {
            var tenant = await _tenantService.CreateAsync(request);
            return CreatedAtAction(nameof(GetById), new { id = tenant.Id }, tenant);
        }
        [HttpPut("{id}")]
        public async Task<IActionResult> Update(Guid id, TenantUpdateRequest request)
        {
            var tenant = await _tenantService.UpdateAsync(id, request);
            return Ok(tenant);
        }   
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var tenant = await _tenantService.DeleteAsync(id);
            return Ok(tenant);
        }   
        [HttpDelete("{id}/soft")]
        public async Task<IActionResult> SoftDelete(Guid id)
        {
            var tenant = await _tenantService.SoftDeleteAsync(id);
            return Ok(tenant);
        }
    }
}   