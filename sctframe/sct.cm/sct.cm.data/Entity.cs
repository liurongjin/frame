using System;
using System.ComponentModel.DataAnnotations;

namespace sct.cm.data
{
    /// <summary>
    ///     可持久到数据库的领域模型的基类。
    /// </summary>
    [Serializable]
    public abstract class Entity
    {
        #region 构造函数

        /// <summary>
        ///     数据实体基类
        /// </summary>
        protected Entity()
        {
            SYS_OrderSeq = 0;
            SYS_IsValid = 1;
            SYS_IsDeleted = 0;
            SYS_CreateTime = DateTime.Now;
            SYS_ModifyTime = DateTime.Now;
            SYS_DeleteTime = DateTime.Now;
        }

        #endregion

        #region 属性
        [StringLength(36)]
        public string Id { get; set; }



        public int SYS_OrderSeq { get; set; }

        public int SYS_IsValid { get; set; }

        public int SYS_IsDeleted { get; set; }

        [StringLength(500)]
        public string SYS_Remark { get; set; }

        [StringLength(36)]
        public string SYS_StaffId { get; set; }

        [StringLength(36)]
        public string SYS_StationId { get; set; }

        [StringLength(36)]
        public string SYS_DepartmentId { get; set; }

        [StringLength(36)]
        public string SYS_CompanyId { get; set; }

        [StringLength(36)]
        public string SYS_AppId { get; set; }

        [DataType(DataType.Date)]
        public DateTime SYS_CreateTime { get; set; }

        [DataType(DataType.DateTime)]
        public DateTime SYS_ModifyTime { get; set; }

        [DataType(DataType.Date)]
        public DateTime SYS_DeleteTime { get; set; }



        /*
        /// <summary>
        ///     获取或设置 版本控制标识，用于处理并发
        /// </summary>
        [ConcurrencyCheck]
        [Timestamp]
        public byte[] Timestamp { get; set; }
        */
        #endregion
    }
}