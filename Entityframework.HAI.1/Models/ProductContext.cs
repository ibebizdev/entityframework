﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Entityframework.HAI._1.Models
{
    public partial class ProductContext : DbContext
    {
        public ProductContext()
            : base("ProductDb")
        {
        }

        public DbSet<Entityframework.HAI._1.Model.EFtest.Product> Products { get; set; }
        public DbSet<Entityframework.HAI._1.Model.EFtest.Category> Categories { get; set; }

    }
}