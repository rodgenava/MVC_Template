using ASPdotNetCoreWebApp.Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASPdotNetCoreWebApp.Infrastructure
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        // DbSets for your entities
        //public DbSet<Members> Members { get; set; }
        public DbSet<DMS_RCRpdf> DMS_RCRpdf { get; set; }
    }
}
