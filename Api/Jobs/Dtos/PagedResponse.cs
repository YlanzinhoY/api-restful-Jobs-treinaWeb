using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TWJobs.Api.Jobs.Dtos
{
    public class PagedResponse<R>
    {
        public ICollection<R> Items { get; set; } = new List<R>();
        public int PageNumber { get; set; }
        public int  PageSize { get; set; }
        public int FirstPage  { get; set; }
        public int LastPage { get; set; }
        public int TotalPages { get; set; }
        public int TotalElements { get; set; }
        public bool HasPreviusPage { get; set; }
        public bool HasNextPage { get; set; }
    }
}