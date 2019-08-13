using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using AutoMapper;
using JuCheap.Data;
using JuCheap.Data.Entity;
using JuCheap.Infrastructure;
using JuCheap.Infrastructure.Extentions;
using JuCheap.Infrastructure.Utilities;
using JuCheap.Interfaces;
using JuCheap.Models;
using JuCheap.Models.Filters;
using Mehdime.Entity;

namespace JuCheap.Services.AppServices
{
    /// <summary>
    /// 代理Ip服务
    /// </summary>
    public class ProxyIpService : IProxyIpService
    {
        private readonly IDbContextScopeFactory _dbContextScopeFactory;
        private readonly IMapper _mapper;

        /// <summary>
        /// ctor
        /// </summary>
        /// <param name="dbContextScopeFactory"></param>
        /// <param name="mapper"></param>
        public ProxyIpService(IDbContextScopeFactory dbContextScopeFactory, IMapper mapper)
        {
            _dbContextScopeFactory = dbContextScopeFactory;
            _mapper = mapper;
        }

        /// <summary>
        /// 添加
        /// </summary>
        /// <param name="models">模型</param>
        /// <returns></returns>
        public void AddIfNotExists(List<ProxyIpDto> models)
        {
            using (var scope = _dbContextScopeFactory.Create())
            {
                var db = scope.DbContexts.Get<JuCheapContext>();
                models.ForEach(model =>
                {
                    if (!db.ProxyIps.Any(x => x.Ip == model.Ip && x.Port == model.Port))
                    {
                        var entity = new ProxyIpEntity
                        {
                            Ip = model.Ip,
                            Port = model.Port == 0 ? 80 : model.Port
                        };
                        entity.Create();
                        db.ProxyIps.Add(entity);
                    }
                });
                scope.SaveChanges();
            }
        }

        /// <summary>
        /// 获取待验证的代理Ip
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        public IList<ProxyIpDto> GetWaitValidateIps(int number)
        {
            using (var scope = _dbContextScopeFactory.CreateReadOnly())
            {
                var db = scope.DbContexts.Get<JuCheapContext>();
                var query = db.ProxyIps.Where(x => !x.IsDeleted);

                return query.OrderBy(x => x.LastUpdateTime).Take(number)
                    .Select(x => new ProxyIpDto
                    {
                        Id = x.Id,
                        Ip = x.Ip,
                        Port = x.Port
                    }).ToList();
            }
        }

        /// <summary>
        /// 更新
        /// </summary>
        /// <param name="id">主键</param>
        /// <param name="success">代理ip是否有效</param>
        public void Update(string id, bool success)
        {
            using (var scope = _dbContextScopeFactory.Create())
            {
                var db = scope.DbContexts.Get<JuCheapContext>();
                var ip = db.ProxyIps.Find(id);
                if (ip != null)
                {
                    ip.UseTimes += 1;
                    if (success)
                    {
                        ip.SuccessTimes += 1;
                    }
                    if (ip.UseTimes > 0)
                    {
                        ip.SuccessRate = Convert.ToDecimal(ip.SuccessTimes) / Convert.ToDecimal(ip.UseTimes);
                    }
                    ip.LastUpdateTime = DateTime.Now;
                }
                scope.SaveChanges();
            }
        }
    }
}
