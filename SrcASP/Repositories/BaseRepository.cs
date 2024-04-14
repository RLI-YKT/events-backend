using Microsoft.EntityFrameworkCore;
using SrcASP.Services.RepositoriesInterfaces;

namespace SrcASP.Repositories;

public abstract class BaseRepository<TEntity> : IRepository<TEntity> where TEntity : class
{
    protected readonly DbContext _context;
    protected readonly DbSet<TEntity> _entities;

    protected BaseRepository(DbContext context)
    {
        _context = context;
        _entities = context.Set<TEntity>();
    }

    public async Task<IEnumerable<TEntity>> GetAll()
    {
        return await _entities.ToListAsync();
    }

    public async Task<TEntity?> GetById(int id)
    {
        return await _entities.FindAsync(id) ?? null;
    }

    public async Task Add(TEntity entity)
    {
        ArgumentNullException.ThrowIfNull(entity);
        
        await _entities.AddAsync(entity);
        await _context.SaveChangesAsync();
    }

    public async Task Update(TEntity entity)
    {
        ArgumentNullException.ThrowIfNull(entity);
        
        _entities.Update(entity);
        await _context.SaveChangesAsync();
    }

    public async Task Delete(int id)
    {
        var entity = await _entities.FindAsync(id);
        if (entity is null)
        {
            return;
        }
        _entities.Remove(entity);
        await _context.SaveChangesAsync();
    }
}