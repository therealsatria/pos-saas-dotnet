using System.Collections.Generic;

namespace Infrastructures.ResponseBuilder
{
    public class ApiResponse<T>
    {
        public bool Success { get; set; }
        public string? Message { get; set; }
        public T? Data { get; set; }
        public IEnumerable<string>? Errors { get; set; }
    }
}