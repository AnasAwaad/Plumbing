using RepositoryLayer.Context;
using RepositoryLayer.Repositories;
using RepositoryLayer.Repositories.Abstract;
using RepositoryLayer.UnitOfWorks.Abstract;

namespace RepositoryLayer.UnitOfWorks.Concrete;
public class UnitOfWork : IUnitOfWork
{
    private readonly ApplicationDbContext _context;

    public UnitOfWork(ApplicationDbContext context)
    {
        _context = context;
    }

    public void Commit()
    {
        _context.SaveChanges();
    }

    public async Task CommitAsync()
    {
        await _context.SaveChangesAsync();
    }

    public async ValueTask DisposeAsync()
    {
        await _context.DisposeAsync();
    }

    IGenericRepository<T> IUnitOfWork.GetGenericRepository<T>()
    {
        return new GenericRepository<T>(_context);
    }
}
