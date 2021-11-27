using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace E_Migrant.App.Frontend.Areas.Identity.Data
{
    public class IdentityDataContext : IdentityDbContext<IdentityUser>
    {
        public IdentityDataContext(DbContextOptions<IdentityDataContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            // Customize the ASP.NET Identity model and override the defaults if needed.
            // For example, you can rename the ASP.NET Identity table names and more.
            // Add your customizations after calling base.OnModelCreating(builder);

            builder.Entity<ApplicationUser>(entity =>
            {
                // entity.ToTable(name:"AspNetUsers");
                // entity.Property(e => e.Ciudad).HasColumnName("Ciudad");
                entity.Property(e => e.Ciudad);
                entity.Property(e => e.Nombres);

            });
        }
    }

    public class ApplicationUser : IdentityUser
    {
        public string Nombres { get; set; } // example, not necessary
        public string Ciudad { get; set; } // example, not necessary
    }
}
