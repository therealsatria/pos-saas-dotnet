using System.ComponentModel.DataAnnotations;

namespace webapi.Infrastructures.DTOs.Return
{
    public class ReturnUpdateRequest
    {
        public int Id { get; set; }

        public List<ReturnItemUpdateRequest> Items { get; set; }

        public string ReturnReason { get; set; }

        public string Notes { get; set; }

        public string Status { get; set; }
    }

    public class ReturnItemUpdateRequest
    {
        public int OrderItemId { get; set; }

        [Range(1, int.MaxValue, ErrorMessage = "Quantity must be greater than 0")]
        public int Quantity { get; set; }

        public string ReturnReason { get; set; }
    }
}
