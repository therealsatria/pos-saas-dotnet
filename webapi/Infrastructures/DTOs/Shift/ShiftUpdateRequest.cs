using System.ComponentModel.DataAnnotations;

namespace webapi.Infrastructures.DTOs.Shift
{
    public class ShiftUpdateRequest
    {
        public int Id { get; set; }
        
        public DateTime? EndTime { get; set; }
        
        public decimal EndingCashAmount { get; set; }
        
        public string Notes { get; set; }
        
        public string Status { get; set; }
    }
}
