using System;
using System.Collections.Generic;

#nullable disable

namespace Vitae.Models
{
    public partial class WorkExperience
    {
        public string Oid { get; set; }
        public string Company { get; set; }
        public string Position { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public string Description { get; set; }
    }
}
