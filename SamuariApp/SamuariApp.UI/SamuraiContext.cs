using Microsoft.EntityFrameworkCore;
using SamuariApp.Domain;

namespace SamuariApp.UI
{
    internal class SamuraiContext
    {
        public DbSet<Samurai> Samurais { get; set; }
        public DbSet<Quote> Quotes { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source= (localdb)\\MSQLLocalDB; Initial Catalog=SamuraiAppData");
        }
    }
}