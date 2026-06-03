using CleanArchitecture.Blueprint.Api.Models;
using Microsoft.EntityFrameworkCore;

namespace CleanArchitecture.Blueprint.Api.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

        public DbSet<SampleRecord> SampleRecords { get; set; }
    }
}
