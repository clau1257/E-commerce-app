
namespace API.Errors
{
    public class ApiResponse
    {
        public ApiResponse(int statusCode, string message = null)
        {
            StatusCode = statusCode;
            Message = message ?? GetDefaultMessageForStatusCode(statusCode);
        }
        public int StatusCode { get; set; }
        public string Message { get; set; }
          private string GetDefaultMessageForStatusCode(int statusCode)
        {
            return statusCode switch
            {
                400 => "O solicitare greșită",
                401 => "Autoritate refuzată",
                404 => "Resursă neidentificată",
                500 => "Eroare din acest motiv:",
                _ => null
            };
        }
    }
}