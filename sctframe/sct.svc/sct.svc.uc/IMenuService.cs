using sct.dto.uc;
using sct.cm.data;
using System.Collections.Specialized;
using System.Collections.Generic;



namespace sct.svc.uc
{

    public interface IMenuService
    { 

         OperationResult Create(MenuInfo info);

         OperationResult Modify(MenuInfo info);

         OperationResult Remove(string key);

         MenuInfo Load(string key);

         OperationResult Create(IEnumerable<MenuInfo> infoList);

         OperationResult Modify(IEnumerable<MenuInfo> infoList);

         OperationResult Remove(IEnumerable<string> keyList);

         PageResult<MenuInfo>  ListByCondition(NameValueCollection searchCondtionCollection, NameValueCollection sortCollection, int pageNumber, int pageSize);

         List<MenuInfo> ListAllByCondition(NameValueCollection searchCondtionCollection, NameValueCollection sortCollection);


    }

}
