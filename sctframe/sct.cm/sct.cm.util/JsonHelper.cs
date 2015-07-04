using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Json;
using System.Text;


namespace sct.cm.util
{
    /// <summary>
    /// Json对象与实体对象换
    /// </summary>
    public class JsonHelper
    {
        /// <summary>  
        /// 生成Json格式  
        /// </summary>  
        /// <typeparam name="T"></typeparam>  
        /// <param name="obj"></param>  
        /// <returns></returns>  
        public static string GetJson<T>(T obj)
        {
            DataContractJsonSerializer json = new DataContractJsonSerializer(obj.GetType());
            using (MemoryStream stream = new MemoryStream())
            {
                json.WriteObject(stream, obj);
                string szJson = Encoding.UTF8.GetString(stream.ToArray()); return szJson;
            }
        }
        /// <summary>  
        /// 获取Json的Model  
        /// </summary>  
        /// <typeparam name="T"></typeparam>  
        /// <param name="szJson"></param>  
        /// <returns></returns>  
        public static T ParseFromJson<T>(string szJson)
        {
            T obj = Activator.CreateInstance<T>();
            using (MemoryStream ms = new MemoryStream(Encoding.UTF8.GetBytes(szJson)))
            {
                DataContractJsonSerializer serializer = new DataContractJsonSerializer(obj.GetType());
                return (T)serializer.ReadObject(ms);
            }
        }
    }
    /// <summary>
    /// 将对象转为json对象
    /// </summary>
    [Serializable]
    public class JsonResultHelper
    {
        public JsonResultHelper(object jsonData)
        {
            IsSuccess = true;
            JsonData = jsonData;
        }


        public JsonResultHelper(bool isSuccess, object jsonData)
        {
            IsSuccess = isSuccess;
            JsonData = jsonData;
        }

        public JsonResultHelper(bool isSuccess, string message, object jsonData)
        {
            IsSuccess = isSuccess;
            Message = message;
            JsonData = jsonData;
        }

        public JsonResultHelper(bool isSuccess, string message, string detailMessage, object jsonData)
        {
            IsSuccess = isSuccess;
            Message = message;
            DetaillMessage = detailMessage;
            JsonData = jsonData;
        }

        public bool IsSuccess { get; set; }
        public string Message { get; set; }
        public string DetaillMessage { get; set; }
        public object JsonData { get; set; }

    }

    /// <summary>
    /// 不带有footer的DataGrid返回数据包装
    /// </summary>
    /// <typeparam name="T"></typeparam>
    [Serializable]
    public class JsonDataGridHelper<T> where T : class
    {
        public int total = 0;
        public IList<T> rows = null;

        public JsonDataGridHelper(IList<T> rows)
        {
            if (rows != null)
            {
                this.total = rows.Count;
                this.rows = rows;
            }
        }

        public JsonDataGridHelper(IList<T> rows, int total)
        {
            this.total = total;
            this.rows = rows;
        }

    }

    /// <summary>
    /// 带有footer的DataGrid返回数据包装
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <typeparam name="M"></typeparam>
    [Serializable]
    public class JsonDataGridHelper<T, M>
        where T : class
        where M : class
    {
        public int total = 0;
        public IList<T> rows = null;
        public IList<M> footer = null;

        public JsonDataGridHelper(IList<T> rows, IList<M> footer)
        {
            if (rows != null)
            {
                this.total = rows.Count;
                this.rows = rows;
            }
            this.footer = footer;
        }

        public JsonDataGridHelper(IList<T> rows, IList<M> footer, int total)
        {
            this.total = total;
            this.rows = rows;
            this.footer = footer;
        }

    }
}