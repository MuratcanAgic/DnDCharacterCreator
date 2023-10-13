using App.Business.Abstract;
using App.Business.Constants;
using App.Business.ValidationRules.FluentValidation;
using App.Core.Aspect.Autofac.Validation;
using App.Core.Utilities.Business;
using App.Core.Utilities.Results;
using App.DataAccess.Abstract;
using App.Entities.Concrete;
using System.Linq.Expressions;

namespace App.Business.Concrete
{
  public class AbilityManager : IAbilityService
  {
    IAbilityDal _abilityDal;

    public AbilityManager(IAbilityDal abilityDal)
    {
      _abilityDal = abilityDal;
    }

    [ValidationAspect(typeof(AbilityValidator))]
    public IResult Add(Ability entity)
    {

      IResult result = BusinessRules.Run(); //this will run business rules defined in this classs

      if (result != null)
      {
        return result;
      }
      _abilityDal.Add(entity);
      return new SuccessResult(Messages.AbilityAdded);
    }

    public IDataResult<Task> AddAsync(Ability entity)
    {
      throw new NotImplementedException();
    }

    public IResult Any(Expression<Func<Ability, bool>> filter)
    {
      throw new NotImplementedException();
    }

    public IDataResult<int> CountWhere(Expression<Func<Ability, bool>> filter)
    {
      throw new NotImplementedException();
    }

    public IDataResult<Task<int>> CountWhereAsync(Expression<Func<Ability, bool>> filter)
    {
      throw new NotImplementedException();
    }

    public IResult Delete(Ability entity)
    {
      throw new NotImplementedException();
    }

    public IResult DeleteById(int id)
    {
      throw new NotImplementedException();
    }

    public IDataResult<Ability> FindById(int id)
    {
      throw new NotImplementedException();
    }

    public IDataResult<Task<Ability>> FindByIdAsync(int id)
    {
      throw new NotImplementedException();
    }

    public IDataResult<Ability> Get(Expression<Func<Ability, bool>> filter, string includeProperties = "")
    {
      throw new NotImplementedException();
    }

    public IDataResult<Task<Ability>> GetAsync(Expression<Func<Ability, bool>> filter, string includeProperties = "")
    {
      throw new NotImplementedException();
    }

    public IEnumerable<IDataResult<Ability>> GetList(Expression<Func<Ability, bool>> filter = null, Func<IQueryable<Ability>, IOrderedQueryable<Ability>> orderBy = null, string includeProperties = "")
    {
      throw new NotImplementedException();
    }

    public IDataResult<Task<IEnumerable<Ability>>> GetListAsync(Expression<Func<Ability, bool>> filter = null, Func<IQueryable<Ability>, IOrderedQueryable<Ability>> orderBy = null, string includeProperties = "")
    {
      throw new NotImplementedException();
    }

    public IResult Save()
    {
      _abilityDal.Save();
      return new SuccessResult("Ability Saved");
    }

    public IDataResult<Task<int>> SaveAsync()
    {
      throw new NotImplementedException();
    }

    public IResult Update(Ability entity)
    {
      throw new NotImplementedException();
    }
  }
}
