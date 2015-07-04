using sct.dto.uc;
using sct.cm.data;
using System.Collections.Specialized;
using System.Collections.Generic;



namespace sct.svc.uc
{

    public interface IFacilityService
    { 

         OperationResult Create(FacilityInfo info);

         OperationResult Modify(FacilityInfo info);

         OperationResult Remove(string key);

         FacilityInfo Load(string key);

         OperationResult Create(IEnumerable<FacilityInfo> infoList);

         OperationResult Modify(IEnumerable<FacilityInfo> infoList);

         OperationResult Remove(IEnumerable<string> keyList);

         PageResult<FacilityInfo>  ListByCondition(NameValueCollection searchCondtionCollection, NameValueCollection sortCollection, int pageNumber, int pageSize);

         List<FacilityInfo> ListAllByCondition(NameValueCollection searchCondtionCollection, NameValueCollection sortCollection);


    }

}
