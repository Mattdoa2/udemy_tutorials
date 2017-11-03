using vega.Models;
using Microsoft.EntityFrameworkCore;

namespace vega.DAL
{
    public class VegaContext: DbContext
    {
        public VegaContext(DbContextOptions<VegaContext> options): base(options) {

        }
        public DbSet<Make> Makes { get; set; }
        public DbSet<Model> Models { get; set; }
        public DbSet<Feature> Features { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder) {
            modelBuilder.Entity<Make>().ToTable("MAKES");
            modelBuilder.Entity<Model>().ToTable("MODELS");
            modelBuilder.Entity<Feature>().ToTable("FEATURES");
        }
    }
}