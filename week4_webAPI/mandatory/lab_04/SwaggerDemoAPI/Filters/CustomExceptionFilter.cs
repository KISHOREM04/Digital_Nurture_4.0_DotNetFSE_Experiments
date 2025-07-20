using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace SwaggerDemoAPI.Filters;

public class CustomExceptionFilter : IExceptionFilter
{
    public void OnException(ExceptionContext context)
    {
        var exceptionMessage = context.Exception.Message;
        File.WriteAllText("log.txt", exceptionMessage);
        context.Result = new ObjectResult("Internal server error")
        {
            StatusCode = 500
        };
    }
}
