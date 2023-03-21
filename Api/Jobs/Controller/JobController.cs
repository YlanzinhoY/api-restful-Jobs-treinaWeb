using Microsoft.AspNetCore.Mvc;
using TWJobs. Api. Common. Assemblers;
using TWJobs. Api. Jobs. Dtos;
using TWJobs.Api.Jobs.Services;

namespace TWJobs.Api.Jobs.Controllers;

    [ApiController]
    [Route("/api/jobs")]
    public class JobController : ControllerBase
    {
        private readonly IJobService _jobService;
        private readonly IAssembler<JobDetailsResponse> _JobDetailAssembler;
        private readonly IPagedAssembler<JobSummaryResponse> _jobSummaryPagedAssembler;

    public JobController (
        IJobService jobService,
        IAssembler<JobDetailsResponse> JobDetailAssembler,
        IPagedAssembler<JobSummaryResponse> jobSummaryPagedAssembler)
        {
             _jobService = jobService;
             _JobDetailAssembler = JobDetailAssembler;
            _jobSummaryPagedAssembler = jobSummaryPagedAssembler;
    }

    [HttpGet(Name = "FindAllJobs")]
        public IActionResult FindAll([FromQuery] int page, [FromQuery] int size )
        {

            var body = _jobService.FindAll(page, size);
            return Ok(_jobSummaryPagedAssembler.ToPagedResource(body, HttpContext));
        }

        [HttpGet("{id}", Name = "FindJobById")]
        public IActionResult FindById(int id)
        {
            var body = _jobService.FindById(id);
             return Ok(_JobDetailAssembler.ToResource(body, HttpContext));
        }

        [HttpPost(Name = "CreateJob")]
        public IActionResult Create(JobRequest jobRequest)
        {
            var body = _jobService.Create(jobRequest);

            return CreatedAtAction(nameof(FindById), new { Id = body.Id }, _JobDetailAssembler.ToResource(body, HttpContext));
        }

        [HttpPut("{id}", Name = "UpdateJobById")]
        public IActionResult UpdateById([FromRoute]int id, [FromBody] JobRequest jobRequest)
        {
            var body = _jobService.UpdateById(id,jobRequest);

            return Ok(_JobDetailAssembler.ToResource(body, HttpContext));
        }

        [HttpDelete("{id}", Name = "DeleteJobById")]
        public IActionResult DeleteById(int id)
        {
             _jobService.DeleteById(id);
             return NoContent();
        }
}