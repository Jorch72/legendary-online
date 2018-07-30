using LegendaryOnline.Data.Heroes;
using LegendaryOnline.Data.SeedData;
using Microsoft.EntityFrameworkCore;

namespace LegendaryOnline.Data.Context
{
    public class HeroDbContext: DbContext
    {
        public HeroDbContext(DbContextOptions<HeroDbContext> options) : base(options)
        { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasDefaultSchema("hero");
            modelBuilder.Entity<Hero>().ToTable("Hero");
            modelBuilder.Entity<HeroCard>().ToTable("HeroCard");

            modelBuilder.Entity<HeroCard>().HasOne(p => p.Hero).WithMany(b => b.HeroCards);

            modelBuilder.Seed();
        }

        public DbSet<Hero> Heroes { get; set; }
        public DbSet<HeroCard> HeroCards { get; set; }
    }
}
