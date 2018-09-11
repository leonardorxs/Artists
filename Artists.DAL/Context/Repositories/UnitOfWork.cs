using Artists.DAL.Entities.Repositories;

namespace Artists.DAL.Context.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ArtistsDbContext _context;

        public IArtistRepository Artists { get; private set; }
        public IArtistDetailRepository ArtistDetails { get; private set; }

        public UnitOfWork(ArtistsDbContext context)
        {
            _context = context;
            ArtistDetails = new ArtistDetailRepository(_context);
            Artists = new ArtistRepository(_context);
        }

        public int Commit()
        {
            return _context.SaveChanges();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
