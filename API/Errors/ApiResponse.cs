namespace API.Errors
{
    public class ApiResponse
    {
        public ApiResponse(int statusCode, string message = null)
        {
            Message = message ?? GetDefaultMessageForStatusCode(statusCode);
            StatusCode = statusCode;
        }

        public string Message { get; set; }
        public int StatusCode { get; set; }

        private string GetDefaultMessageForStatusCode(int statusCode)
        {
            return statusCode switch
            {
                400 => "A bad Request, you have made",
                401 => "Authorized, You are not",
                404 => "Ressource found , it was not",
                500 => "Error are the path to the dark side. Errors lead to anger. Anger leads. Hate lead to carrer change.",
                _ => null
            };
        }
    }
}