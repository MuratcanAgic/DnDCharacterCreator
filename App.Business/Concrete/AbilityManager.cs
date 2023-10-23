using App.Business.Abstract;
using App.Business.Constants;
using App.Core.Utilities.Business;
using App.Core.Utilities.Results;
using App.DataAccess.Abstract;
using App.Entities.Concrete;
using FluentValidation;
using FluentValidation.Results;
using System.Linq.Expressions;

namespace App.Business.Concrete
{
  public class AbilityManager : IAbilityService
  {
    IAbilityDal _abilityDal;
    IValidator<Ability> _validator;
    public AbilityManager(IAbilityDal abilityDal, IValidator<Ability> validator)
    {
      _abilityDal = abilityDal;
      _validator = validator;
    }

    public ValidationResult Validate(Ability entity)
    {
      return _validator.Validate(entity);
    }

    public IDataResult<Ability> Add(Ability entity)
    {
      try
      {
        //business result
        IResult result = BusinessRules.Run(); //this will run business rules defined in this classs

        if (result != null)
        {
          return new ErrorDataResult<Ability>(entity, result.Message);
        }

        _abilityDal.Add(entity);
        return new SuccessDataResult<Ability>(entity, Messages.AbilityAdded);
      }
      catch (Exception e)
      {
        return new ErrorDataResult<Ability>($"Ability couldn't be added! Error: {e.Message}");

      }
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
      try
      {
        _abilityDal.Save();
      }
      catch (Exception e)
      {

        return new ErrorResult($"Ability couldn't be saved! Error: {e.Message}");
      }

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
