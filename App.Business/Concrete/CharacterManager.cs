using App.Business.Abstract;
using App.Core.Utilities.Results;
using App.DataAccess.Abstract;
using App.Entities.Concrete;
using FluentValidation;
using FluentValidation.Results;
using System.Linq.Expressions;

namespace App.Business.Concrete
{
  public class CharacterManager : ICharacterService
  {
    ICharacterDal _characterDal;
    IValidator<Character> _validator;
    public CharacterManager(ICharacterDal characterDal, IValidator<Character> validator)
    {
      _characterDal = characterDal;
      _validator = validator;
    }
    public ValidationResult Validate(Character entity)
    {
      return _validator.Validate(entity);
    }
    public IDataResult<Character> Add(Character entity)
    {
      throw new NotImplementedException();
    }

    public IDataResult<Task> AddAsync(Character entity)
    {
      throw new NotImplementedException();
    }

    public IResult Any(Expression<Func<Character, bool>> filter)
    {
      throw new NotImplementedException();
    }

    public IDataResult<int> CountWhere(Expression<Func<Character, bool>> filter)
    {
      throw new NotImplementedException();
    }

    public IDataResult<Task<int>> CountWhereAsync(Expression<Func<Character, bool>> filter)
    {
      throw new NotImplementedException();
    }

    public IResult Delete(Character entity)
    {
      throw new NotImplementedException();
    }

    public IResult DeleteById(int id)
    {
      throw new NotImplementedException();
    }

    public IDataResult<Character> FindById(int id)
    {
      throw new NotImplementedException();
    }

    public IDataResult<Task<Character>> FindByIdAsync(int id)
    {
      throw new NotImplementedException();
    }

    public IDataResult<Character> Get(Expression<Func<Character, bool>> filter, string includeProperties = "")
    {
      throw new NotImplementedException();
    }

    public IDataResult<Task<Character>> GetAsync(Expression<Func<Character, bool>> filter, string includeProperties = "")
    {
      throw new NotImplementedException();
    }

    public IEnumerable<IDataResult<Character>> GetList(Expression<Func<Character, bool>> filter = null, Func<IQueryable<Character>, IOrderedQueryable<Character>> orderBy = null, string includeProperties = "")
    {
      throw new NotImplementedException();
    }

    public IDataResult<Task<IEnumerable<Character>>> GetListAsync(Expression<Func<Character, bool>> filter = null, Func<IQueryable<Character>, IOrderedQueryable<Character>> orderBy = null, string includeProperties = "")
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

    public IResult Update(Character entity)
    {
      throw new NotImplementedException();
    }
  }
}
