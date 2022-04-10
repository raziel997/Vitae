using System;
using System.Collections.Generic;

#nullable disable

namespace Vitae.Models
{
    public partial class Language
    {
        public string Oid { get; set; }
        public string Name { get; set; }
        public int? Percentage { get; set; }
        public string Type { get; set; }
    }
}
