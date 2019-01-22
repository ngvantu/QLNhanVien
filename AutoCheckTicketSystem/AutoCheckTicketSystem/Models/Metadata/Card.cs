using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AutoCheckTicketSystem.Models.Metadata
{
    public class Card
    {
        [Key]
        public int CardID { get; set; }
        public int CusID { get; set; }
        public int TypeID { get; set; }
        public bool IsUsed { get; set; }
    }
}