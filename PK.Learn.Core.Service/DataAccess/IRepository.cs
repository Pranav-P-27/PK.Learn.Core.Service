using Azure;
using Microsoft.Data.SqlClient;
using System.Linq.Expressions;

namespace PK.Learn.Core.Service.DataAccess
{
    public interface IRepository : IDisposable
    {
        List<T> FindAllWithExpression<T>(Expression<Func<T, bool>> expression) where T : class;

        T FirstOrDefault<T>(Expression<Func<T, bool>> expression) where T : class;

        T FirstOrDefaultWithOrderBy<T>(Expression<Func<T, bool>> expression, Expression<Func<T, dynamic>> orderByExpression, Expression<Func<T, dynamic>> thenOrderByExpression = null) where T : class;

        T FirstOrDefaultWithOrderByDescending<T>(Expression<Func<T, bool>> expression, Expression<Func<T, dynamic>> orderByExpression, Expression<Func<T, dynamic>> thenOrderByExpression = null) where T : class;

        int Count<T>(Expression<Func<T, bool>> expression) where T : class;

        int Max<T>(Expression<Func<T, bool>> expression, Expression<Func<T, int>> maxExpression) where T : class;

        List<T> FindAll<T>() where T : class;

        int Count<T>() where T : class;

        List<T> FindWithFilter<T, S>(S searchfilter) where T : class;

        T FindById<T>(long id) where T : class;

        void Create<T>(T entity) where T : class;

        void CreateList<T>(List<T> entity) where T : class;

        void Update<T>(T entity) where T : class;

        void UpdateList<T>(List<T> entity) where T : class;

        void UpdateModified<T>(T entity, List<string> propertyName, bool isIncluded) where T : class;

        void UpdateModifiedList<T>(List<T> entity, List<string> propertyName, bool isInclude) where T : class;

        void Delete<T>(T entity) where T : class;

        void DeleteList<T>(List<T> entity) where T : class;

        void Remove<T>(T entity) where T : class;

        void RemoveList<T>(List<T> entity) where T : class;

        List<Dictionary<string, object>> ExecuteReader(string spName, SqlParameter[] parameters);

        dynamic ExecuteScalar(string spName, SqlParameter[] parameters);

        List<List<dynamic>> ExecuteMultipleResult(string spName, SqlParameter[] parameters, Type[] types);

        Page<T> Pagination<T, S>(S searchfilter) where T : class;

        //public PaginationInput GetPagination<T>(T page);

        //public void HandleDbException(Exception exception, ModeOfOperation modeOfOperation = ModeOfOperation.Delete);

        public object ExecuteQuery(string _sqlQuery);

        void ExecuteNonQuery(string _sqlQuery, SqlParameter[] parameters);
    }
}
