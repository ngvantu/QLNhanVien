using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AutoCheckTicketSystem.Models.Entities
{
    public class Account
    {
        public string EmployeeID { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Role { get; set; }
    }
}