using TWJobs.Core.Repositories.Jobs;
using TWJobs.Core.Models;
using TWJobs. Core.Exceptions;
using TWJobs.Api.Jobs.Mappers;
using TWJobs.Api.Jobs.Dtos;
using FluentValidation;
using TWJobs. Core. Repositories;

namespace TWJobs.Api.Jobs.Services;

public class JobService : IJobService
{
    private readonly IJobRepository _jobRepository;
    private readonly IJobMapper _jobMapper;
    private readonly IValidator<JobRequest> _jobRequestValidator;

    public JobService(IJobRepository jobRepository,IJobMapper jobMapper, IValidator<JobRequest>  jobRequestValidator )
    {
        _jobRepository = jobRepository;
        _jobMapper = jobMapper;
        _jobRequestValidator = jobRequestValidator;
    }

    public JobDetailsResponse Create ( JobRequest jobRequest )
    {
        _jobRequestValidator.ValidateAndThrow(jobRequest);
        var jobToCreate = _jobMapper.ToModel(jobRequest);
        var createdJob = _jobRepository.Create(jobToCreate);
        return _jobMapper.ToDetailResponse(createdJob);
    }

    public void DeleteById ( int id )
    {
        if(!_jobRepository.ExistsById(id))
        {
            throw new  ModelNotFoundExceptions($"Job with id {id} not found");
        }
        _jobRepository.DeleteById(id);
    }

    public ICollection<JobSummaryResponse> FindAll()
    {
        return _jobRepository.FindAll().Select(job => _jobMapper.ToSummaryResponse(job)).ToList();
    }

    public PagedResponse<JobSummaryResponse> FindAll ( int page, int size )
    {
         var PaginationOptions = new PaginationOptions(page, size);
         var pagedResult = _jobRepository.FindAll(PaginationOptions);
         return _jobMapper.ToPagedSummaryResponse(pagedResult);
    }

    public JobDetailsResponse FindById ( int id )
    {
        var job = _jobRepository.FindById(id);

        if(job is null)
        {
            throw new  ModelNotFoundExceptions($"Job with id {id} not found");
        }
        return _jobMapper.ToDetailResponse(job);
    }
    public JobDetailsResponse UpdateById( int id, JobRequest jobRequest )
    {
        _jobRequestValidator.ValidateAndThrow(jobRequest);
        if(!_jobRepository.ExistsById(id))
        {
            throw new  ModelNotFoundExceptions($"Job with id {id} not found");
        }
        var jobToUpdate = _jobMapper.ToModel(jobRequest);
        jobToUpdate.Id = id;
        var updatedJob = _jobRepository.Update(jobToUpdate);
        return _jobMapper.ToDetailResponse(updatedJob);
    }
}
