using System;

namespace Artists.DAL.Entities.Repositories
{
    public interface IUnitOfWork : IDisposable
    {
        IArtistRepository Artists { get; }
        IArtistDetailRepository ArtistDetails { get; }
        int Commit();
    }
}
