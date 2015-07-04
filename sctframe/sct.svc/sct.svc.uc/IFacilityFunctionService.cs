using sct.dto.uc;
using sct.cm.data;
using System.Collections.Specialized;
using System.Collections.Generic;



namespace sct.svc.uc
{

    public interface IFacilityFunctionService
    { 

         OperationResult Create(FacilityFunctionInfo info);

         OperationResult Modify(FacilityFunctionInfo info);

         OperationResult Remove(string key);

         FacilityFunctionInfo Load(string key);

         OperationResult Create(IEnumerable<FacilityFunctionInfo> infoList);

         OperationResult Modify(IEnumerable<FacilityFunctionInfo> infoList);

         OperationResult Remove(IEnumerable<string> keyList);

         PageResult<FacilityFunctionInfo>  ListByCondition(NameValueCollection searchCondtionCollection, NameValueCollection sortCollection, int pageNumber, int pageSize);

         List<FacilityFunctionInfo> ListAllByCondition(NameValueCollection searchCondtionCollection, NameValueCollection sortCollection);


    }

}
