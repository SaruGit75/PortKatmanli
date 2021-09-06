﻿using PortKatmanli.Entities;
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
        public DbSet<Rule> Rules { get; set; }

    }
}
