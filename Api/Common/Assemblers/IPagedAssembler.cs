using TWJobs.Api.Common.Dtos;
using TWJobs.Api.Jobs.Dtos;

namespace TWJobs.Api.Common. Assemblers
{
    public interface IPagedAssembler<R> where R : ResourceResponse
    {
        PagedResponse<R> ToPagedResource (PagedResponse<R> pagedResponse, HttpContext contex );
    }
}
