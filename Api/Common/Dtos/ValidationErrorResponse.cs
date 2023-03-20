using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TWJobs.Api.Common.Dtos
{
    public class ValidationErrorResponse : ErrorResponse
    {
        public IDictionary<string, string[]> Errors { get; set; }
    }
}
