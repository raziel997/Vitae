using System;
using System.Collections.Generic;

#nullable disable

namespace Vitae.Models
{
    public partial class Education
    {
        public string Oid { get; set; }
        public string SchoolName { get; set; }
        public string Career { get; set; }
        public string Situation { get; set; }
        public int? Degree { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
    }
}
