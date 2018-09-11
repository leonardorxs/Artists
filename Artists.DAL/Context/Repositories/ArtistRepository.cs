using Artists.DAL.Entities;
using Artists.DAL.Entities.Repositories;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace Artists.DAL.Context.Repositories
{
    public class ArtistRepository : Repository<Artist>, IArtistRepository
    {
        public ArtistRepository(ArtistsDbContext context) : base(context)
        {
        }

        public Artist GetArtistWithDetails(int? id)
        {
            return ArtistsDbContext.Artists.Include(a => a.ArtistDetails)
                .SingleOrDefault(a => a.Id == id);
        }

        public ArtistsDbContext ArtistsDbContext
        {
            get { return Context as ArtistsDbContext; }
        }
    }
}
