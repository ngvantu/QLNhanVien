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
        [Display(Name = "Họ Tên")]
        public string FullName { get; set; }
        [Display(Name = "Ngày sinh")]
        public DateTime Birthday { get; set; }
        [Display(Name = "CMND")]
        public string Identity { get; set; }
        [Display(Name = "Ảnh đại diện")]
        public string ImageID { get; set; }
        [Display(Name = "Tình trạng")]
        public bool IsUsed { get; set; }
        [Display(Name = "Quyền")]
        public string Role { get; set; }
    }
}