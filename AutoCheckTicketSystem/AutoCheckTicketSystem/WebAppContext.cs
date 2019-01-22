using AutoCheckTicketSystem.Models.Metadata;
using MySql.Data.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace AutoCheckTicketSystem
{
    [DbConfigurationType(typeof(MySqlEFConfiguration))]
    public class WebAppContext : DbContext
    {
        public DbSet<Employee> employee { get; set; }
        public DbSet<Customer> customer { get; set; }
        public DbSet<Card> card { get; set; }
        public DbSet<Ticket> ticket { get; set; }
        public DbSet<TypeTicket> type { get; set; }
        public WebAppContext() : base("WebAppCon")
        { }
    }
}