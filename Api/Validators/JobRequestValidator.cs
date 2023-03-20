using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FluentValidation;
using TWJobs. Api. Jobs. Dtos;

namespace TWJobs.Api.Validators
{
    public class JobRequestValidator : AbstractValidator<JobRequest>
    {
        public JobRequestValidator()
        {
            RuleFor(j => j.Title).NotEmpty().OverridePropertyName("title");
            RuleFor(j => j.Salary).GreaterThan(0).OverridePropertyName("salary");
            RuleFor(j => j.Requirements).NotEmpty().OverridePropertyName("requirements");
        }
    }
}
