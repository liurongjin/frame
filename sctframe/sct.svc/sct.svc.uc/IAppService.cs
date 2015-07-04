using sct.dto.uc;
using sct.cm.data;
using System.Collections.Specialized;
using System.Collections.Generic;



namespace sct.svc.uc
{

    public interface IAppService
    { 

         OperationResult Create(AppInfo info);

         OperationResult Modify(AppInfo info);

         OperationResult Remove(string key);

         AppInfo Load(string key);

         OperationResult Create(IEnumerable<AppInfo> infoList);

         OperationResult Modify(IEnumerable<AppInfo> infoList);

         OperationResult Remove(IEnumerable<string> keyList);

         PageResult<AppInfo>  ListByCondition(NameValueCollection searchCondtionCollection, NameValueCollection sortCollection, int pageNumber, int pageSize);

         List<AppInfo> ListAllByCondition(NameValueCollection searchCondtionCollection, NameValueCollection sortCollection);


    }

}
