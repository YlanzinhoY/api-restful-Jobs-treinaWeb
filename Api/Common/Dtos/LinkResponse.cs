using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TWJobs. Core. Interface;

namespace TWJobs.Api.Common.Dtos
{
    public class LinkResponse
    {
        public LinkResponse ( string href, string type, string rel )
        {
            Href = href;
            Type = type;
            Rel = rel;
        }

        public string Href { get; set; }
        public string Type { get; set; }
        public string Rel { get; set; }
    }
}
