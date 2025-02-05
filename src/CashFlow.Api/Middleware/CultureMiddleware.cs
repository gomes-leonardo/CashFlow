﻿using System.Globalization;

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
        var supportedLanguages = CultureInfo.GetCultures(CultureTypes.AllCultures).ToList();
        var requestedCulture = context.Request.Headers["Accept-Language"].FirstOrDefault();


        var cultureInfo = new CultureInfo("en");

        if(string.IsNullOrEmpty(requestedCulture) == false
            && supportedLanguages.Exists(language => language.Name.Equals(requestedCulture)))
        {
            cultureInfo = new CultureInfo(requestedCulture);
        }

        CultureInfo.CurrentCulture = cultureInfo;
        CultureInfo.CurrentUICulture = cultureInfo;

        await _next(context);
    }
}
