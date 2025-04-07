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
    public class SubscriptionPlanController : ControllerBase
    {
        private readonly SubscriptionPlanService _subscriptionPlanService;

        public SubscriptionPlanController(SubscriptionPlanService subscriptionPlanService)
        {
            _subscriptionPlanService = subscriptionPlanService;
        }
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var subscriptionPlans = await _subscriptionPlanService.GetAllAsync();
            return Ok(subscriptionPlans);
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(Guid id)
        {
            var subscriptionPlan = await _subscriptionPlanService.GetByIdAsync(id);
            return Ok(subscriptionPlan);
        }
        [HttpPost]
        public async Task<IActionResult> Create(SubscriptionPlanCreateRequest request)
        {
            var subscriptionPlan = await _subscriptionPlanService.CreateAsync(request);
            return CreatedAtAction(nameof(GetById), new { id = subscriptionPlan.Id }, subscriptionPlan);
        }   
        [HttpPut("{id}")]
        public async Task<IActionResult> Update(Guid id, SubscriptionPlanUpdateRequest request)
        {
            var subscriptionPlan = await _subscriptionPlanService.UpdateAsync(id, request);
            return Ok(subscriptionPlan);
        }        
    }
}