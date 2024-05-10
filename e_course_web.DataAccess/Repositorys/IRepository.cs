using System.Linq.Expressions;
using System.Threading.Tasks;

namespace e_course_web.DataAccess.Repositorys
{
    public interface IRepository<T> where T : class
    {
        Task<T> GetById(int? id);
        IEnumerable<T> GetAll(Expression<Func<T, bool>> filter = null,
            Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null,
            string includeProperties = null);
        T GetFirstOrDefault(
           Expression<Func<T, bool>> filter = null,
           string includeProperties = null
           );

        void Add(T value); 
        void Update(T value);
        void Delete(T entity);
    }
}
