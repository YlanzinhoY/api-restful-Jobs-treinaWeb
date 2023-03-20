using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TWJobs.Api.Common.Assemblers;
using TWJobs.Api.Jobs.Assemblers;
using TWJobs.Api.Jobs.Dtos;
namespace TWJobs.Core.Config
{
    public static class AssemblersConfig
    {
        public static void RegisterAssemblers(this IServiceCollection services)
        {
            services.AddScoped<IAssembler<JobSummaryResponse>,  JobSummaryAssembler>();
            services.AddScoped<IAssembler<JobDetailsResponse>, JobDetailAssembler>();
        }
    }
}
