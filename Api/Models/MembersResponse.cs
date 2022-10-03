using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api.Models
{
    public class MembersResponse
    {
        public int TotalCount { get; set; }
        public List<Member> Results { get; set; }
    }
}