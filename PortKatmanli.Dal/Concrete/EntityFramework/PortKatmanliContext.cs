using PortKatmanli.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PortKatmanli.Dal.Concrete.EntityFramework
{
    public class PortKatmanliContext : DbContext
    {
        public DbSet<Rules> Rules { get; set; }
        public DbSet<AllEvent> AllEvents { get; set; }
        public DbSet<Unit> Units { get; set; }
    }
}
