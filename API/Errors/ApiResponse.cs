
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
                400 => "A bad request, nu e bine",
                401 => "Autorizat nu esti",
                404 => "Resource not found",
                500 => "Eroare care nu stii de ce se intampla. Eroare care te intrebi ce ai facut gresit",
                _ => null
            };
        }
    }
}