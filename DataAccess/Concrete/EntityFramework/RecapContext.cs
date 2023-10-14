﻿using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class RecapContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=KADIRAKIPEK\SQLEXPRESS;Database=RecapDb;Trusted_Connection=true");                          
        }

        public DbSet<Brand> Brands { get; set; }
        public DbSet<Color> Colors { get; set; }

        public DbSet<Car> Cars { get; set; }


    }
}