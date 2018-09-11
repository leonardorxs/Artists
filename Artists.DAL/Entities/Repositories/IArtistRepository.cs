namespace Artists.DAL.Entities.Repositories
{
    public interface IArtistRepository : IRepository<Artist>
    {
        Artist GetArtistWithDetails(int? id);
    }
}
