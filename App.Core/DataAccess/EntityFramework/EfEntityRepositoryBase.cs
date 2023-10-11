using App.Core.DataAccess.Abstract;
using App.Core.Entities;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace App.Core.DataAccess.EntityFramework
{
  public class EfEntityRepositoryBase<TEntity, TContext> : IEntityRepository<TEntity>
      where TEntity : class, IEntity, new()
      where TContext : DbContext, new()
  {
    public void Add(TEntity entity)
    {
      using (TContext _context = new TContext())
      {
        _context.Entry(entity).State = EntityState.Added;
      }
    }
    public void Update(TEntity entity)
    {
      using (TContext _context = new TContext())
      {
        _context.Entry(entity).State = EntityState.Modified;
      }
    }

    public bool Any(Expression<Func<TEntity, bool>> filter)
    {
      using (TContext _context = new TContext())
      {
        return _context.Set<TEntity>().Any(filter);
      }
    }

    public void Delete(TEntity entity)
    {
      using (TContext _context = new TContext())
      {
        _context.Entry(entity).State = EntityState.Deleted;
      }
    }
    public void DeleteById(int id)
    {
      using (TContext _context = new TContext())
      {
        var entity = FindById(id);
        _context.Entry(entity).State = EntityState.Deleted;
      }
    }
    public TEntity FindById(int id)
    {
      using (TContext _context = new TContext())
      {
        return _context.Set<TEntity>().Find(id);
      }
    }
    public TEntity Get(Expression<Func<TEntity, bool>> filter, string includeProperties = "")
    {
      using (TContext _context = new TContext())
      {
        IQueryable<TEntity> q = _context.Set<TEntity>();

        if (filter != null)
        {
          q = q.Where(filter);
        }

        if (includeProperties != null || !string.IsNullOrWhiteSpace(includeProperties))
        {
          foreach (var includeProperty in includeProperties.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries))
          {
            q = q.Include(includeProperty);
          }
        }
        return q.FirstOrDefault(filter);
      }
    }

    public IEnumerable<TEntity> GetList(Expression<Func<TEntity, bool>> filter = null, Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> orderBy = null, string includeProperties = "")
    {
      using (TContext _context = new TContext())
      {
        IQueryable<TEntity> q = _context.Set<TEntity>();
        if (filter != null)
        {
          q = q.Where(filter);
        }

        if (includeProperties != null || !string.IsNullOrWhiteSpace(includeProperties))
        {
          foreach (var includeProperty in includeProperties.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries))
          {
            q = q.Include(includeProperty);
          }
        }
        if (orderBy != null)
        {
          return orderBy(q).ToList();
        }
        else
        {
          return q.ToList();
        }
      }
    }

    public int Save()
    {
      using (TContext _context = new TContext())
      {
        return _context.SaveChanges();
      }
    }
    public int CountWhere(Expression<Func<TEntity, bool>> filter)
    {
      using (TContext _context = new TContext())
      {
        return _context.Set<TEntity>().Where(filter).Count();
      }
    }

    //Async	
    public async Task AddAsync(TEntity entity)
    {
      using (TContext _context = new TContext())
      {
        await _context.Set<TEntity>().AddAsync(entity);
      }
    }
    public async Task<TEntity> FindByIdAsync(int id)
    {
      using (TContext _context = new TContext())
      {
        return await _context.Set<TEntity>().FindAsync(id);
      }
    }
    public async Task<TEntity> GetAsync(Expression<Func<TEntity, bool>> filter, string includeProperties = "")
    {
      using (TContext _context = new TContext())
      {
        IQueryable<TEntity> q = _context.Set<TEntity>();

        if (filter != null)
        {
          q = q.Where(filter);
        }

        if (includeProperties != null || !string.IsNullOrWhiteSpace(includeProperties))
        {
          foreach (var includeProperty in includeProperties.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries))
          {
            q = q.Include(includeProperty);
          }
        }
        return await q.FirstOrDefaultAsync(filter);
      }
    }
    public async Task<IEnumerable<TEntity>> GetListAsync(Expression<Func<TEntity, bool>> filter = null, Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> orderBy = null, string includeProperties = "")
    {
      using (TContext _context = new TContext())
      {
        IQueryable<TEntity> q = _context.Set<TEntity>();
        if (filter != null)
        {
          q = q.Where(filter);
        }

        if (includeProperties != null || !string.IsNullOrWhiteSpace(includeProperties))
        {
          foreach (var includeProperty in includeProperties.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries))
          {
            q = q.Include(includeProperty);
          }
        }
        if (orderBy != null)
        {
          return await orderBy(q).ToListAsync();
        }
        else
        {
          return await q.ToListAsync();
        }
      }
    }
    public async Task<int> SaveAsync()
    {
      using (TContext _context = new TContext())
      {
        return await _context.SaveChangesAsync();
      }
    }
    public async Task<int> CountWhereAsync(Expression<Func<TEntity, bool>> filter)
    {
      using (TContext _context = new TContext())
      {
        return await _context.Set<TEntity>().Where(filter).CountAsync();
      }
    }
  }
}
