using System;
using System.Linq;

namespace ORMFundamentals.Domain.Repository
{
    public interface IBaseRepository<T>
    {

            IQueryable<T> Get();
            T Update(T entity);
            T Add(T entity);

    }
}
