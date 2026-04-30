using Microsoft.AspNetCore.Http;
using System.IO;
using System.Threading.Tasks;

namespace LearnADODotnet.Middleware
{
    public class RequestLoggingMiddleware
    {
        private readonly RequestDelegate _next;
        private readonly string _logFilePath = "request_log.txt";

        public RequestLoggingMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task InvokeAsync(HttpContext context)
        {
            var logLine = $"{System.DateTime.Now}: {context.Request.Method} {context.Request.Path}{System.Environment.NewLine}";
            await File.AppendAllTextAsync(_logFilePath, logLine);
            await _next(context);
        }
    }
}
