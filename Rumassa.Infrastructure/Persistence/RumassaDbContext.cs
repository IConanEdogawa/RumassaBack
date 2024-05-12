﻿using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Rumassa.Application.Abstractions;
using Rumassa.Domain.Entities;
using Rumassa.Domain.Entities.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Rumassa.Infrastructure.Persistence
{
    public class RumassaDbContext : IdentityDbContext<User, IdentityRole<Guid>, Guid>, IRumassaDbContext
    {
        public RumassaDbContext(DbContextOptions<RumassaDbContext> options)
            : base(options)
        {
            Database.Migrate();
        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Coupon> Coupons { get; set; }
        public DbSet<Delivery> Deliveries { get; set; }
        public DbSet<News> News { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Review> Reviews { get; set; }
        public DbSet<Diplom> Diploms { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Category>()
                .HasData(
                    [   new Category{ Id = 1, Name = "Оральные препараты"  },
                        new Category{ Id = 2, Name = "Инъекционные препараты" },
                        new Category{ Id = 3, Name = "Препараты ПКТ" },
                        new Category{ Id = 4, Name = "Гормон роста" },
                        new Category{ Id = 5, Name = "Сармы/Sarms" }
                    ]
                );
        }
    }
}
