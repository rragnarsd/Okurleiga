using OkurleigaHF.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OkurleigaHF.EF
{
    public class OkDBContext : DbContext
    {
        public DbSet<Property> Properties { get; set; }
        public DbSet<Tenant> Tenants { get; set; }
    }
}
