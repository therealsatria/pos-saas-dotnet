using System.ComponentModel.DataAnnotations;

namespace webapi.Infrastructures.DTOs.Report
{
    public class ReportRequest
    {
        [Required(ErrorMessage = "Report type is required")]
        public string ReportType { get; set; }

        [Required(ErrorMessage = "Start date is required")]
        public DateTime StartDate { get; set; }

        public DateTime? EndDate { get; set; }

        public int? StoreId { get; set; }

        public string GroupBy { get; set; }

        public string SortBy { get; set; }

        public bool IncludeInactive { get; set; }

        public string ExportFormat { get; set; }
    }
}
