using e_course_web.DataAccess.DbContext;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace e_course_web.DataAccess.Repositorys
{
    public class Repository<T> : IRepository<T> where T : class
    {
        private readonly ApplicationDbContext _context;
        private DbSet<T> entities;
        public Repository(ApplicationDbContext context) {
            _context = context;
            entities = context.Set<T>();
        }

        public async Task<T> GetById(int? id)
        {
            return await entities.FindAsync(id);
        }

        public void Add(T entity)
        {
            entities.Add(entity);
            _context.SaveChanges();
        }

        public void Delete(T entity)
        {
            entities.Remove(entity);
            _context.SaveChanges();
        }

        public void Update(T entity)
        {
            entities.Update(entity);
             _context.SaveChanges();
        }

        public IEnumerable<T> GetAll(Expression<Func<T, bool>> filter = null, Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null, string includeProperties = null)
        {
            IQueryable<T> query = entities;

            if (filter != null)
            {
                query = query.Where(filter);
            }

            //Configures index include properties 
            // cau hinh chỉ muc
            if (includeProperties != null)
            {
                foreach (var includeProp in includeProperties.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries))
                {
                    query = query.Include(includeProp);
                }
            }

            if (orderBy != null)
            {
                return orderBy(query).ToList();
            }
            return query.ToList();
        }

        public T GetFirstOrDefault(Expression<Func<T, bool>> filter = null, string includeProperties = null)
        {
            IQueryable<T> query = entities;

            if (filter != null)
            {
                query = query.Where(filter);
            }

            if (includeProperties != null)
            {
                foreach (var includeProp in includeProperties.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries))
                {
                    query = query.Include(includeProp);
                }
            }

            return query.FirstOrDefault();
        }
    }
}
