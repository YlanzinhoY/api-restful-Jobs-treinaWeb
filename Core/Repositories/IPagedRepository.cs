using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TWJobs.Core.Repositories
{
    public interface IPagedRepository<Model>
    {
        PagedResult<Model> FindAll(PaginationOptions options);
    }
}
