using Azure;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace PK.Learn.Core.Service.DataAccess
{
    public class RepositoryBase<TContext> : IDisposable, IRepository where TContext : DbContext, new()
    {
        public int Count<T>(Expression<Func<T, bool>> expression) where T : class
        {
            throw new NotImplementedException();
        }

        public int Count<T>() where T : class
        {
            throw new NotImplementedException();
        }

        public virtual void Create<T>(T entity) where T : class
        {
            try
            {
                using var dbContext = Activator.CreateInstance(typeof(TContext), applicationConfiguration) as TContext;

                dbContext.Set<T>().Add(entity);
                dbContext.SaveChanges();
                //entityTracker.EntityCreated(entity);
            }
            catch (Exception exception)
            {
                HandleDbException(exception, ModeOfOperation.Create);
                throw;
            }
        }
        public void CreateList<T>(List<T> entity) where T : class
        {
            throw new NotImplementedException();
        }

        public void Delete<T>(T entity) where T : class
        {
            throw new NotImplementedException();
        }

        public void DeleteList<T>(List<T> entity) where T : class
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public List<List<dynamic>> ExecuteMultipleResult(string spName, SqlParameter[] parameters, Type[] types)
        {
            throw new NotImplementedException();
        }

        public void ExecuteNonQuery(string _sqlQuery, SqlParameter[] parameters)
        {
            throw new NotImplementedException();
        }

        public object ExecuteQuery(string _sqlQuery)
        {
            throw new NotImplementedException();
        }

        public List<Dictionary<string, object>> ExecuteReader(string spName, SqlParameter[] parameters)
        {
            throw new NotImplementedException();
        }

        public dynamic ExecuteScalar(string spName, SqlParameter[] parameters)
        {
            throw new NotImplementedException();
        }

        public List<T> FindAll<T>() where T : class
        {
            throw new NotImplementedException();
        }

        public List<T> FindAllWithExpression<T>(Expression<Func<T, bool>> expression) where T : class
        {
            throw new NotImplementedException();
        }

        public T FindById<T>(long id) where T : class
        {
            throw new NotImplementedException();
        }

        public List<T> FindWithFilter<T, S>(S searchfilter) where T : class
        {
            throw new NotImplementedException();
        }

        public T FirstOrDefault<T>(Expression<Func<T, bool>> expression) where T : class
        {
            throw new NotImplementedException();
        }

        public T FirstOrDefaultWithOrderBy<T>(Expression<Func<T, bool>> expression, Expression<Func<T, dynamic>> orderByExpression, Expression<Func<T, dynamic>> thenOrderByExpression = null) where T : class
        {
            throw new NotImplementedException();
        }

        public T FirstOrDefaultWithOrderByDescending<T>(Expression<Func<T, bool>> expression, Expression<Func<T, dynamic>> orderByExpression, Expression<Func<T, dynamic>> thenOrderByExpression = null) where T : class
        {
            throw new NotImplementedException();
        }

        //public PaginationInput GetPagination<T>(T page)
        //{
        //    throw new NotImplementedException();
        //}

        //public void HandleDbException(Exception exception, ModeOfOperation modeOfOperation = null)
        //{
        //    throw new NotImplementedException();
        //}

        public int Max<T>(Expression<Func<T, bool>> expression, Expression<Func<T, int>> maxExpression) where T : class
        {
            throw new NotImplementedException();
        }

        public Page<T> Pagination<T, S>(S searchfilter) where T : class
        {
            throw new NotImplementedException();
        }

        public void Remove<T>(T entity) where T : class
        {
            throw new NotImplementedException();
        }

        public void RemoveList<T>(List<T> entity) where T : class
        {
            throw new NotImplementedException();
        }

        public void Update<T>(T entity) where T : class
        {
            throw new NotImplementedException();
        }

        public void UpdateList<T>(List<T> entity) where T : class
        {
            throw new NotImplementedException();
        }

        public void UpdateModified<T>(T entity, List<string> propertyName, bool isIncluded) where T : class
        {
            throw new NotImplementedException();
        }

        public void UpdateModifiedList<T>(List<T> entity, List<string> propertyName, bool isInclude) where T : class
        {
            throw new NotImplementedException();
        }
    }
}
