using Microsoft.EntityFrameworkCore;
using Schmohawks.Models;

namespace Schmohawks.Database {
    public class SchmohawksDbContext : DbContext {
    public SchmohawksDbContext(DbContextOptions<SchmohawksDbContext> options)
        : base(options) {
    }

    public DbSet<Gig> Gigs {get;set;}

    protected override void OnModelCreating(ModelBuilder builder) {
      base.OnModelCreating(builder);
    }
  }
}
