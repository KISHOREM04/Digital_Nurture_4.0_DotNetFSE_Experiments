using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.IO;

namespace SwaggerDemoAPI.Filters
{
    public class CustomExceptionFilter : IExceptionFilter
    {
        public void OnException(ExceptionContext context)
        {
            var exception = context.Exception;
            
           
            var logFilePath = Path.Combine(Directory.GetCurrentDirectory(), "Logs", "error.txt");

            try
            {
                Directory.CreateDirectory(Path.GetDirectoryName(logFilePath)!);
                File.AppendAllText(logFilePath, $"{DateTime.Now}: {exception.Message} - {exception.StackTrace}{Environment.NewLine}");
            }
            catch
            {
                
            }

            context.Result = new ObjectResult(new
            {
                Message = "An unexpected error occurred. Please try again later."
            })
            {
                StatusCode = 500
            };

            context.ExceptionHandled = true;
        }
    }
}
