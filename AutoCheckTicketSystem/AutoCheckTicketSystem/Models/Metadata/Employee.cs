using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AutoCheckTicketSystem.Models.Metadata
{
    public class Employee
    {
        [Key]
        public int EmployeeID { get; set; }
        public string FullName { get; set; }
        public DateTime Birthday { get; set; }
        public string Identity { get; set; }
        public string ImageID { get; set; }
        public bool IsUsed { get; set; }
        public string Role { get; set; }
    }
}