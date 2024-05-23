using UnitOfWorkDemo.Models;

namespace UnitOfWorkDemo.Repositories
{
    public interface IUnitOfWork : IDisposable
    {
        IRepository<Product> Products { get; }
        Task<int> CompleteAsync();
    }
}
