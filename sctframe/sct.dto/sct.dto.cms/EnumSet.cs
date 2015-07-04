using System.ComponentModel;

namespace sct.dto.cms
{
    public class EnumSet
    {

        /// <summary>
        /// 资讯类型
        /// </summary>
        public enum ArticleType
        {
            /// <summary>
            /// 文章
            /// </summary>
            [DescriptionAttribute("文章")]
            Article = 0,

            /// <summary>
            /// 图片
            /// </summary>
            [DescriptionAttribute("图片")]
            Picture = 1,

            /// <summary>
            /// 视频
            /// </summary>
            [DescriptionAttribute("视频")]
            Video = 2
        }



        /// <summary>
        /// 资讯审核类型
        /// </summary>
        public enum ArticleAuditState
        {
            /// <summary>
            /// 编辑
            /// </summary>
            [DescriptionAttribute("编辑")]
            Edit = 0,

            /// <summary>
            /// 待审
            /// </summary>
            [DescriptionAttribute("待审")]
            Ready = 1,

            /// <summary>
            /// 不通过
            /// </summary>
            [DescriptionAttribute("不通过")]
            Failure = 2,

            /// <summary>
            /// 通过
            /// </summary>
            [DescriptionAttribute("通过")]
            Sucess = 3
        }



        /// <summary>
        /// 板块类型
        /// </summary>
        public enum PlateType
        {
            /// <summary>
            /// 文字链接
            /// </summary>
            [DescriptionAttribute("文字链接")]
            Text = 0,

            /// <summary>
            /// 图片链接
            /// </summary>
            [DescriptionAttribute("图片链接")]
            Picture = 1,

            /// <summary>
            /// 图文链接
            /// </summary>
            [DescriptionAttribute("图文链接")]
            Article = 2,

            /// <summary>
            /// 视频链接
            /// </summary>
            [DescriptionAttribute("视频")]
            Video = 3
        }
    }
}

