using System.ComponentModel;

namespace sct.dto.cms
{
    public class EnumSet
    {

        /// <summary>
        /// 语种
        /// </summary>
        public enum Language
        {
            /// <summary>
            /// 英语
            /// </summary>
            [DescriptionAttribute("英语")]
            English = 0,

            /// <summary>
            /// 汉语
            /// </summary>
            [DescriptionAttribute("汉语")]
            Chinese = 1
        }

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


        /// <summary>
        /// 链接类型
        /// </summary>
        public enum FriendType
        {
            /// <summary>
            /// 合作关系
            /// </summary>
            [DescriptionAttribute("合作关系")]
            Cooperation = 0,

            /// <summary>
            /// 友情关系
            /// </summary>
            [DescriptionAttribute("友情关系")]
            FriendShip = 1
        }



        /// <summary>
        /// 留言类型
        /// </summary>
        public enum AdviceState
        {
            /// <summary>
            /// 待处理
            /// </summary>
            [DescriptionAttribute("待处理")]
            Ready = 0,

            /// <summary>
            /// 处理中
            /// </summary>
            [DescriptionAttribute("处理中")]
            Operating = 1,

            /// <summary>
            /// 已完成
            /// </summary>
            [DescriptionAttribute("已完成")]
            Finished = 2
        }

    }
}

