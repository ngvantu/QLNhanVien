using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AutoCheckTicketSystem.Models.Entities
{
    public class Employee
    {
        public string EmployeeID { get; set; }
        public string FullName { get; set; }
        public DateTime Birthday { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string AvatarUrl { get; set; }
    }
}