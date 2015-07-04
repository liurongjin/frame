using sct.dto.uc;
using sct.cm.data;
using System.Collections.Specialized;
using System.Collections.Generic;



namespace sct.svc.uc
{

    public interface IRoleService
    { 

         OperationResult Create(RoleInfo info);

         OperationResult Modify(RoleInfo info);

         OperationResult Remove(string key);

         RoleInfo Load(string key);

         OperationResult Create(IEnumerable<RoleInfo> infoList);

         OperationResult Modify(IEnumerable<RoleInfo> infoList);

         OperationResult Remove(IEnumerable<string> keyList);

         PageResult<RoleInfo>  ListByCondition(NameValueCollection searchCondtionCollection, NameValueCollection sortCollection, int pageNumber, int pageSize);

         List<RoleInfo> ListAllByCondition(NameValueCollection searchCondtionCollection, NameValueCollection sortCollection);


    }

}
