using System.ComponentModel;

namespace sct.cm.data
{
    public class EnumSet
    {

        /// <summary>
        /// 布尔值
        /// </summary>
        public enum EnumBoolen
        {
            /// <summary>
            /// 否
            /// </summary>
            [DescriptionAttribute("否")]
            False = 0,


            /// <summary>
            /// 是
            /// </summary>
            [DescriptionAttribute("是")]
            True = 1,
        }
    }
}