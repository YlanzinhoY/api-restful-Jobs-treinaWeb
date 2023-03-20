using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TWJobs.Api.Common.Dtos
{
    public class ErrorResponse
    {
        public int Status { get; set; }
        public string Error { get; set; }
        public string Cause { get; set; }
        public string Message { get; set; }
        public DateTime Timestamp { get; set; }
    }
}
