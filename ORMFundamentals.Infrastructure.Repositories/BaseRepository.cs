using ORMFundamentals.Domain.Models.EntityModels;
using ORMFundamentals.Domain.Repository;
using ORMFundamentals.Infrastructure.Store.DatabaseContext;
using System;
using System.Linq;

namespace ORMFundamentals.Infrastructure.Repositories
{

    public class BaseRepository<T> : IBaseRepository<T> where T : BaseModel
    {
        private CommercialContext _database;
        protected CommercialContext Database
        {
            get
            {
                return _database = _database ?? new CommercialContext();
            }
        }

        public  T Add(T entity)
        {
            try
            {
                Database.Set<T>().Add(entity);
                Database.SaveChanges();
                return entity;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }


        public IQueryable<T> Get()
        {
            return Database.Set<T>();
        }

        public T Update(T entity)
        {
            try
            {
                Database.Set<T>().Update(entity);
                Database.Entry(entity).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                Database.SaveChanges();
                return entity;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}


