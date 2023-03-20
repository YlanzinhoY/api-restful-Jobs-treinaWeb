using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TWJobs.Core.Data.Context;

namespace TWJobs.Core.Config
{
    public static class DatabaseConfig
    {
        public static void RegisterDatabase(this IServiceCollection services)
        {
            services.AddDbContext<TWJobsDbContext>();
        }
    }
}
