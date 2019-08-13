
/*******************************************************************************
* Copyright (C) JuCheap.Com
* 
* Author: dj.wong
* Create Date: 2015/8/21
* Description: Automated building by service@jucheap.com 
* 
* Revision History:
* Date         Author               Description
*
*********************************************************************************/

using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using JuCheap.Data.Config;
using JuCheap.Data.Entity;

namespace JuCheap.Data
{
    /// <summary>
    /// JuCheapContext
    /// </summary>
    public class JuCheapContext : DbContext
    {
		#region DbSet
		/// <summary>
        /// Area
        /// </summary>
        public DbSet<AreaEntity> Areas { get; set; }
		/// <summary>
        /// Department
        /// </summary>
        public DbSet<DepartmentEntity> Departments { get; set; }
		/// <summary>
        /// LoginLog
        /// </summary>
        public DbSet<LoginLogEntity> LoginLogs { get; set; }
		/// <summary>
        /// Menu
        /// </summary>
        public DbSet<MenuEntity> Menus { get; set; }
		/// <summary>
        /// PageView
        /// </summary>
        public DbSet<PageViewEntity> PageViews { get; set; }
		/// <summary>
        /// PathCode
        /// </summary>
        public DbSet<PathCodeEntity> PathCodes { get; set; }
		/// <summary>
        /// Role
        /// </summary>
        public DbSet<RoleEntity> Roles { get; set; }
		/// <summary>
        /// SystemConfig
        /// </summary>
        public DbSet<SystemConfigEntity> SystemConfigs { get; set; }
		/// <summary>
        /// User
        /// </summary>
        public DbSet<UserEntity> Users { get; set; }

        /// <summary>
        /// 代理Ip
        /// </summary>
        public DbSet<ProxyIpEntity> ProxyIps { get; set; }

        /// <summary>
        /// 邮件订阅
        /// </summary>
        public DbSet<EmailSubscribeEntity> EmailSubscribes { get; set; }

        /// <summary>
        /// 网站访问量统计
        /// </summary>
        public DbSet<SiteViewEntity> SiteViews { get; set; }

        #endregion

        /// <summary>
        /// JuCheapContext
        /// </summary>
        public JuCheapContext() : base("JuCheap")
        {
            //SQL语句拦截器
            //System.Data.Entity.Infrastructure.Interception.DbInterception.Add(new SqlCommandInterceptor());
        }

        /// <summary>
        /// 带参数构造函数
        /// </summary>
        /// <param name="connectionString">数据库连接字符串名称</param>
        public JuCheapContext(string connectionString) : base(connectionString)
        {
        }

        /// <summary>
        /// OnModelCreating
        /// </summary>
        /// <param name="modelBuilder"></param>
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //移除一对多的级联删除关系
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            //移除表名复数形式
            modelBuilder.Conventions.Remove<PluralizingEntitySetNameConvention>();

            //配置实体和数据表的关系
            modelBuilder.Configurations.AddFromAssembly(typeof(UserConfig).Assembly);
        }
    }
}


