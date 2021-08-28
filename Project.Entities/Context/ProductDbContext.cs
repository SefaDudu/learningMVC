﻿using Project.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Entities.Context
{
    public class ProductDbContext:DbContext
    {
        public ProductDbContext() : base("ProductDbContext")

        {
        }
        public DbSet<Product> Products { get; set; }
        public DbSet<Comment> Comments { get; set; }

    }
}