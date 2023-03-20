using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TWJobs. Api. Common. Assemblers;
using TWJobs. Api. Common. Dtos;
using TWJobs. Api.Jobs.Dtos;

namespace TWJobs.Api.Jobs.Assemblers
{
    public class JobSummaryAssembler : IAssembler<JobSummaryResponse>
    {
        private readonly LinkGenerator _linkGenerator;

        public JobSummaryAssembler ( LinkGenerator linkGenerator )
        {
            _linkGenerator = linkGenerator;
        }

        public JobSummaryResponse ToResource(JobSummaryResponse resource, HttpContext context)
        {
                var linkResponseType = new LinkResponseType();

                var selfLink = new LinkResponse(_linkGenerator.GetUriByName(context, "FindJobById", new {Id = resource.Id}),linkResponseType.Get, "self");

                var updateLink = new LinkResponse(_linkGenerator.GetUriByName(context, "UpdateJobById", new {Id = resource.Id}),linkResponseType.Put, "update");

                var deleteLink = new LinkResponse(_linkGenerator.GetUriByName(context, "UpdateJobById", new {Id = resource.Id}),linkResponseType.Delete, "delete");

                resource.addLinks(selfLink, updateLink, deleteLink);
                return resource;
        }
    }
}
