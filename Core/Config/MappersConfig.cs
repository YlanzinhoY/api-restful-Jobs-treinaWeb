using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TWJobs. Api. Jobs. Mappers;

namespace TWJobs.Core.Config
{
    public static class MappersConfig
    {
        public static void RegisterMappers(this IServiceCollection services)
        {
            services.AddScoped<IJobMapper, JobMapper>();
            
        }
    }
}
