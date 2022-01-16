namespace Exemplo.CustomMiddlewareLogger
{
    public static class MiddlewareExtensions
    {
        public static IApplicationBuilder UseCustomLogger(IApplicationBuilder app)
        {
            return app.UseMiddleware<CustomLogger>();
        }
    }
}
