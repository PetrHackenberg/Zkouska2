using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Registration_of_Insured.Models;

namespace Registration_of_Insured.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Registration_of_Insured.Models.Insurance>? Insurance { get; set; }
        public DbSet<Registration_of_Insured.Models.Insured>? Insured { get; set; }
    }
}