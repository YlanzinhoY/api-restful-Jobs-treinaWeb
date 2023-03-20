using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TWJobs. Api. Jobs. Dtos;
using TWJobs. Core. Models;

namespace TWJobs.Api.Jobs.Mappers
{
    public interface IJobMapper
    {
        JobSummaryResponse ToSummaryResponse(Job job);
        JobDetailsResponse ToDetailResponse(Job job);
        Job ToModel(JobRequest jobRequest);
        
    }
}
