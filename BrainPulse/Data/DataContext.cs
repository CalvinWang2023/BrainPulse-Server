using BrainPulse.Models;
using Microsoft.EntityFrameworkCore;

namespace BrainPulse.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        public DbSet<Question> Questions { get; set; }
        public DbSet<IncorrectOption> IncorrectOptions { get; set; }
    }
}
