using System;
using System.Collections.Generic;

#nullable disable

namespace Vitae.Models
{
    public partial class Address
    {
        public string Oid { get; set; }
        public string LineAddress { get; set; }
        public string Ciry { get; set; }
        public string ZipCode { get; set; }
    }
}
