using AbcSchool.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbcSchool.Data.Repos
{

    public class BaseRepository<T> : IGenericRepo<T> where T : class
    {
        internal AbcSchoolDbContext context;
        internal DbSet<T> dbSet;


        public BaseRepository(AbcSchoolDbContext context)
        {
            this.context = context;
            
            this.dbSet = context.Set<T>();
        }

        public virtual async Task<T> GetByIDAsync(object id)
        {
            return await dbSet.FindAsync(id);
        }

        public virtual async Task<List<T>> GetAllAsync()
        {
            return await dbSet.ToListAsync();
        }

        public virtual async Task InsertAsync(T entity)
        {
           await dbSet.AddAsync(entity);
           await this.context.SaveChangesAsync();
        }

        public virtual async Task DeleteAsync(object id)
        {
            T entityToDelete = await dbSet.FindAsync(id);
            Delete(entityToDelete);
        }

        public virtual void Delete(T entityToDelete)
        {
            if (context.Entry(entityToDelete).State == EntityState.Detached)
            {
                dbSet.Attach(entityToDelete);
            }
            dbSet.Remove(entityToDelete);
        }

        public virtual void Update(T entityToUpdate)
        {
            dbSet.Attach(entityToUpdate);
            context.Entry(entityToUpdate).State = EntityState.Modified;
        }
    }


}
