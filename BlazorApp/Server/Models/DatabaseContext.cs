using BlazorApp.Shared.Models;
using Microsoft.EntityFrameworkCore;

namespace BlazorApp.Server.Models
{
    public partial class DatabaseContext : DbContext
    {
        public DatabaseContext()
        {
        }

        public DatabaseContext(DbContextOptions<DatabaseContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Animal> Animal { get; set; } = null!;
        public virtual DbSet<Fazenda> Fazenda { get; set; } = null!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            
        }
    }
}
