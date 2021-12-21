﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetStartedWPF
{
    internal class ProductContext : DbContext
    {
        public DbSet<Product>? Products { get; set; }
        public DbSet<Category>? Categories { get; set; }

        protected override void OnConfiguring(
            DbContextOptionsBuilder optionsBuilder )
        {
            optionsBuilder.UseSqlite(
                "Data Source=products.db" );
            optionsBuilder.UseLazyLoadingProxies();
            base.OnConfiguring( optionsBuilder );
        }
    }
}
