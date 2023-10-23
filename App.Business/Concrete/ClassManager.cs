using App.Business.Abstract;
using App.Core.Utilities.Results;
using App.DataAccess.Abstract;
using App.Entities.Concrete;
using FluentValidation;
using FluentValidation.Results;
using System.Linq.Expressions;

namespace App.Business.Concrete
{
  public class ClassManager : IClassService
  {
    IClassDal _classDal;
    IValidator<Class> _validator;
    public ClassManager(IClassDal classDal, IValidator<Class> validator)
    {
      _classDal = classDal;
      _validator = validator;
    }
    public ValidationResult Validate(Class entity)
    {
      return _validator.Validate(entity);
    }
    public IDataResult<Class> Add(Class entity)
    {
      throw new NotImplementedException();
    }

    public IDataResult<Task> AddAsync(Class entity)
    {
      throw new NotImplementedException();
    }

    public IResult Any(Expression<Func<Class, bool>> filter)
    {
      throw new NotImplementedException();
    }

    public IDataResult<int> CountWhere(Expression<Func<Class, bool>> filter)
    {
      throw new NotImplementedException();
    }

    public IDataResult<Task<int>> CountWhereAsync(Expression<Func<Class, bool>> filter)
    {
      throw new NotImplementedException();
    }

    public IResult Delete(Class entity)
    {
      throw new NotImplementedException();
    }

    public IResult DeleteById(int id)
    {
      throw new NotImplementedException();
    }

    public IDataResult<Class> FindById(int id)
    {
      throw new NotImplementedException();
    }

    public IDataResult<Task<Class>> FindByIdAsync(int id)
    {
      throw new NotImplementedException();
    }

    public IDataResult<Class> Get(Expression<Func<Class, bool>> filter, string includeProperties = "")
    {
      throw new NotImplementedException();
    }

    public IDataResult<Task<Class>> GetAsync(Expression<Func<Class, bool>> filter, string includeProperties = "")
    {
      throw new NotImplementedException();
    }

    public IEnumerable<IDataResult<Class>> GetList(Expression<Func<Class, bool>> filter = null, Func<IQueryable<Class>, IOrderedQueryable<Class>> orderBy = null, string includeProperties = "")
    {
      throw new NotImplementedException();
    }

    public IDataResult<Task<IEnumerable<Class>>> GetListAsync(Expression<Func<Class, bool>> filter = null, Func<IQueryable<Class>, IOrderedQueryable<Class>> orderBy = null, string includeProperties = "")
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

    public IResult Update(Class entity)
    {
      throw new NotImplementedException();
    }


  }
}
