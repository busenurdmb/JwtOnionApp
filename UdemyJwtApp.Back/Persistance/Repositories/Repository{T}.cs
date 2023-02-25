using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;
using UdemyJwtApp.Back.Core.Application.Interfaces;
using UdemyJwtApp.Back.Persistance.Context;

namespace UdemyJwtApp.Back.Persistance.Repositories
{
    public class Repository<T> : IRepository<T> where T : class, new()
    {
        private readonly UdemyJwtContext _context;

        public Repository(UdemyJwtContext context)
        {
            _context = context;
        }

        public async Task CreateAsync(T entity)
        {
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
            await _context.Set<T>().AddAsync(entity);
            await _context.SaveChangesAsync();
=======
         await  _context.Set<T>().AddAsync(entity);
          await  _context.SaveChangesAsync();
>>>>>>> cab2227dde6026f0271e7c9b5bf05b2b4c1aef24
=======
         await  _context.Set<T>().AddAsync(entity);
          await  _context.SaveChangesAsync();
>>>>>>> cab2227dde6026f0271e7c9b5bf05b2b4c1aef24
=======
         await  _context.Set<T>().AddAsync(entity);
          await  _context.SaveChangesAsync();
>>>>>>> cab2227dde6026f0271e7c9b5bf05b2b4c1aef24
        }

        public async Task<List<T>> GetAllAsync()
        {
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
            return await _context.Set<T>().AsNoTracking().ToListAsync();

        }

        public async Task<T?> GetByFilterAsync(Expression<Func<T, bool>> filter)
=======
=======
>>>>>>> cab2227dde6026f0271e7c9b5bf05b2b4c1aef24
=======
>>>>>>> cab2227dde6026f0271e7c9b5bf05b2b4c1aef24
          return  await _context.Set<T>().AsNoTracking().ToListAsync(); 
           
        }

        public async  Task<T?> GetByFilterAsync(Expression<Func<T, bool>> filter)
<<<<<<< HEAD
<<<<<<< HEAD
>>>>>>> cab2227dde6026f0271e7c9b5bf05b2b4c1aef24
=======
>>>>>>> cab2227dde6026f0271e7c9b5bf05b2b4c1aef24
=======
>>>>>>> cab2227dde6026f0271e7c9b5bf05b2b4c1aef24
        {
            return await _context.Set<T>().AsNoTracking().SingleOrDefaultAsync(filter);
        }

        public async Task<T?> GetByIdAsync(object id)
        {
            return await _context.Set<T>().FindAsync(id);
        }

        public async Task RemoveAsync(T entity)
        {
            _context.Set<T>().Remove(entity);
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
            await _context.SaveChangesAsync();
=======
           await _context.SaveChangesAsync();
>>>>>>> cab2227dde6026f0271e7c9b5bf05b2b4c1aef24
=======
           await _context.SaveChangesAsync();
>>>>>>> cab2227dde6026f0271e7c9b5bf05b2b4c1aef24
=======
           await _context.SaveChangesAsync();
>>>>>>> cab2227dde6026f0271e7c9b5bf05b2b4c1aef24
        }

        public async Task UpdateAsync(T entity)
        {
            _context.Set<T>().Update(entity);
            await _context.SaveChangesAsync();
        }
    }
}
