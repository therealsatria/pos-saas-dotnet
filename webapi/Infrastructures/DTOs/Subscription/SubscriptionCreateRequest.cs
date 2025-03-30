using System;
using System.ComponentModel.DataAnnotations;

namespace Infrastructures.DTOs.Subscription
{
    public class SubscriptionCreateRequest
    {
        [Required(ErrorMessage = "ID tenant diperlukan")]
        public Guid TenantId { get; set; }

        [Required(ErrorMessage = "ID rencana berlangganan diperlukan")]
        public Guid PlanId { get; set; }

        [Required(ErrorMessage = "Status berlangganan diperlukan")]
        public string Status { get; set; }

        [Required(ErrorMessage = "Tanggal mulai diperlukan")]
        public DateTime StartDate { get; set; }

        [Required(ErrorMessage = "Tanggal berakhir diperlukan")]
        public DateTime EndDate { get; set; }
    }
} 