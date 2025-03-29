using System.ComponentModel.DataAnnotations;

namespace webapi.Infrastructures.DTOs.Notification
{
    public class NotificationCreateRequest
    {
        [Required(ErrorMessage = "Title is required")]
        [StringLength(100, ErrorMessage = "Title cannot exceed 100 characters")]
        public string Title { get; set; }

        [Required(ErrorMessage = "Message is required")]
        public string Message { get; set; }

        [Required(ErrorMessage = "Notification type is required")]
        public string NotificationType { get; set; }

        public int? UserId { get; set; }

        public int? StoreId { get; set; }

        public string Priority { get; set; }

        public Dictionary<string, string> AdditionalData { get; set; }
    }
}
