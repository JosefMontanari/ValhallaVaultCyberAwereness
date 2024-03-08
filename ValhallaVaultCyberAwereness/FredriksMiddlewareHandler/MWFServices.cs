namespace ValhallaVaultCyberAwereness.FredriksMiddlewareHandler;

public class MWFServices
{
    private readonly RequestDelegate _next;
    private readonly ILogger<MWFServices> _logger;
    public MWFServices(RequestDelegate next, ILogger<MWFServices> logger)
    {
        _next = next;
        _logger = logger;
    }

    public async Task Invoke(HttpContext context)
    {
        // Logga msg om man är i någon av dessa sidor
        if (context.Request.Path.StartsWithSegments("/categorypage") || context.Request.Path.StartsWithSegments("/segmentpage") || context.Request.Path.StartsWithSegments("/subcategory") || context.Request.Path.StartsWithSegments("/questionpage"))
        {
            _logger.LogInformation("REQUEST received at: " + DateTime.Now + "(managed by THE LEGENDARY SPACE KNIGHTS OF THE GREAT SCANDINAVIA)");
        }
        // hanterar nästa request
        await _next(context);
    }
}
