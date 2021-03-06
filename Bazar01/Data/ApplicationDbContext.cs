﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Bazar01.Models;

namespace Bazar01.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<Seller> Sellers { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            // Customize the ASP.NET Identity model and override the defaults if needed.
            // For example, you can rename the ASP.NET Identity table names and more.
            // Add your customizations after calling base.OnModelCreating(builder);

            //builder.Entity<ProductOrder>().HasKey(t => new { t.ProductId, t.OrderId });

            //builder.Entity<ProductOrder>().HasOne(pt => pt.Product).WithMany(p => p.ProductOrder).HasForeignKey(pt => pt.ProductId);
            //builder.Entity<ProductOrder>().HasOne(pt => pt.Order).WithMany(p => p.ProductOrder).HasForeignKey(pt => pt.OrderId);
        }
    }
}
