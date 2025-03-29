using System.ComponentModel.DataAnnotations;

namespace webapi.Infrastructures.DTOs.Notification
{
    public class NotificationUpdateRequest
    {
        public int Id { get; set; }

        [StringLength(100, ErrorMessage = "Title cannot exceed 100 characters")]
        public string Title { get; set; }

        public string Message { get; set; }

        public string NotificationType { get; set; }

        public string Status { get; set; }

        public string Priority { get; set; }

        public Dictionary<string, string> AdditionalData { get; set; }
    }
}
