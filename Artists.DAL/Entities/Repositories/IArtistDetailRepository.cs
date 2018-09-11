using System.Collections.Generic;

namespace Artists.DAL.Entities.Repositories
{
    public interface IArtistDetailRepository : IRepository<ArtistDetail>
    {
        IEnumerable<ArtistDetail> GetDetailsWithArtist(int pageIndex, int pageSize);
    }
}
