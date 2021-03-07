namespace PhoneDirectory.Business.Model
{
    public class Result
    {
        public Result()
        {

        }
        public Result(bool success, string message, object data)
        {
            Success = success;
            Message = message;
            Data = data;
        }

        public bool Success { get; set; }
        public string Message { get; set; }
        public object Data { get; set; }

        public static Result GetSuccess()
        {
            return new Result
            {
                Success = true
            };
        }
        public static Result GetSuccess(string message)
        {
            return new Result
            {
                Success = true,
                Message = message,
            };
        }
        public static Result GetSuccess(string message, object data)
        {
            return new Result
            {
                Success = true,
                Message = message,
                Data = data
            };
        }

        public static Result GetError()
        {
            return new Result
            {
                Success = false
            };
        }
        public static Result GetError(string message)
        {
            return new Result
            {
                Success = false,
                Message = message,
            };
        }
        public static Result GetError(string message, object data)
        {
            return new Result
            {
                Success = false,
                Message = message,
                Data = data
            };
        }
    }
}
