using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TWJobs.Core.Interface;

namespace TWJobs.Api.Common.Dtos
{
    public class LinkResponseType : ILinkResponseType
    {
        public string Get => "GET";
        public string Put => "PUT";
        public string Delete => "DELETE";
    }
}
