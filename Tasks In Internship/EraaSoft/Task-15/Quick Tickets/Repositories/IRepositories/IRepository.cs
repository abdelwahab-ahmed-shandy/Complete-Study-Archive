using System.Linq.Expressions;

namespace Quick_Tickets.Repositories.IRepositories
{
    public interface IRepository<T>
    {
        // CRUD

        public void Create(T entity);
        public void CreateAll(List<T> entities);
        public void Edit(T entity);
        public void Delete(T entity);
        public void DeleteAll(List<T> entities);
        public void Commit();

        public IQueryable<T> Get(Expression<Func<T, bool>>? filter = null, Expression<Func<T, object>>[]? includes = null, bool tracked = true);

        public T? GetOne(Expression<Func<T, bool>>? filter = null, Expression<Func<T, object>>[]? includes = null, bool tracked = true);
    }
}