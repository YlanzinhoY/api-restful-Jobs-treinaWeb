using System;
using System.Collections.Generic;
using System.Linq;
using System. Text. Json. Serialization;
using System.Threading.Tasks;
using TWJobs. Api. Common. Dtos;

namespace TWJobs.Api.Jobs.Dtos
{
    public class PagedResponse<R> : ResourceResponse
    {
        public ICollection<R> Items { get; set; } = new List<R>();

        [JsonIgnore]
        public int PageNumber { get; set; }
        [JsonIgnore]
        public int  PageSize { get; set; }
        [JsonIgnore]
        public int FirstPage  { get; set; }
        [JsonIgnore]
        public int LastPage { get; set; }
        [JsonIgnore]
        public int TotalPages { get; set; }
        [JsonIgnore]
        public int TotalElements { get; set; }
        [JsonIgnore]
        public bool HasPreviusPage { get; set; }
        [JsonIgnore]
        public bool HasNextPage { get; set; }
    }
}
