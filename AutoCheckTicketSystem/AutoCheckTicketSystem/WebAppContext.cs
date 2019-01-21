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
        public WebAppContext() : base("WebAppCon")
        { }
    }
}