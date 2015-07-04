using sct.dto.uc;
using sct.cm.data;
using System.Collections.Specialized;
using System.Collections.Generic;



namespace sct.svc.uc
{

    public interface IClientTypeService
    { 

         OperationResult Create(ClientTypeInfo info);

         OperationResult Modify(ClientTypeInfo info);

         OperationResult Remove(string key);

         ClientTypeInfo Load(string key);

         OperationResult Create(IEnumerable<ClientTypeInfo> infoList);

         OperationResult Modify(IEnumerable<ClientTypeInfo> infoList);

         OperationResult Remove(IEnumerable<string> keyList);

         PageResult<ClientTypeInfo>  ListByCondition(NameValueCollection searchCondtionCollection, NameValueCollection sortCollection, int pageNumber, int pageSize);

         List<ClientTypeInfo> ListAllByCondition(NameValueCollection searchCondtionCollection, NameValueCollection sortCollection);


    }

}
