using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using JuCheap.Data;
using JuCheap.Data.Entity;
using JuCheap.Infrastructure;
using JuCheap.Infrastructure.Extentions;
using JuCheap.Interfaces;
using JuCheap.Models;
using JuCheap.Models.Filters;
using Mehdime.Entity;

namespace JuCheap.Services.AppServices
{
    /// <summary>
    /// 部门契约服务
    /// </summary>
    public class DepartmentService : IDepartmentService
    {
        private readonly IDbContextScopeFactory _dbContextScopeFactory;
        private readonly IMapper _mapper;

        /// <summary>
        /// ctor
        /// </summary>
        /// <param name="dbContextScopeFactory"></param>
        /// <param name="mapper"></param>
        public DepartmentService(IDbContextScopeFactory dbContextScopeFactory, IMapper mapper)
        {
            _dbContextScopeFactory = dbContextScopeFactory;
            _mapper = mapper;
        }

        /// <summary>
        /// 添加部门
        /// </summary>
        /// <param name="dto">部门模型</param>
        /// <returns></returns>
        public async Task<string> Add(DepartmentDto dto)
        {
            using (var scope = _dbContextScopeFactory.Create())
            {
                var db = scope.DbContexts.Get<JuCheapContext>();
                var entity = _mapper.Map<DepartmentDto, DepartmentEntity>(dto);
                entity.Create();
                entity.PathCode = await GetPathCode(db, entity.ParentId);
                db.Departments.Add(entity);
                await scope.SaveChangesAsync();
                return entity.Id;
            }
        }

        /// <summary>
        /// 更新部门
        /// </summary>
        /// <param name="dto">部门模型</param>
        /// <returns></returns>
        public async Task<bool> Update(DepartmentDto dto)
        {
            using (var scope = _dbContextScopeFactory.Create())
            {
                var db = scope.DbContexts.Get<JuCheapContext>();
                var entity = db.Departments.Load(dto.Id);
                _mapper.Map(dto, entity);
                await scope.SaveChangesAsync();
                return true;
            }
        }

        /// <summary>
        /// 根据主键查询模型
        /// </summary>
        /// <param name="id">主键</param>
        /// <returns></returns>
        public async Task<DepartmentDto> Find(string id)
        {
            if (id.IsBlank())
                return null;
            using (var scope = _dbContextScopeFactory.CreateReadOnly())
            {
                var db = scope.DbContexts.Get<JuCheapContext>();
                var entity = await db.Departments.LoadAsync(id);
                var result = _mapper.Map<DepartmentEntity, DepartmentDto>(entity);
                if (result.ParentId.IsNotBlank())
                {
                    var parent = await db.Departments.FindAsync(entity.ParentId);
                    result.ParentName = parent.Name;
                }
                return result;
            }
        }

        /// <summary>
        /// 根据父部门ID查询
        /// </summary>
        /// <param name="parentId">父部门ID</param>
        /// <returns></returns>
        public async Task<IList<TreeDto>> FindByParentId(string parentId)
        {
            using (var scope = _dbContextScopeFactory.CreateReadOnly())
            {
                var db = scope.DbContexts.Get<JuCheapContext>();
                var query = db.Departments.Where(x => !x.IsDeleted && x.ParentId == parentId);
                return await query.Select(x => new TreeDto
                {
                    id = x.Id,
                    name = x.Name,
                    pId = x.ParentId,
                    isParent = db.Departments.Any(c => c.ParentId == x.Id)
                }).ToListAsync();
            }
        }

        /// <summary>
        /// 批量删除
        /// </summary>
        /// <param name="ids">主键ID集合</param>
        /// <returns></returns>
        public async Task<bool> Delete(IEnumerable<string> ids)
        {
            using (var scope = _dbContextScopeFactory.Create())
            {
                var db = scope.DbContexts.Get<JuCheapContext>();
                var departments = db.Departments.Where(x => !x.IsDeleted && ids.Contains(x.Id)).ToList();

                if (!departments.AnyOne()) return false;

                foreach (var department in departments)
                {
                    department.IsDeleted = true;
                }
                await scope.SaveChangesAsync();
                return true;
            }
        }

        /// <summary>
        /// 分页搜索
        /// </summary>
        /// <param name="filters">查询过滤参数</param>
        /// <returns></returns>
        public async Task<PagedResult<DepartmentDto>> Search(BaseFilter filters)
        {
            if (filters == null)
                return new PagedResult<DepartmentDto>();

            using (var scope = _dbContextScopeFactory.CreateReadOnly())
            {
                var db = scope.DbContexts.Get<JuCheapContext>();
                var query = db.Departments.Where(item => !item.IsDeleted);

                if (filters.keywords.IsNotBlank())
                    query = query.Where(item => item.Name.Contains(filters.keywords));

                return await query.OrderByCustom(filters.sidx, filters.sord)
                    .Select(item => new DepartmentDto
                    {
                        Id = item.Id,
                        ParentId = item.ParentId,
                        Name = item.Name
                    }).PagingAsync(filters.page, filters.rows);
            }
        }

        /// <summary>
        /// 获取路径码
        /// </summary>
        /// <param name="db"></param>
        /// <param name="parentId"></param>
        /// <returns></returns>
        private async Task<string> GetPathCode(JuCheapContext db, string parentId)
        {
            //顶级页面
            List<string> existCodes;
            var parentPathCode = string.Empty;
            if (parentId.IsBlank())
            {
                var list = await db.Departments
                    .Where(x => !x.IsDeleted && (x.ParentId == null || x.ParentId == string.Empty))
                    .Select(x => x.PathCode).ToListAsync();
                existCodes = list.Select(x => x.Trim()).ToList();
            }
            else
            {
                var department = await db.Departments.LoadAsync(parentId);
                parentPathCode = department.PathCode;

                var list = await db.Departments.Where(x => x.ParentId == parentId && x.PathCode != string.Empty)
                    .Select(x => x.PathCode).ToListAsync();
                existCodes = list.Select(x => x.Substring(department.PathCode.Trim().Length, 2)).ToList();
            }
            var pathCode = await db.PathCodes
                .OrderBy(x => x.Code)
                .FirstOrDefaultAsync(x => !existCodes.Contains(x.Code));
            return parentPathCode.Trim() + pathCode.Code.Trim();
        }
    }
}
