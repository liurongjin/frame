using sct.dto.uc;
using sct.cm.data;
using System.Collections.Specialized;
using System.Collections.Generic;



namespace sct.svc.uc
{

    public interface IRoleFacilityService
    { 

         OperationResult Create(RoleFacilityInfo info);

         OperationResult Modify(RoleFacilityInfo info);

         OperationResult Remove(string key);

         RoleFacilityInfo Load(string key);

         OperationResult Create(IEnumerable<RoleFacilityInfo> infoList);

         OperationResult Modify(IEnumerable<RoleFacilityInfo> infoList);

         OperationResult Remove(IEnumerable<string> keyList);

         PageResult<RoleFacilityInfo>  ListByCondition(NameValueCollection searchCondtionCollection, NameValueCollection sortCollection, int pageNumber, int pageSize);

         List<RoleFacilityInfo> ListAllByCondition(NameValueCollection searchCondtionCollection, NameValueCollection sortCollection);


    }

}
