using sct.dto.mrp;
using sct.cm.data;
using System.Collections.Specialized;
using System.Collections.Generic;



namespace sct.svc.mrp
{

    public interface IManufacturePlanService
    { 

         OperationResult Create(ManufacturePlanInfo info);

         OperationResult Modify(ManufacturePlanInfo info);

         OperationResult Remove(string key);

         ManufacturePlanInfo Load(string key);

         OperationResult Create(IEnumerable<ManufacturePlanInfo> infoList);

         OperationResult Modify(IEnumerable<ManufacturePlanInfo> infoList);

         OperationResult Remove(IEnumerable<string> keyList);

         PageResult<ManufacturePlanInfo>  ListByCondition(NameValueCollection searchCondtionCollection, NameValueCollection sortCollection, int pageNumber, int pageSize);

         List<ManufacturePlanInfo> ListAllByCondition(NameValueCollection searchCondtionCollection, NameValueCollection sortCollection);


    }

}
