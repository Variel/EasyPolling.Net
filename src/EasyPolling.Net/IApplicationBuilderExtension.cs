using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;

namespace Variel.EasyPolling.Net
{
    public static class IApplicationBuilderExtension
    {
        public static IApplicationBuilder UsePollingEvent(this IApplicationBuilder app, string path = "/pollings")
        {
            return app.Map(new PathString(path), c =>
            {
                c.Run(async context =>
                {
                    await context.Response.WriteAsync("hello");
                });
            });
        }
    }
}
