using sct.dto.mrp;
using sct.cm.data;
using System.Collections.Specialized;
using System.Collections.Generic;



namespace sct.svc.mrp
{

    public interface IManufacturePlanItemService
    { 

         OperationResult Create(ManufacturePlanItemInfo info);

         OperationResult Modify(ManufacturePlanItemInfo info);

         OperationResult Remove(string key);

         ManufacturePlanItemInfo Load(string key);

         OperationResult Create(IEnumerable<ManufacturePlanItemInfo> infoList);

         OperationResult Modify(IEnumerable<ManufacturePlanItemInfo> infoList);

         OperationResult Remove(IEnumerable<string> keyList);

         PageResult<ManufacturePlanItemInfo>  ListByCondition(NameValueCollection searchCondtionCollection, NameValueCollection sortCollection, int pageNumber, int pageSize);

         List<ManufacturePlanItemInfo> ListAllByCondition(NameValueCollection searchCondtionCollection, NameValueCollection sortCollection);


    }

}
