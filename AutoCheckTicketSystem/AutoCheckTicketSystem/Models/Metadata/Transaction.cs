using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AutoCheckTicketSystem.Models.Metadata
{
    public class Transaction
    {
        [Key]
        public int TransID { get; set; }
        public DateTime From { get; set; }
        public DateTime To { get; set; }
        public bool IsUsed { get; set; }
        public int TypeID { get; set; }

        public virtual TypeTicket typeTicket { get; set; }
    }
}