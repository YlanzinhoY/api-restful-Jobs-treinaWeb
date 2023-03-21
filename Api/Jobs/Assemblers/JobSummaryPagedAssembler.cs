using Microsoft. AspNetCore. Mvc. RazorPages;
using TWJobs. Api. Common. Assemblers;
using TWJobs. Api. Common. Dtos;
using TWJobs. Api. Jobs. Dtos;

namespace TWJobs. Api. Jobs. Assemblers
{
    public class JobSummaryPagedAssembler : IPagedAssembler<JobSummaryResponse>
    {
        private readonly LinkGenerator _linkGenerator;
        private readonly IAssembler<JobSummaryResponse> _jobSummaryAssembler;
        private readonly LinkResponseType _Type;

        public JobSummaryPagedAssembler ( LinkGenerator linkGenerator, IAssembler<JobSummaryResponse> jobSummaryAssembler )
        {
            _linkGenerator = linkGenerator;
            _jobSummaryAssembler = jobSummaryAssembler;
        }

        public PagedResponse<JobSummaryResponse> ToPagedResource ( PagedResponse<JobSummaryResponse> pagedResource, HttpContext contex )
        {
            pagedResource.Items = _jobSummaryAssembler.ToResourceCollection(pagedResource.Items, contex);

            var firstPageLink = new LinkResponse(_linkGenerator. GetUriByName(contex, "FindAllJobs", 
                new { Page = pagedResource.FirstPage, size = pagedResource.PageSize}), "GET", "firstPage");

            var lastPageLink = new LinkResponse(_linkGenerator. GetUriByName(contex, "FindAllJobs",
                new { Page = pagedResource. LastPage, size = pagedResource. PageSize }), "GET", "lastPage");

            var nextPageLink = new LinkResponse(_linkGenerator. GetUriByName(contex, "FindAllJobs",
                new { Page = pagedResource.PageNumber + 1, size = pagedResource. PageSize }), "GET", "nextPage");

            var previusPageLink = new LinkResponse(_linkGenerator. GetUriByName(contex, "FindAllJobs",
                new { Page = pagedResource. PageNumber - 1, size = pagedResource. PageSize }), "GET", "previusPage");

            pagedResource. addLinks(firstPageLink, lastPageLink);

            pagedResource.AddLinkIf(pagedResource.HasNextPage, nextPageLink);
            pagedResource.AddLinkIf(pagedResource.HasPreviusPage, previusPageLink);

            return pagedResource;
        } 
    }
}
