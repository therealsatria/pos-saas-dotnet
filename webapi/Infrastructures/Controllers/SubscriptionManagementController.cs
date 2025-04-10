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
    public class SubscriptionManagementController : ControllerBase
    {
        private readonly SubscriptionManagementService _subscriptionManagementService;

        public SubscriptionManagementController(SubscriptionManagementService subscriptionManagementService)
        {
            _subscriptionManagementService = subscriptionManagementService ?? throw new ArgumentNullException(nameof(subscriptionManagementService));
        }
        // [HttpGet]
        // public async Task<IActionResult> GetAll()
        // {
        //     var subscriptions = await _subscriptionManagementService.GetAllAsync();
        //     return Ok(subscriptions);
        // }
        [HttpGet("tenant/{tenantId}")]
        public async Task<IActionResult> GetByTenantId(Guid tenantId)
        {
            var subscription = await _subscriptionManagementService.GetByTenantIdAsync(tenantId);
            return Ok(subscription);
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(Guid id)
        {
            var subscription = await _subscriptionManagementService.GetByIdAsync(id);
            return Ok(subscription);
        }
        [HttpPost]
        public async Task<IActionResult> Create(SubscriptionCreateRequest request)
        {
            var subscription = await _subscriptionManagementService.CreateAsync(request);
            return CreatedAtAction(nameof(GetById), new { id = subscription.Id }, subscription);
        }
        [HttpPut("{id}")]
        public async Task<IActionResult> Update(Guid id, SubscriptionUpdateRequest request)
        {
            var subscription = await _subscriptionManagementService.UpdateAsync(id, request);
            return Ok(subscription);
        }
    }
}