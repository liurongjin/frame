using System;
using System.Runtime.Serialization;

namespace sct.cm.data
{
    /// <summary>
    /// 用于显示下拉的转换对象
    /// </summary>
    [DataContract]
    [Serializable]
    public class ChooseDictionary
    { 
        /// <summary>
        /// 展示信息
        /// </summary>
        [DataMember]
        public string Text { get; set; }

        /// <summary>
        /// 值
        /// </summary>
        [DataMember]
        public string Value { get; set; }

        /// <summary>
        /// 父值
        /// </summary>
        [DataMember]
        public string ParentId { get; set; }

        /// <summary>
        /// 是否选中
        /// </summary>
        [DataMember]
        public bool Selected { get; set; }

    }
}
