using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace OnlineExaminationDAL.Repository
{
    public interface IGenericRepository<T>:IDisposable
    {
        IEnumerable<T> GetAll(
            Expression<Func<Task, bool>> filter = null,
            Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null,
            string includeProperties = "");

        T GetById(object id);
        void DeleteById(object id);
        Task<T> GetByIdAsync(object id);
        Task<T> AddAsync(T entity);
        Task<T> UpdateAsync(T entityToUpdate);
        Task<T> DeleteAsync(T entityToDelete);
        void Add(T entity);
        void Update(T entityToUpdate);
        void Delete(T entityToDelete);

    }
}
