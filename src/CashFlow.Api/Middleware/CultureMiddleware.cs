using System.Globalization;

namespace CashFlow.Api.Middleware;

public class CultureMiddleware
{
    public readonly RequestDelegate _next;

    public CultureMiddleware(RequestDelegate next)
    {
        _next = next;
    }
    public async Task Invoke(HttpContext context)
    {
        var culture = context.Request.Headers["Accept-Language"].FirstOrDefault();

        var cultureInfo = new CultureInfo("en");

        if(string.IsNullOrEmpty(culture) == false)
        {
            cultureInfo = new CultureInfo(culture);
        }

        CultureInfo.CurrentCulture = cultureInfo;
        CultureInfo.CurrentUICulture = cultureInfo;

        await _next(context);
    }
}
