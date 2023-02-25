using Microsoft.EntityFrameworkCore;
using Onion.JwtApp.Application.Interfaces;
using Onion.JwtApp.Persistence.Context;
using System.Linq.Expressions;

namespace Onion.JwtApp.Persistence.Repositories
{
    public class Repository<T> : IRepository<T> where T : class, new()
    {
        private readonly JwtContext _context;

        public Repository(JwtContext context)
        {
            _context = context;
        }

        public async Task<T?> CreateAsync(T entity)
        {
            await _context.Set<T>().AddAsync(entity);
            await _context.SaveChangesAsync();
            return entity;
        }



        public async Task<List<T>> GetAllAsync()
        {
            return await _context.Set<T>().AsNoTracking().ToListAsync();

        }

        public async Task<T?> GetByFilterAsync(Expression<Func<T, bool>> filter)
        {
            return await _context.Set<T>().AsNoTracking().SingleOrDefaultAsync(filter);
        }

        public async Task<T?> GetByIdAsync(object id)
        {
            //UPDATE VE DELETE BUNU KULLANIYOR İZLİYOR
            return await _context.Set<T>().FindAsync(id);
        }

        public async Task RemoveAsync(T entity)
        {
            _context.Set<T>().Remove(entity);
            await _context.SaveChangesAsync();
        }

        public async Task<int> SaveChangesAsync()
        {
            return await _context.SaveChangesAsync();

        }

        public async Task UpdateAsync(T entity)
        {
            //Update->entity statetin statini modified olarak setleirm diyor ancak primary key değeri varsa göndermediysen added olarak setlerim
            _context.Set<T>().Update(entity);
            await _context.SaveChangesAsync();
        }
    }
}
