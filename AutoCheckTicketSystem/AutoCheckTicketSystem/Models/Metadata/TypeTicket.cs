﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AutoCheckTicketSystem.Models.Metadata
{
    public class TypeTicket
    {
        [Key]
        public int TypeID { get; set; }
        public string TypeName { get; set; }
        public int Price { get; set; }

        public ICollection<Card> Cards { get; set; }
        public ICollection<Ticket> Tickets { get; set; }
    }
}