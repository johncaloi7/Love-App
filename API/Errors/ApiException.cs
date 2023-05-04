namespace API.Errors
{
    public class ApiException
    {
        public ApiException(int stat, string message, string details)
        {
            Stat = stat;
            Message = message;
            Details = details;
        }

        public int Stat { get; set; }

        public string Message { get; set; }

        public string Details { get; set; }
    }
}