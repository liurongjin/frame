using sct.cm.data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web.Mvc;

namespace sct.cm.util
{
    
    public static class HtmlSetter
    {
        /// <summary>
        /// 下拉框绑定枚举内容
        /// </summary>
        /// <param name="enumType">待绑定的枚举类型</param>
        /// <param name="isAddedShowText">是否增加显示文本[值为空]</param>
        /// <param name="showText">增加的显示文本，默认为[ "--请选择--"]</param>
        /// <returns>下拉框绑定枚举内容</returns>
        public static SelectList EnumToList(Type enumType, bool isAddedShowText, string showText = "--请选择--")
        {
            List<SelectListItem> list = new List<SelectListItem>();
            foreach (int i in Enum.GetValues(enumType))
            {
                string name = Enum.GetName(enumType, i);
                //取枚举显示名称
                string showName = string.Empty;
                object[] atts = enumType.GetField(name).GetCustomAttributes(typeof(DescriptionAttribute), false);
                if (atts.Length > 0) showName = ((DescriptionAttribute)atts[0]).Description;

                list.Add(new SelectListItem() { Value = i.ToString(), Text = string.IsNullOrEmpty(showName) ? name : showName });
            }

            if (isAddedShowText)
            {
                list.Insert(0, new SelectListItem() { Value = "", Text = showText });
            }

            return new SelectList(new SelectList(list.AsEnumerable(), "Value", "Text"), "Value", "Text");

        }


        /// <summary>
        /// 下拉框绑定树形控件
        /// </summary>
        /// <param name="list">待绑定的树形列表原始数据</param>
        /// <param name="nMaxShowLevel">最大显示层级[默认显示2级]</param>
        /// <param name="isAddedShowText">是否增加显示文本[默认不显示，且值为空]</param>
        /// <param name="showText">增加的显示文本，默认为[ "--请选择--"]</param>
        /// <returns>下拉框绑定树形控件</returns>
        public static SelectList ListToList(List<ChooseDictionary> list, bool isAddedShowText = false, string showText = "--请选择--")
        {
            List<ChooseDictionary> aimList = new List<ChooseDictionary>();

            foreach (var select in list)
            {
                aimList.Add(new ChooseDictionary() { Text = select.Text, Value = select.Value, ParentId = select.ParentId });
            }
            if (isAddedShowText)
            {
                aimList.Insert(0, new ChooseDictionary() { Value = "", Text = showText });
            }
            return new SelectList(new SelectList(aimList.AsEnumerable(), "Value", "Text"), "Value", "Text");
        }


        /// <summary>
        /// 下拉框绑定树形控件
        /// </summary>
        /// <param name="list">待绑定的树形列表原始数据</param>
        /// <param name="nMaxShowLevel">最大显示层级[默认显示2级]</param>
        /// <param name="isAddedShowText">是否增加显示文本[默认不显示，且值为空]</param>
        /// <param name="showText">增加的显示文本，默认为[ "--请选择--"]</param>
        /// <returns>下拉框绑定树形控件</returns>
        public static SelectList ListToTreeList(List<ChooseDictionary> list, int nMaxShowLevel = 2, bool isAddedShowText = false, string showText = "--请选择--")
        {
            List<ChooseDictionary> aimList = new List<ChooseDictionary>();
            ListToTreeList(list, null, "", nMaxShowLevel, 0, ref aimList);
            if (isAddedShowText)
            {
                aimList.Insert(0, new ChooseDictionary() { Value = "", Text = showText });
            }
            return new SelectList(new SelectList(aimList.AsEnumerable(), "Value", "Text"), "Value", "Text");
        }



        /// <summary>
        /// 将原始的数据转换为树型的列表格式
        /// </summary>
        /// <param name="sourceList">原始的数据</param>
        /// <param name="strParentValue">上级编号</param>
        /// <param name="strParentPad">上级间隔</param>
        /// <param name="nMaxLevel">显示的最高层级</param>
        /// <param name="nLevelIndex">当前层级</param>
        /// <param name="aimList">转换后树型格式列表</param>
        private static void ListToTreeList(List<ChooseDictionary> sourceList, string strParentValue, string strParentPad, int nMaxLevel, int nIndexLevel, ref List<ChooseDictionary> aimList)
        {
            if (sourceList != null && sourceList.Count > 0)
            {
                nIndexLevel += 1;
                var sList = sourceList.Where(x => object.Equals(x.ParentId, strParentValue)).ToList();
                if (sList != null && sList.Count > 0)
                {
                    strParentPad = strParentPad + "&nbsp;&nbsp;";
                    for (int i = 0; i < sList.Count; i++)
                    {
                        if (i == sList.Count - 1)
                        {
                            aimList.Add(new ChooseDictionary() { Text = System.Web.HttpUtility.HtmlDecode(strParentPad) + "└" + sList[i].Text, Value = sList[i].Value, ParentId = sList[i].ParentId });
                        }
                        else
                        {
                            aimList.Add(new ChooseDictionary() { Text = System.Web.HttpUtility.HtmlDecode(strParentPad) + "├" + sList[i].Text, Value = sList[i].Value, ParentId = sList[i].ParentId });

                        }
                        if (nIndexLevel < nMaxLevel)
                        {
                            ListToTreeList(sourceList, sList[i].Value, strParentPad, nMaxLevel, nIndexLevel, ref aimList);
                        }
                    }
                }
            }
        }
    }

}