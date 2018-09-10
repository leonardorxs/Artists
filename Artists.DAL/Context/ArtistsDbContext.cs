using Artists.DAL.Entities;
using Microsoft.EntityFrameworkCore;

namespace Artists.DAL.Context
{
    public class ArtistsDbContext : DbContext
    {

        public ArtistsDbContext(DbContextOptions<ArtistsDbContext> options)
            : base(options)
        {
        }

        public DbSet<Artist> Artists { get; set; }
        public DbSet<ArtistDetail> ArtistDetails { get; set; }

        //fluent API
        protected override void OnModelCreating(ModelBuilder builder)
        {
            //Artists
            builder.Entity<Artist>().ToTable("Artists");
            builder.Entity<Artist>().HasKey("Id");
            builder.Entity<Artist>().Property(a => a.City).HasMaxLength(80).IsRequired(true);
            builder.Entity<Artist>().Property(a => a.Country).HasMaxLength(80).IsRequired(true);
            builder.Entity<Artist>().Property(a => a.Name).HasMaxLength(80).IsRequired(true);
            builder.Entity<Artist>().Property(a => a.Site).HasMaxLength(80);

            //ArtistDetails
            builder.Entity<ArtistDetail>().ToTable("ArtistDetails");
            builder.Entity<ArtistDetail>().HasKey("Id");
            builder.Entity<ArtistDetail>().Property(d => d.Details).HasMaxLength(255);
            builder.Entity<ArtistDetail>().Property(d => d.Talent).HasMaxLength(80).IsRequired(true);
        }
    }
}
