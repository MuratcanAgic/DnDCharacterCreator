using App.Core.Utilities.Results;
using System.Linq.Expressions;

namespace App.Business.Abstract
{
  public interface IGenericService<T> where T : class
  {
    IDataResult<T> FindById(int id);
    IDataResult<T> Get(Expression<Func<T, bool>> filter, string includeProperties = "");
    IEnumerable<IDataResult<T>> GetList(Expression<Func<T, bool>> filter = null,
    Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null, string includeProperties = "");
    IResult Add(T entity);
    IResult Update(T entity);
    IResult Delete(T entity);
    IResult DeleteById(int id);
    IResult Any(Expression<Func<T, bool>> filter);
    IResult Save();
    IDataResult<int> CountWhere(Expression<Func<T, bool>> filter);

    //Asnyc
    IDataResult<Task<T>> FindByIdAsync(int id);
    IDataResult<Task<T>> GetAsync(Expression<Func<T, bool>> filter, string includeProperties = "");
    IDataResult<Task<IEnumerable<T>>> GetListAsync(Expression<Func<T, bool>> filter = null,
    Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null, string includeProperties = "");
    IDataResult<Task> AddAsync(T entity);
    IDataResult<Task<int>> SaveAsync();
    IDataResult<Task<int>> CountWhereAsync(Expression<Func<T, bool>> filter);

  }
}
