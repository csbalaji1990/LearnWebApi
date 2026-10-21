namespace LearnWebApi
{
    public class CustomMiddleware
    {
        private readonly RequestDelegate _next;

        public CustomMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task InvokeAsync(HttpContext context)
        {
            Console.WriteLine($"Request: {context.Request.Method} {context.Request.Path}");

            await _next(context);

            Console.WriteLine($"Response: {context.Response.StatusCode}");
        }
    }
}
