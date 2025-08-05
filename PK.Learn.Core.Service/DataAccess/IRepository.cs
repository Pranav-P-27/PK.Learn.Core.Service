using Azure;
using Microsoft.Data.SqlClient;
using System.Linq.Expressions;

namespace PK.Learn.Core.Service.DataAccess
{
    public interface IRepository<T> where T : class
    {
        Task<IEnumerable<T>> GetAllAsync();
        Task<T> GetByIdAsync(int id);
        Task AddAsync(T entity);
        void Update(T entity);
        void Delete(T entity);
        Task SaveAsync();
    }

}
