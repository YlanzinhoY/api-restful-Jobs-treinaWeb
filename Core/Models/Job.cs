using System.Collections.Immutable;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace TWJobs.Core.Models
{
    public class Job
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public Decimal Salary { get; set; }
        public string Requirements { get; set; }
    }
}
