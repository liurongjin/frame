using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;

namespace sct.cm.data
{
    /// <summary>
    ///     表示业务操作结果的枚举
    /// </summary>
    [Description("业务操作结果的枚举")]
    public enum OperationResultType
    {
        /// <summary>
        ///     操作成功
        /// </summary>
        [Description("操作成功。")]
        Success,

        /// <summary>
        ///     操作取消或操作没引发任何变化
        /// </summary>
        [Description("操作没有引发任何变化，提交取消。")]
        NoChanged,

        /// <summary>
        ///     参数错误
        /// </summary>
        [Description("参数错误。")]
        ParamError,

        /// <summary>
        ///     指定参数的数据不存在
        /// </summary>
        [Description("指定参数的数据不存在。")]
        QueryNull,

        /// <summary>
        ///     权限不足
        /// </summary>
        [Description("当前用户权限不足，不能继续操作。")]
        PurviewLack,

        /// <summary>
        ///     非法操作
        /// </summary>
        [Description("非法操作。")]
        IllegalOperation,

        /// <summary>
        ///     警告
        /// </summary>
        [Description("警告")]
        Warning,

        /// <summary>
        ///     操作引发错误
        /// </summary>
        [Description("操作引发错误。")]
        Error,
    }

    /// <summary>
    ///     业务操作结果信息类，对操作结果进行封装
    /// </summary>
    public class OperationResult
    {
        #region 构造函数

        /// <summary>
        ///     初始化一个 业务操作结果信息类 的新实例
        /// </summary>
        /// <param name="resultType">业务操作结果类型</param>
        public OperationResult(OperationResultType resultType)
        {
            ResultType = resultType;
        }

        /// <summary>
        ///     初始化一个 定义返回消息的业务操作结果信息类 的新实例
        /// </summary>
        /// <param name="resultType">业务操作结果类型</param>
        /// <param name="message">业务返回消息</param>
        public OperationResult(OperationResultType resultType, string message)
            : this(resultType)
        {
            Message = message;
        }

        /// <summary>
        ///     初始化一个 定义返回消息与附加数据的业务操作结果信息类 的新实例
        /// </summary>
        /// <param name="resultType">业务操作结果类型</param>
        /// <param name="message">业务返回消息</param>
        /// <param name="appendData">业务返回数据</param>
        public OperationResult(OperationResultType resultType, string message, object appendData)
            : this(resultType, message)
        {
            AppendData = appendData;
        }

        /// <summary>
        ///     初始化一个 定义返回消息与日志消息的业务操作结果信息类 的新实例
        /// </summary>
        /// <param name="resultType">业务操作结果类型</param>
        /// <param name="message">业务返回消息</param>
        /// <param name="logMessage">业务日志记录消息</param>
        public OperationResult(OperationResultType resultType, string message, string logMessage)
            : this(resultType, message)
        {
            LogMessage = logMessage;
        }

        /// <summary>
        ///     初始化一个 定义返回消息、日志消息与附加数据的业务操作结果信息类 的新实例
        /// </summary>
        /// <param name="resultType">业务操作结果类型</param>
        /// <param name="message">业务返回消息</param>
        /// <param name="logMessage">业务日志记录消息</param>
        /// <param name="appendData">业务返回数据</param>
        public OperationResult(OperationResultType resultType, string message, string logMessage, object appendData)
            : this(resultType, message, logMessage)
        {
            AppendData = appendData;
        }

        #endregion

        #region 属性

        /// <summary>
        ///     获取或设置 操作结果类型
        /// </summary>
        public OperationResultType ResultType { get; set; }

        /// <summary>
        ///     获取或设置 操作返回信息
        /// </summary>
        public string Message { get; set; }

        /// <summary>
        ///     获取或设置 操作返回的日志消息，用于记录日志
        /// </summary>
        public string LogMessage { get; set; }

        /// <summary>
        ///     获取或设置 操作结果附加信息
        /// </summary>
        public object AppendData { get; set; }

        #endregion
    }
}