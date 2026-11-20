using System.Diagnostics;

namespace MVCDemoGo1.CustomMiddleWare
{
    public class RequestTimingMiddleware
    {
        private readonly RequestDelegate _next;
        public RequestTimingMiddleware(RequestDelegate next) {
            _next = next;
        }
        public async Task InvokeAsync(HttpContext context) {
           var watch = Stopwatch.StartNew();
           await _next(context);
            watch.Stop();
            Console.WriteLine($"{context.Request.Path} :: Request processed in {watch.ElapsedMilliseconds} ms");
        }
    }
}
