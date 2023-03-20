using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TWJobs.Core.Middlewares;

namespace TWJobs.Core.Config
{
    public static class MiddlewaresConfig
    {
        public static void RegisterMiddlewares(this WebApplication app)
        {
            app.UseMiddleware<ExceptionHandlerMiddleware>();
        }
    }
}
