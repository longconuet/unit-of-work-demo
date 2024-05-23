using System.Linq.Expressions;

namespace UnitOfWorkDemo.Repositories
{
    public interface IRepository<T> where T : class
    {
        Task<T> GetByIdAsync(int id);
        Task<IEnumerable<T>> GetAllAsync();
        Task AddAsync(T entity);
        Task RemoveAsync(T entity);
        Task<IEnumerable<T>> GetListAsync(Expression<Func<T, bool>> predicate);
    }
}
