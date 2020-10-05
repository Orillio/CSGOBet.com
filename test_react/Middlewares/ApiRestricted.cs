using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace CSGOBet.Middlewares
{
    /// <summary>
    /// Middleware to restrict cross api requests if not authenticated to provide server safety
    /// </summary>
    public class ApiRestricted
    {
        private readonly RequestDelegate next;

        public ApiRestricted(RequestDelegate next)
        {
            this.next = next;
        }
        public async Task InvokeAsync(HttpContext context)
        {
            if (context.User.Identity.IsAuthenticated)
            {
                await next(context);
                return;
            }
            var q = context.Request.Path.Value;
            if (!q.StartsWith("/authApi"))
            {
                await next(context);
                return;
            }
            else context.Response.StatusCode = 403;
        }
    }
}
