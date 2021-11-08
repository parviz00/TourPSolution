using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TourP.Entities.Concrete;

namespace TourP.DataAccess.Concrete.EntityFramework
{
    public class EfCoreDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=DESKTOP-M3QLI37\SQLEXPRESS;Database=TourPDatabase;Trusted_Connection=true");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Ads>().
                HasMany(p => p.Content).WithOne(a => a.Ads).HasForeignKey(a => a.AdsId);
            modelBuilder.Entity<Ads>().
                HasMany(p => p.Steps).WithOne(a => a.Ads).HasForeignKey(a => a.AdsId);
            modelBuilder.Entity<Ads>().
                HasOne(p => p.Entry).WithOne(a => a.Ads).HasForeignKey<Entry>(c => c.AdsId);
        }

        public DbSet<Ads> Ads { get; set; }
        public DbSet<Entry> Entries { get; set; }
        public DbSet<Steps> Steps { get; set; }
        public DbSet<Content> Contents { get; set; }
    }
}
