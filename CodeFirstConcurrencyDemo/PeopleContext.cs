﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstConcurrencyDemo
{
    public class PeopleContext : DbContext
    {
        public DbSet<People> PeopleSet { get; set; }

        protected override void OnModelCreating (DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
