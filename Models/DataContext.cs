using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Kursach.Models.UsersModels;

namespace Kursach.Models
{
    public class DataContext : IdentityDbContext 
    {
        public DataContext(DbContextOptions opts) : base(opts) {
            
         }
         public DbSet<JobSeeker> JobSeekers { get; set; }
    }
}