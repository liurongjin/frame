using sct.dto.uc;
using sct.cm.data;
using System.Collections.Specialized;
using System.Collections.Generic;



namespace sct.svc.uc
{

    public interface IStaffStationService
    { 

         OperationResult Create(StaffStationInfo info);

         OperationResult Modify(StaffStationInfo info);

         OperationResult Remove(string key);

         StaffStationInfo Load(string key);

         OperationResult Create(IEnumerable<StaffStationInfo> infoList);

         OperationResult Modify(IEnumerable<StaffStationInfo> infoList);

         OperationResult Remove(IEnumerable<string> keyList);

         PageResult<StaffStationInfo>  ListByCondition(NameValueCollection searchCondtionCollection, NameValueCollection sortCollection, int pageNumber, int pageSize);

         List<StaffStationInfo> ListAllByCondition(NameValueCollection searchCondtionCollection, NameValueCollection sortCollection);


    }

}
