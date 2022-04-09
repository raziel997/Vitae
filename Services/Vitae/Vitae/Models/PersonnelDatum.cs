using System;
using System.Collections.Generic;

#nullable disable

namespace Vitae.Models
{
    public partial class PersonnelDatum
    {
        public string Oid { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string MaidenName { get; set; }
        public string Gender { get; set; }
        public int? Nss { get; set; }
        public string MaritalStatus { get; set; }
        public DateTime? BirthDate { get; set; }
        public string Nationality { get; set; }
        public string User { get; set; }
        public string ProfilePhoto { get; set; }
    }
}
