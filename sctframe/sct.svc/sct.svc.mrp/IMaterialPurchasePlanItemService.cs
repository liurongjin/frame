using sct.dto.mrp;
using sct.cm.data;
using System.Collections.Specialized;
using System.Collections.Generic;



namespace sct.svc.mrp
{

    public interface IMaterialPurchasePlanItemService
    { 

         OperationResult Create(MaterialPurchasePlanItemInfo info);

         OperationResult Modify(MaterialPurchasePlanItemInfo info);

         OperationResult Remove(string key);

         MaterialPurchasePlanItemInfo Load(string key);

         OperationResult Create(IEnumerable<MaterialPurchasePlanItemInfo> infoList);

         OperationResult Modify(IEnumerable<MaterialPurchasePlanItemInfo> infoList);

         OperationResult Remove(IEnumerable<string> keyList);

         PageResult<MaterialPurchasePlanItemInfo>  ListByCondition(NameValueCollection searchCondtionCollection, NameValueCollection sortCollection, int pageNumber, int pageSize);

         List<MaterialPurchasePlanItemInfo> ListAllByCondition(NameValueCollection searchCondtionCollection, NameValueCollection sortCollection);


    }

}
