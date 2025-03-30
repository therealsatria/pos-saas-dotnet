namespace Infrastructures.DTOs
{
    public class ResultDto<T>
    {
        public bool Success { get; set; }
        public string Message { get; set; }
        public T Data { get; set; }
        public List<string> Errors { get; set; }

        public ResultDto()
        {
            Success = true;
            Errors = new List<string>();
        }

        public static ResultDto<T> Ok(T data, string message = null)
        {
            return new ResultDto<T>
            {
                Success = true,
                Data = data,
                Message = message
            };
        }

        public static ResultDto<T> Fail(string message, List<string> errors = null)
        {
            return new ResultDto<T>
            {
                Success = false,
                Message = message,
                Errors = errors ?? new List<string>()
            };
        }
    }
}
