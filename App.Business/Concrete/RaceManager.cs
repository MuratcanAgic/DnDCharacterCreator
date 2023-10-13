using App.Business.Abstract;
using App.Core.Utilities.Results;
using App.DataAccess.Abstract;
using App.Entities.Concrete;
using System.Linq.Expressions;

namespace App.Business.Concrete
{

  public class RaceManager : IRaceService
  {
    IRaceDal _raceDal;

    public RaceManager(IRaceDal raceDal)
    {
      _raceDal = raceDal;
    }

    public IResult Add(Race entity)
    {
      throw new NotImplementedException();
    }

    public IDataResult<Task> AddAsync(Race entity)
    {
      throw new NotImplementedException();
    }

    public IResult Any(Expression<Func<Race, bool>> filter)
    {
      throw new NotImplementedException();
    }

    public IDataResult<int> CountWhere(Expression<Func<Race, bool>> filter)
    {
      throw new NotImplementedException();
    }

    public IDataResult<Task<int>> CountWhereAsync(Expression<Func<Race, bool>> filter)
    {
      throw new NotImplementedException();
    }

    public IResult Delete(Race entity)
    {
      throw new NotImplementedException();
    }

    public IResult DeleteById(int id)
    {
      throw new NotImplementedException();
    }

    public IDataResult<Race> FindById(int id)
    {
      throw new NotImplementedException();
    }

    public IDataResult<Task<Race>> FindByIdAsync(int id)
    {
      throw new NotImplementedException();
    }

    public IDataResult<Race> Get(Expression<Func<Race, bool>> filter, string includeProperties = "")
    {
      throw new NotImplementedException();
    }

    public IDataResult<Task<Race>> GetAsync(Expression<Func<Race, bool>> filter, string includeProperties = "")
    {
      throw new NotImplementedException();
    }

    public IEnumerable<IDataResult<Race>> GetList(Expression<Func<Race, bool>> filter = null, Func<IQueryable<Race>, IOrderedQueryable<Race>> orderBy = null, string includeProperties = "")
    {
      throw new NotImplementedException();
    }

    public IDataResult<Task<IEnumerable<Race>>> GetListAsync(Expression<Func<Race, bool>> filter = null, Func<IQueryable<Race>, IOrderedQueryable<Race>> orderBy = null, string includeProperties = "")
    {
      throw new NotImplementedException();
    }

    public IResult Save()
    {
      throw new NotImplementedException();
    }

    public IDataResult<Task<int>> SaveAsync()
    {
      throw new NotImplementedException();
    }

    public IResult Update(Race entity)
    {
      throw new NotImplementedException();
    }
  }
}
