using TWJobs. Api. Jobs. Dtos;
using TWJobs.Core.Models;

namespace TWJobs.Api.Jobs.Services
{
    public interface IJobService
    {
        ICollection<JobSummaryResponse> FindAll();
        PagedResponse<JobSummaryResponse> FindAll(int page, int size);
        JobDetailsResponse FindById(int id);
        JobDetailsResponse Create(JobRequest job);
        JobDetailsResponse UpdateById(int id, JobRequest job);
        void DeleteById(int id);
    }
}
