using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FluentValidation;
using TWJobs. Api. Jobs. Dtos;
using TWJobs. Api. Validators;

namespace TWJobs.Core.Config
{
    public static class ValidatorsConfig
    {
        public static void RegisterValidators(this IServiceCollection services)
        {
            services.AddScoped<IValidator<JobRequest>, JobRequestValidator>();
        }
    }
}
