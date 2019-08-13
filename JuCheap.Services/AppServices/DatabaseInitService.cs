using System.Linq;
using System.Threading.Tasks;
using JuCheap.Data;
using JuCheap.Data.Entity;
using JuCheap.Interfaces;
using Mehdime.Entity;

namespace JuCheap.Services.AppServices
{
    /// <summary>
    /// 数据库初始化
    /// </summary>
    public class DatabaseInitService : IDatabaseInitService
    {
        private readonly IDbContextScopeFactory _dbContextScopeFactory;

        /// <summary>
        /// ctor
        /// </summary>
        /// <param name="dbContextScopeFactory"></param>
        public DatabaseInitService(IDbContextScopeFactory dbContextScopeFactory)
        {
            _dbContextScopeFactory = dbContextScopeFactory;
        }

        /// <summary>
        /// 初始化
        /// </summary>
        public void Init()
        {
            InitData.Init();
        }

        /// <summary>
        /// 初始化路径码
        /// </summary>
        public async Task<bool> InitPathCode()
        {
            using (var scope = _dbContextScopeFactory.Create())
            {
                var db = scope.DbContexts.Get<JuCheapContext>();
                var list = InitData.GetPathCodes();
                var pathCodes = db.PathCodes.ToList();
                db.PathCodes.RemoveRange(pathCodes);
                db.PathCodes.AddRange(list);
                return await scope.SaveChangesAsync() > 0;
            }
        }
    }
}
