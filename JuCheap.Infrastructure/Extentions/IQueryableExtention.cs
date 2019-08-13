using System.Linq;
using System.Linq.Dynamic;

namespace JuCheap.Infrastructure.Extentions
{
    /// <summary>
    /// Queryable扩展
    /// </summary>
    public static class QueryableExtention
    {
        /// <summary>
        /// 自定义排序
        /// </summary>
        /// <typeparam name="T">实体类型</typeparam>
        /// <param name="query">查询对象</param>
        /// <param name="fieldName">字段名称</param>
        /// <param name="sord">排序方式</param>
        /// <returns></returns>
        public static IQueryable<T> OrderByCustom<T>(this IQueryable<T> query, string fieldName, string sord)
        {
            var fields = fieldName.WithDefaultValueIfEmpty("CreateDateTime");
            sord = sord.IsBlank() ? "DESC" : "ASC";
            var sorts = string.Format(" {0} {1} ", fields, sord);
            return query.OrderBy(sorts);
        }
    }
}
