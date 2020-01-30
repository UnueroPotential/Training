using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Training.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Admin> Admins { get; set; }
        public DbSet<Other> Others { get; set; }
        public DbSet<AspUser> AspUsers { get; set; }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            //SEEDING DATA
            var roles = new List<IdentityRole>()
            {
                new IdentityRole
                {
                    Name = "admin",
                    NormalizedName = "ADMIN"
                },
                new IdentityRole
                {
                    Name = "staff",
                    NormalizedName = "STAFF"
                }
            };
            builder.Entity<IdentityRole>().HasData(roles);

            base.OnModelCreating(builder);
        }
    }
}
