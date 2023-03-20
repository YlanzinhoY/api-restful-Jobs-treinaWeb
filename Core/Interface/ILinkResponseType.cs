using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TWJobs.Core.Interface
{
    public interface ILinkResponseType
    {
        public string Get { get; }
        public string Put { get; }
        public string Delete { get; }
    }
}
