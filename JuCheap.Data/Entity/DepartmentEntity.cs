namespace JuCheap.Data.Entity
{
    /// <summary>
    /// 部门实体
    /// </summary>
    public class DepartmentEntity : BaseEntity
    {
        /// <summary>
        /// 部门名称
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 上级部门
        /// </summary>
        public string ParentId { get; set; }

        /// <summary>
        /// 路径码=(上级的路径码+当前的Code)
        /// </summary>
        public string PathCode { get; set; }
    }
}
