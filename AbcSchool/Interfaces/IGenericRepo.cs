using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace AbcSchool.Interfaces
{
    public interface IGenericRepo<T> where T : class
    {
        
        void Delete(T entityToDelete);

        Task DeleteAsync(object id);

        Task<T> GetByIDAsync(object id);

        Task<List<T>> GetAllAsync();

        Task InsertAsync(T entity);

        void Update(T entityToUpdate);
    }
}
