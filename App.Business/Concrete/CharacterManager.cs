using App.Business.Abstract;
using App.Core.Utilities.Results;
using App.DataAccess.Abstract;
using App.Entities.Concrete;
using System.Linq.Expressions;

namespace App.Business.Concrete
{
  public class CharacterManager : ICharacterService
  {
    ICharacterDal _characterDal;

    public CharacterManager(ICharacterDal characterDal)
    {
      _characterDal = characterDal;
    }

    public IResult Add(Character entity)
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
