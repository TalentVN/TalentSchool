using Microsoft.EntityFrameworkCore;
using TalentVN.ApplicationCore.Entities;

namespace TalentVN.Infrastructure.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

        }

        public DbSet<School> Schools { get; set; }

    }
}
