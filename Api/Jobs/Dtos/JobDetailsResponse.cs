using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TWJobs. Api. Common. Dtos;

namespace TWJobs.Api.Jobs.Dtos
{
    public class JobDetailsResponse : ResourceResponse
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public decimal Salary { get; set; }
        public ICollection<string> Requirements { get; set; } = new List<string>();
    }
}
