using sct.dto.uc;
using sct.cm.data;
using System.Collections.Specialized;
using System.Collections.Generic;



namespace sct.svc.uc
{

    public interface IRegionService
    { 

         OperationResult Create(RegionInfo info);

         OperationResult Modify(RegionInfo info);

         OperationResult Remove(string key);

         RegionInfo Load(string key);

         OperationResult Create(IEnumerable<RegionInfo> infoList);

         OperationResult Modify(IEnumerable<RegionInfo> infoList);

         OperationResult Remove(IEnumerable<string> keyList);

         PageResult<RegionInfo>  ListByCondition(NameValueCollection searchCondtionCollection, NameValueCollection sortCollection, int pageNumber, int pageSize);

         List<RegionInfo> ListAllByCondition(NameValueCollection searchCondtionCollection, NameValueCollection sortCollection);


    }

}
