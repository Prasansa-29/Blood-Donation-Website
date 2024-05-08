using BloodDonation.Data;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace BloodDonation.Services
{
    
        public class ApplicationDbContext : IdentityDbContext
        {
            public ApplicationDbContext(DbContextOptions options) : base(options)
            {

            }
            public DbSet<AppUsers> AppUser { get; set; }
        }
    }

