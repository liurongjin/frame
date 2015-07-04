using sct.dto.cms;
using sct.cm.data;
using System.Collections.Specialized;
using System.Collections.Generic;



namespace sct.svc.cms
{

    public interface IAdviceService
    { 

         OperationResult Create(AdviceInfo info);

         OperationResult Modify(AdviceInfo info);

         OperationResult Remove(string key);

         AdviceInfo Load(string key);

         OperationResult Create(IEnumerable<AdviceInfo> infoList);

         OperationResult Modify(IEnumerable<AdviceInfo> infoList);

         OperationResult Remove(IEnumerable<string> keyList);

         PageResult<AdviceInfo>  ListByCondition(NameValueCollection searchCondtionCollection, NameValueCollection sortCollection, int pageNumber, int pageSize);

         List<AdviceInfo> ListAllByCondition(NameValueCollection searchCondtionCollection, NameValueCollection sortCollection);


    }

}
