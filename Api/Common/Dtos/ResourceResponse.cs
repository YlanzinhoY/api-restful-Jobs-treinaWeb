using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TWJobs.Api.Common.Dtos
{
    public class ResourceResponse
    {
        public ICollection<LinkResponse> Links { get; set; } = new List<LinkResponse>();
        public void AddLink(LinkResponse link)
        {
            Links.Add(link);
        }

        public void addLinks(params LinkResponse[] links)
        {
            foreach(var link in links)
            {
                Links.Add(link);
            }
        }

        public void AddLinkIf(bool conditional,  LinkResponse link)
        {
            if(conditional)
            {
                Links.Add(link);
            }
        }

    }
}
