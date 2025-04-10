using System;
using System.ComponentModel.DataAnnotations;

namespace Infrastructures.DTOs
{
    public class SubscriptionUpdateRequest
    {
        public Guid? PlanId { get; set; }

        public string Status { get; set; }

        public DateTime? StartDate { get; set; }

        public DateTime? EndDate { get; set; }
        public int DurationInMonths { get; set; }
    }
} 