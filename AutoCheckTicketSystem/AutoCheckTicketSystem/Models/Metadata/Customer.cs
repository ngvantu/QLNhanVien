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
        [Display(Name = "Họ và tên")]
        public string FullName { get; set; }
        [Display(Name = "Ngày sinh")]
        public DateTime Birthday { get; set; }
        [Display(Name = "Email")]
        public string Email { get; set; }
        [Display(Name = "Số điện thoại")]
        public int PhoneNumber { get; set; }
        [Display(Name = "CMND")]
        public string Identity { get; set; }

        public ICollection<Card> Cards { get; set; }
    }
}