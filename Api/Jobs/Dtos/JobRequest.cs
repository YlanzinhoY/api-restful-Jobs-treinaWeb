using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TWJobs.Api.Jobs.Dtos
{
    public class JobRequest
    {
        public string Title { get; set; }
        public decimal Salary { get; set; }
        public ICollection<string> Requirements { get; set; } = new List<string>();
    }
}
