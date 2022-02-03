using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Filters_CodeFirst_Migrations.Models
{
    public class DatabaseContext:DbContext
    {
        public DbSet<SetUser> SiteUsers { get; set; }
        public DbSet<Log> Logs { get; set; }
    }
}