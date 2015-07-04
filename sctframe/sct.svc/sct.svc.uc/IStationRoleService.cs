using sct.dto.uc;
using sct.cm.data;
using System.Collections.Specialized;
using System.Collections.Generic;



namespace sct.svc.uc
{

    public interface IStationRoleService
    { 

         OperationResult Create(StationRoleInfo info);

         OperationResult Modify(StationRoleInfo info);

         OperationResult Remove(string key);

         StationRoleInfo Load(string key);

         OperationResult Create(IEnumerable<StationRoleInfo> infoList);

         OperationResult Modify(IEnumerable<StationRoleInfo> infoList);

         OperationResult Remove(IEnumerable<string> keyList);

         PageResult<StationRoleInfo>  ListByCondition(NameValueCollection searchCondtionCollection, NameValueCollection sortCollection, int pageNumber, int pageSize);

         List<StationRoleInfo> ListAllByCondition(NameValueCollection searchCondtionCollection, NameValueCollection sortCollection);


    }

}
