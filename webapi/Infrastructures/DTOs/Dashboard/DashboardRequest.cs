using System.ComponentModel.DataAnnotations;

namespace webapi.Infrastructures.DTOs.Dashboard
{
    public class DashboardRequest
    {
        [Required(ErrorMessage = "Dashboard type is required")]
        public string DashboardType { get; set; }

        [Required(ErrorMessage = "Time period is required")]
        public string TimePeriod { get; set; }

        public DateTime? StartDate { get; set; }

        public DateTime? EndDate { get; set; }

        public int? StoreId { get; set; }

        public List<string> Metrics { get; set; }

        public bool ComparisonEnabled { get; set; }
    }
}
