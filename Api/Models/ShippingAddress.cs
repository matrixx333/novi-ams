using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api.Models
{
    public class ShippingAddress
    {
        public object Address1 { get; set; }
        public object Address2 { get; set; }
        public object City { get; set; }
        public object ZipCode { get; set; }
        public object StateProvince { get; set; }
        public object Country { get; set; }
    }
}