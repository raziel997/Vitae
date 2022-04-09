using System;
using System.Collections.Generic;

#nullable disable

namespace Vitae.Models
{
    public partial class User
    {
        public string Oid { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
    }
}
