
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
        #region Dbset Jcgl;
        public virtual DbSet<Books> Books { get; set; }
        public virtual DbSet<BookSelectChangeHistorys> BookSelectChangeHistorys { get; set; }
        public virtual DbSet<BookSelectLists> BookSelectLists { get; set; }
        public virtual DbSet<BookSelectReports> BookSelectReports { get; set; }
        public virtual DbSet<Catalogues> Catalogues { get; set; }
        public virtual DbSet<Checks> Checks { get; set; }
        public virtual DbSet<Classification> Classification { get; set; }
        public virtual DbSet<ClassificationTreeDic> ClassificationTreeDic { get; set; }
        public virtual DbSet<ClassificationTreeDicContent> ClassificationTreeDicContent { get; set; }
        public virtual DbSet<ContinueLoanRecord> ContinueLoanRecord { get; set; }
        public virtual DbSet<Courses> Courses { get; set; }
        public virtual DbSet<Destroys> Destroys { get; set; }
        public virtual DbSet<GradeOrder> GradeOrder { get; set; }
        public virtual DbSet<GradeOrderDetail> GradeOrderDetail { get; set; }
        public virtual DbSet<Grades> Grades { get; set; }
        public virtual DbSet<Loan> Loan { get; set; }
        public virtual DbSet<LoanHistory> LoanHistory { get; set; }
        public virtual DbSet<Location> Location { get; set; }
        public virtual DbSet<OperateHistorys> OperateHistorys { get; set; }
        public virtual DbSet<OrderLists> OrderLists { get; set; }
        public virtual DbSet<Orders> Orders { get; set; }
        public virtual DbSet<OrderSignIn> OrderSignIn { get; set; }
        public virtual DbSet<OrderSignInDetails> OrderSignInDetails { get; set; }
        public virtual DbSet<Plans> Plans { get; set; }
        public virtual DbSet<PrintLists> PrintLists { get; set; }
        public virtual DbSet<Prints> Prints { get; set; }
        public virtual DbSet<ReceiveAndReturn> ReceiveAndReturn { get; set; }
        public virtual DbSet<ReceiveAndReturnList> ReceiveAndReturnList { get; set; }
        public virtual DbSet<Releases> Releases { get; set; }
        public virtual DbSet<RoleConfigEntity> RoleConfig { get; set; }
        public virtual DbSet<ShelfCodeConfig> ShelfCodeConfig { get; set; }
        public virtual DbSet<Speciality> Speciality { get; set; }
        public virtual DbSet<SpecialityCoursesRelation> SpecialityCoursesRelation { get; set; }
        public virtual DbSet<StockChangeHistorys> StockChangeHistorys { get; set; }
        public virtual DbSet<StockOutLists> StockOutLists { get; set; }
        public virtual DbSet<User> User { get; set; }
        #endregion;
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
            #region  IsUnicode Jcgl;
            modelBuilder.Entity<Books>()
                .Property(e => e.BookCoding)
                .IsUnicode(false);

            modelBuilder.Entity<Books>()
                .Property(e => e.BookCodebar)
                .IsUnicode(false);

            modelBuilder.Entity<Books>()
                .Property(e => e.CatalogueCoding)
                .IsUnicode(false);

            modelBuilder.Entity<Books>()
                .Property(e => e.LocationCoding)
                .IsUnicode(false);

            modelBuilder.Entity<Books>()
                .Property(e => e.ShelfCoding)
                .IsUnicode(false);

            modelBuilder.Entity<BookSelectChangeHistorys>()
                .Property(e => e.ID)
                .IsUnicode(false);

            modelBuilder.Entity<BookSelectChangeHistorys>()
                .Property(e => e.BookSelectListID)
                .IsUnicode(false);

            modelBuilder.Entity<BookSelectChangeHistorys>()
                .Property(e => e.CourseCoding)
                .IsUnicode(false);

            modelBuilder.Entity<BookSelectChangeHistorys>()
                .Property(e => e.CatalogueCoding)
                .IsUnicode(false);

            modelBuilder.Entity<BookSelectChangeHistorys>()
                .Property(e => e.Operator)
                .IsUnicode(false);

            modelBuilder.Entity<BookSelectLists>()
                .Property(e => e.BookSelectListID)
                .IsUnicode(false);

            modelBuilder.Entity<BookSelectLists>()
                .Property(e => e.CourseCoding)
                .IsUnicode(false);

            modelBuilder.Entity<BookSelectLists>()
                .Property(e => e.CatalogueCoding)
                .IsUnicode(false);

            modelBuilder.Entity<BookSelectLists>()
                .Property(e => e.SelectUserID)
                .IsUnicode(false);

            modelBuilder.Entity<BookSelectReports>()
                .Property(e => e.BookSelectCoding)
                .IsUnicode(false);

            modelBuilder.Entity<BookSelectReports>()
                .Property(e => e.Operator)
                .IsUnicode(false);

            modelBuilder.Entity<Catalogues>()
                .Property(e => e.CatalogueCoding)
                .IsUnicode(false);

            modelBuilder.Entity<Catalogues>()
                .Property(e => e.EngKeywords)
                .IsUnicode(false);

            modelBuilder.Entity<Catalogues>()
                .Property(e => e.Summary)
                .IsUnicode(false);

            modelBuilder.Entity<Catalogues>()
                .Property(e => e.EngSummary)
                .IsUnicode(false);

            modelBuilder.Entity<Catalogues>()
                .Property(e => e.Operator)
                .IsUnicode(false);

            modelBuilder.Entity<Catalogues>()
                .Property(e => e.Demo)
                .IsUnicode(false);

            modelBuilder.Entity<Checks>()
                .Property(e => e.PlanCoding)
                .IsUnicode(false);

            modelBuilder.Entity<Checks>()
                .Property(e => e.CheckCoding)
                .IsUnicode(false);

            modelBuilder.Entity<Checks>()
                .Property(e => e.CheckRoleID)
                .IsUnicode(false);

            modelBuilder.Entity<Checks>()
                .Property(e => e.CheckuserID)
                .IsUnicode(false);

            modelBuilder.Entity<Checks>()
                .Property(e => e.CheckDigitalsignature)
                .IsFixedLength();

            modelBuilder.Entity<Checks>()
                .Property(e => e.CheckUserCoding)
                .IsUnicode(false);

            modelBuilder.Entity<Checks>()
                .Property(e => e.NextStepCoding)
                .IsUnicode(false);

            modelBuilder.Entity<Checks>()
                .Property(e => e.Demo)
                .IsUnicode(false);

            modelBuilder.Entity<Classification>()
                .Property(e => e.CategoriesCoding)
                .IsUnicode(false);

            modelBuilder.Entity<Classification>()
                .Property(e => e.CLS_Coding)
                .IsUnicode(false);

            modelBuilder.Entity<Classification>()
                .Property(e => e.ClassCode)
                .IsUnicode(false);

            modelBuilder.Entity<ClassificationTreeDic>()
                .Property(e => e.CLS_Coding)
                .IsUnicode(false);

            modelBuilder.Entity<ClassificationTreeDicContent>()
                .Property(e => e.CLS_Coding)
                .IsUnicode(false);

            modelBuilder.Entity<ClassificationTreeDicContent>()
                .Property(e => e.ClassParentID)
                .IsUnicode(false);

            modelBuilder.Entity<ContinueLoanRecord>()
                .Property(e => e.BookCodebar)
                .IsUnicode(false);

            modelBuilder.Entity<ContinueLoanRecord>()
                .Property(e => e.Userbar)
                .IsUnicode(false);

            modelBuilder.Entity<Courses>()
                .Property(e => e.CourseCoding)
                .IsUnicode(false);

            modelBuilder.Entity<Destroys>()
                .Property(e => e.DestroyCoding)
                .IsUnicode(false);

            modelBuilder.Entity<Destroys>()
                .Property(e => e.DestroyAgent)
                .IsUnicode(false);

            modelBuilder.Entity<GradeOrder>()
                .Property(e => e.ID)
                .IsUnicode(false);

            modelBuilder.Entity<GradeOrder>()
                .Property(e => e.GradeOrderCoding)
                .IsUnicode(false);

            modelBuilder.Entity<GradeOrder>()
                .Property(e => e.ClassCoding)
                .IsUnicode(false);

            modelBuilder.Entity<GradeOrderDetail>()
                .Property(e => e.GradeOrderID)
                .IsUnicode(false);

            modelBuilder.Entity<GradeOrderDetail>()
                .Property(e => e.GradeOrderDetailCoding)
                .IsUnicode(false);

            modelBuilder.Entity<GradeOrderDetail>()
                .Property(e => e.CatalogueCoding)
                .IsUnicode(false);

            modelBuilder.Entity<Grades>()
                .Property(e => e.ClassCoding)
                .IsUnicode(false);

            modelBuilder.Entity<Grades>()
                .Property(e => e.ClassManagerID)
                .IsUnicode(false);

            modelBuilder.Entity<Loan>()
                .Property(e => e.CatalogueCoding)
                .IsUnicode(false);

            modelBuilder.Entity<Loan>()
                .Property(e => e.BookCodebar)
                .IsUnicode(false);

            modelBuilder.Entity<Loan>()
                .Property(e => e.ReaderCoding)
                .IsUnicode(false);

            modelBuilder.Entity<LoanHistory>()
                .Property(e => e.CatalogueCoding)
                .IsUnicode(false);

            modelBuilder.Entity<LoanHistory>()
                .Property(e => e.BookCodebar)
                .IsUnicode(false);

            modelBuilder.Entity<LoanHistory>()
                .Property(e => e.ReaderCoding)
                .IsUnicode(false);

            modelBuilder.Entity<LoanHistory>()
                .Property(e => e.Operator)
                .IsUnicode(false);

            modelBuilder.Entity<Location>()
                .Property(e => e.ID)
                .IsUnicode(false);

            modelBuilder.Entity<Location>()
                .Property(e => e.LocationCode)
                .IsUnicode(false);

            modelBuilder.Entity<OperateHistorys>()
                .Property(e => e.Operator)
                .IsUnicode(false);

            modelBuilder.Entity<OperateHistorys>()
                .Property(e => e.OpContent)
                .IsUnicode(false);

            modelBuilder.Entity<OperateHistorys>()
                .Property(e => e.Demo)
                .IsUnicode(false);

            modelBuilder.Entity<OrderLists>()
                .Property(e => e.ID)
                .IsUnicode(false);

            modelBuilder.Entity<OrderLists>()
                .Property(e => e.OrderListsCoding)
                .IsUnicode(false);

            modelBuilder.Entity<OrderLists>()
                .Property(e => e.OrderCoding)
                .IsUnicode(false);

            modelBuilder.Entity<OrderLists>()
                .Property(e => e.CataloguesCoding)
                .IsUnicode(false);

            modelBuilder.Entity<Orders>()
                .Property(e => e.OrderCoding)
                .IsUnicode(false);

            modelBuilder.Entity<Orders>()
                .Property(e => e.OrderUnitCoding)
                .IsUnicode(false);

            modelBuilder.Entity<Orders>()
                .Property(e => e.Agent)
                .IsUnicode(false);

            modelBuilder.Entity<OrderSignIn>()
                .Property(e => e.ID)
                .IsUnicode(false);

            modelBuilder.Entity<OrderSignIn>()
                .Property(e => e.SignInCoding)
                .IsUnicode(false);

            modelBuilder.Entity<OrderSignIn>()
                .Property(e => e.SignInSourceCoding)
                .IsUnicode(false);

            modelBuilder.Entity<OrderSignIn>()
                .Property(e => e.Operator)
                .IsUnicode(false);

            modelBuilder.Entity<OrderSignIn>()
                .Property(e => e.Demo)
                .IsUnicode(false);

            modelBuilder.Entity<OrderSignInDetails>()
                .Property(e => e.ID)
                .IsUnicode(false);

            modelBuilder.Entity<OrderSignInDetails>()
                .Property(e => e.SignInCodingDetail)
                .IsUnicode(false);

            modelBuilder.Entity<OrderSignInDetails>()
                .Property(e => e.SignInCoding)
                .IsUnicode(false);

            modelBuilder.Entity<OrderSignInDetails>()
                .Property(e => e.CatalogueCoding)
                .IsUnicode(false);

            modelBuilder.Entity<OrderSignInDetails>()
                .Property(e => e.Operator)
                .IsUnicode(false);

            modelBuilder.Entity<Plans>()
                .Property(e => e.PlanCoding)
                .IsUnicode(false);

            modelBuilder.Entity<Plans>()
                .Property(e => e.SourceCoding)
                .IsUnicode(false);

            modelBuilder.Entity<Plans>()
                .Property(e => e.Operator)
                .IsUnicode(false);

            modelBuilder.Entity<PrintLists>()
                .Property(e => e.PrintListCoding)
                .IsUnicode(false);

            modelBuilder.Entity<PrintLists>()
                .Property(e => e.PrintCoding)
                .IsUnicode(false);

            modelBuilder.Entity<PrintLists>()
                .Property(e => e.CatalogueCoding)
                .IsUnicode(false);

            modelBuilder.Entity<Prints>()
                .Property(e => e.PrintCoding)
                .IsUnicode(false);

            modelBuilder.Entity<ReceiveAndReturn>()
                .Property(e => e.R2RCoding)
                .IsUnicode(false);

            modelBuilder.Entity<ReceiveAndReturn>()
                .Property(e => e.ClassOrderCoding)
                .IsUnicode(false);

            modelBuilder.Entity<ReceiveAndReturn>()
                .Property(e => e.Operator)
                .IsUnicode(false);

            modelBuilder.Entity<ReceiveAndReturn>()
                .Property(e => e.AgentUserCoding)
                .IsUnicode(false);

            modelBuilder.Entity<ReceiveAndReturnList>()
                .Property(e => e.R2RListCoding)
                .IsUnicode(false);

            modelBuilder.Entity<ReceiveAndReturnList>()
                .Property(e => e.R2RCoding)
                .IsUnicode(false);

            modelBuilder.Entity<ReceiveAndReturnList>()
                .Property(e => e.CatalogueCoding)
                .IsUnicode(false);

            modelBuilder.Entity<ReceiveAndReturnList>()
                .Property(e => e.Operator)
                .IsUnicode(false);

            modelBuilder.Entity<Releases>()
                .Property(e => e.ReleaseCoding)
                .IsUnicode(false);

            modelBuilder.Entity<ShelfCodeConfig>()
                .Property(e => e.LocationCoding)
                .IsUnicode(false);

            modelBuilder.Entity<Speciality>()
                .Property(e => e.ID)
                .IsUnicode(false);

            modelBuilder.Entity<Speciality>()
                .Property(e => e.SpecialityCoding)
                .IsUnicode(false);

            modelBuilder.Entity<SpecialityCoursesRelation>()
                .Property(e => e.ID)
                .IsUnicode(false);

            modelBuilder.Entity<SpecialityCoursesRelation>()
                .Property(e => e.SpecialityCoding)
                .IsUnicode(false);

            modelBuilder.Entity<SpecialityCoursesRelation>()
                .Property(e => e.CourseCoding)
                .IsUnicode(false);

            modelBuilder.Entity<SpecialityCoursesRelation>()
                .Property(e => e.Operator)
                .IsUnicode(false);

            modelBuilder.Entity<StockChangeHistorys>()
                .Property(e => e.ID)
                .IsUnicode(false);

            modelBuilder.Entity<StockChangeHistorys>()
                .Property(e => e.StockChangeSourceCoding)
                .IsUnicode(false);

            modelBuilder.Entity<StockChangeHistorys>()
                .Property(e => e.CatalogueCoding)
                .IsUnicode(false);

            modelBuilder.Entity<StockChangeHistorys>()
                .Property(e => e.BookCodebar)
                .IsUnicode(false);

            modelBuilder.Entity<StockChangeHistorys>()
                .Property(e => e.BookCoding)
                .IsUnicode(false);

            modelBuilder.Entity<StockChangeHistorys>()
                .Property(e => e.Operator)
                .IsUnicode(false);

            modelBuilder.Entity<StockOutLists>()
                .Property(e => e.StockOutListCoding)
                .IsUnicode(false);

            modelBuilder.Entity<StockOutLists>()
                .Property(e => e.SourceCoding)
                .IsUnicode(false);

            modelBuilder.Entity<StockOutLists>()
                .Property(e => e.CatalogueCoding)
                .IsUnicode(false);

            modelBuilder.Entity<StockOutLists>()
                .Property(e => e.Demo)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .Property(e => e.ID)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .Property(e => e.RoleID)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .Property(e => e.UserBar)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .Property(e => e.OneCardPassID)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .Property(e => e.Password)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .Property(e => e.Fingerprint1)
                .IsFixedLength();

            modelBuilder.Entity<User>()
                .Property(e => e.Fingerprint2)
                .IsFixedLength();

            modelBuilder.Entity<User>()
                .Property(e => e.Telephone)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .Property(e => e.CardNumber)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .Property(e => e.Demo)
                .IsUnicode(false);
            #endregion;
        }
    }
}


