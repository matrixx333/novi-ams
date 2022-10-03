using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api.Models
{
    public class Group
    {
        public string GroupUniqueID { get; set; }
        public string GroupName { get; set; }
        public bool InheritingMember { get; set; }
    }
}