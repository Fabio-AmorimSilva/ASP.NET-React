namespace Exemplo.CustomMiddlewareLogger
{
    public class CustomLogger
    {
        private readonly RequestDelegate _next;

        public CustomLogger(RequestDelegate next)
        {
            _next = next ?? throw new
            ArgumentNullException(nameof(next));

        }

        public async Task Invoke(HttpContext httpContext) 
        {
            if (httpContext == null)
            {
                throw new ArgumentNullException(nameof(httpContext));
            }

            await _next(httpContext);
        }
    }
}
