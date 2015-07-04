using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;

/// <summary>
/// Config 的摘要说明
/// </summary>
public static class Config
{
    private static bool noCache = true;
    private static JObject BuildItems()
    {
        JObject o = new JObject();
        var json = File.ReadAllText(HttpContext.Current.Server.MapPath("~/Script/Common/ueditor/net/config.json"));
        if (!string.IsNullOrEmpty(json))
        {
            var reg = @"(/\\\*([^*]|[\\\r\\\n]|(\\\*+([^*/]|[\\\r\\\n])))*\\\*+/)|(//.*)";
            json = Regex.Replace(json, reg, "");
        }
        try
        {
            o = JObject.Parse(json);
        }
        catch (Exception ex)
        {
            HttpContext.Current.Response.Write(ex.Message);
        }
        return o;
    }

    public static JObject Items
    {
        get
        {
            if (noCache || _Items == null)
            {
                _Items = BuildItems();
            }
            return _Items;
        }
    }
    private static JObject _Items;


    public static T GetValue<T>(string key)
    {
        return Items[key].Value<T>();
    }

    public static String[] GetStringList(string key)
    {
        return Items[key].Select(x => x.Value<String>()).ToArray();
    }

    public static String GetString(string key)
    {
        return GetValue<String>(key);
    }

    public static int GetInt(string key)
    {
        return GetValue<int>(key);
    }
}