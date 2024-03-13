using ValhallaVaultCyberAwereness.FredriksMiddlewareHandler;

namespace ValhallaVaultCyberAwereness.Data.JosefsMiddleware
{
    public class IpAdressMiddleWare
    {
        private readonly RequestDelegate _next;
        private readonly ILogger<MWFServices> _logger;
        private readonly IHttpContextAccessor _contextAccessor;

        public IpAdressMiddleWare(RequestDelegate next, ILogger<MWFServices> logger, IHttpContextAccessor contextAccessor)
        {
            _next = next;
            _logger = logger;
            _contextAccessor = contextAccessor;
        }

        public async Task Invoke(HttpContext context)
        {
            // Logga msg om man är i någon av dessa sidor
            if (context.Request.Path.StartsWithSegments("/categorypage") || context.Request.Path.StartsWithSegments("/segmentpage") || context.Request.Path.StartsWithSegments("/subcategory") || context.Request.Path.StartsWithSegments("/questionpage"))
            {
                for (var i = 0; i < 100; i++)
                {
                    string ip = GetClientIP(_contextAccessor);
                    _logger.LogInformation("Request received from IP " + ip);

                }
            }
            // hanterar nästa request
            await _next(context);
        }

        private string GetClientIP(IHttpContextAccessor contextAccessor)
        {
            return contextAccessor.HttpContext.Connection.RemoteIpAddress.ToString();
        }
    }
}
