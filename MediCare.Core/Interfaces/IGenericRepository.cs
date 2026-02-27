using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediCare.Core.Interfaces
{
    public interface IGenericRepository<T, TKey>
    {
        Task<T?> GetById(TKey id);
        Task<T> Add(T entity);
        Task Update(T entity);
        Task Delete(TKey id);
        Task<IEnumerable<T>> GetAll();
    }
}
