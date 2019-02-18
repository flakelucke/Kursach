using Microsoft.EntityFrameworkCore;

namespace Kursach.Models
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> opts) : base(opts) { }

    }
}