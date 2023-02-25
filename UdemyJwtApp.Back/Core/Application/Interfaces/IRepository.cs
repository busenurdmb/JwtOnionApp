using System.Linq.Expressions;

namespace UdemyJwtApp.Back.Core.Application.Interfaces
{
<<<<<<< HEAD
<<<<<<< HEAD
    public interface IRepository<T> where T : class, new()
=======
    public interface IRepository<T>where T : class,new()
>>>>>>> cab2227dde6026f0271e7c9b5bf05b2b4c1aef24
=======
    public interface IRepository<T>where T : class,new()
>>>>>>> cab2227dde6026f0271e7c9b5bf05b2b4c1aef24
    {
        Task<List<T>> GetAllAsync();
        Task<T?> GetByIdAsync(object id);
        Task<T?> GetByFilterAsync(Expression<Func<T, bool>> filter);
        Task CreateAsync(T entity);
        Task UpdateAsync(T entity);
        Task RemoveAsync(T entity);

    }
}
