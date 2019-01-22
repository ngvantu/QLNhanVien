using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AutoCheckTicketSystem.Models.Metadata
{
    public class Customer
    { 
        [Key]
        public int CusID { get; set; }
        public string FullName { get; set; }
        public DateTime Birthday { get; set; }
        public string Email { get; set; }
        public int PhoneNumber { get; set; }
        public string Identity { get; set; }

        public ICollection<Card> Cards { get; set; }
    }
}