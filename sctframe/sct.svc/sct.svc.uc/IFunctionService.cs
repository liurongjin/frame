using sct.dto.uc;
using sct.cm.data;
using System.Collections.Specialized;
using System.Collections.Generic;



namespace sct.svc.uc
{

    public interface IFunctionService
    { 

         OperationResult Create(FunctionInfo info);

         OperationResult Modify(FunctionInfo info);

         OperationResult Remove(string key);

         FunctionInfo Load(string key);

         OperationResult Create(IEnumerable<FunctionInfo> infoList);

         OperationResult Modify(IEnumerable<FunctionInfo> infoList);

         OperationResult Remove(IEnumerable<string> keyList);

         PageResult<FunctionInfo>  ListByCondition(NameValueCollection searchCondtionCollection, NameValueCollection sortCollection, int pageNumber, int pageSize);

         List<FunctionInfo> ListAllByCondition(NameValueCollection searchCondtionCollection, NameValueCollection sortCollection);


    }

}
