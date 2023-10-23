using App.Business.Abstract;
using App.Core.Utilities.Results;
using App.DataAccess.Abstract;
using App.Entities.Concrete;
using FluentValidation;
using FluentValidation.Results;
using System.Linq.Expressions;

namespace App.Business.Concrete
{
  public class SubclassManager : IsubClassService
  {
    ISubclassDal _subclassDal;
    IValidator<Subclass> _validator;
    public SubclassManager(ISubclassDal subclassDal, IValidator<Subclass> validator)
    {
      _subclassDal = subclassDal;
      _validator = validator;
    }
    public ValidationResult Validate(Subclass entity)
    {
      return _validator.Validate(entity);
    }

    public IDataResult<Subclass> Add(Subclass entity)
    {
      throw new NotImplementedException();
    }

    public IDataResult<Task> AddAsync(Subclass entity)
    {
      throw new NotImplementedException();
    }

    public IResult Any(Expression<Func<Subclass, bool>> filter)
    {
      throw new NotImplementedException();
    }

    public IDataResult<int> CountWhere(Expression<Func<Subclass, bool>> filter)
    {
      throw new NotImplementedException();
    }

    public IDataResult<Task<int>> CountWhereAsync(Expression<Func<Subclass, bool>> filter)
    {
      throw new NotImplementedException();
    }

    public IResult Delete(Subclass entity)
    {
      throw new NotImplementedException();
    }

    public IResult DeleteById(int id)
    {
      throw new NotImplementedException();
    }

    public IDataResult<Subclass> FindById(int id)
    {
      throw new NotImplementedException();
    }

    public IDataResult<Task<Subclass>> FindByIdAsync(int id)
    {
      throw new NotImplementedException();
    }

    public IDataResult<Subclass> Get(Expression<Func<Subclass, bool>> filter, string includeProperties = "")
    {
      throw new NotImplementedException();
    }

    public IDataResult<Task<Subclass>> GetAsync(Expression<Func<Subclass, bool>> filter, string includeProperties = "")
    {
      throw new NotImplementedException();
    }

    public IEnumerable<IDataResult<Subclass>> GetList(Expression<Func<Subclass, bool>> filter = null, Func<IQueryable<Subclass>, IOrderedQueryable<Subclass>> orderBy = null, string includeProperties = "")
    {
      throw new NotImplementedException();
    }

    public IDataResult<Task<IEnumerable<Subclass>>> GetListAsync(Expression<Func<Subclass, bool>> filter = null, Func<IQueryable<Subclass>, IOrderedQueryable<Subclass>> orderBy = null, string includeProperties = "")
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

    public IResult Update(Subclass entity)
    {
      throw new NotImplementedException();
    }
  }
}
