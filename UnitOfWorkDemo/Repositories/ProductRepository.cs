using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;
using UnitOfWorkDemo.Data;
using UnitOfWorkDemo.Models;

namespace UnitOfWorkDemo.Repositories
{
    public class ProductRepository : IRepository<Product>
    {
        private readonly AppDbContext _context;

        public ProductRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task AddAsync(Product entity)
        {
            await _context.Products.AddAsync(entity);
        }

        public async Task<IEnumerable<Product>> GetAllAsync()
        {
            return await _context.Products.ToListAsync();
        }

        public async Task<Product> GetByIdAsync(int id)
        {
            return await _context.Products.FindAsync(id);
        }

        public async Task<IEnumerable<Product>> GetListAsync(Expression<Func<Product, bool>> predicate)
        {
            return await _context.Products.Where(predicate).ToListAsync();
        }

        public async Task RemoveAsync(Product entity)
        {
            _context.Products.Remove(entity);
        }
    }
}
