using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AutoCheckTicketSystem.Models.Entities
{
    public class Staff : Employee
    {
        public string Salary { get; set; }
    }
}