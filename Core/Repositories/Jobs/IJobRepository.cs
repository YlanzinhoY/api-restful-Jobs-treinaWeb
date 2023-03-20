using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TWJobs. Api. Jobs. Dtos;
using TWJobs.Core.Models;

namespace TWJobs.Core.Repositories.Jobs;
public interface IJobRepository : ICrudRepository<Job, int>
{
    object ToModel ( JobRequest jobRequest );
}
