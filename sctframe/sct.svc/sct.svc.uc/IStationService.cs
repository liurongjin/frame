using sct.dto.uc;
using sct.cm.data;
using System.Collections.Specialized;
using System.Collections.Generic;



namespace sct.svc.uc
{

    public interface IStationService
    { 

         OperationResult Create(StationInfo info);

         OperationResult Modify(StationInfo info);

         OperationResult Remove(string key);

         StationInfo Load(string key);

         OperationResult Create(IEnumerable<StationInfo> infoList);

         OperationResult Modify(IEnumerable<StationInfo> infoList);

         OperationResult Remove(IEnumerable<string> keyList);

         PageResult<StationInfo>  ListByCondition(NameValueCollection searchCondtionCollection, NameValueCollection sortCollection, int pageNumber, int pageSize);

         List<StationInfo> ListAllByCondition(NameValueCollection searchCondtionCollection, NameValueCollection sortCollection);


    }

}
