using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AutoCheckTicketSystem.Models.Metadata
{
    public class Employee
    {
        public int EmployeeID { get; set; }
        public string FullName { get; set; }
        public DateTime Birthday { get; set; }
        public string Indentity { get; set; }
        public string ImageID { get; set; }
        public bool IsUsed { get; set; }
        public string Role { get; set; }
    }
}