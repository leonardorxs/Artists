using Artists.DAL.Entities;
using Artists.DAL.Entities.Repositories;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace Artists.DAL.Context.Repositories
{
    public class ArtistDetailRepository : Repository<ArtistDetail>, IArtistDetailRepository
    {
        public ArtistsDbContext ArtistsDbContext
        {
            get { return Context as ArtistsDbContext; }
        }

        public ArtistDetailRepository(ArtistsDbContext context) : base(context)
        {

        }

        public IEnumerable<ArtistDetail> GetDetailsWithArtist(int pageIndex, int pageSize)
        {
            return ArtistsDbContext.ArtistDetails
                .Include(a => a.Artist)
                .OrderBy(c => c.Talent)
                .Skip((pageIndex - 1) * pageSize)
                .Take(pageSize)
                .ToList();
        }
    }
}
