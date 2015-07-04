using sct.dto.mrp;
using sct.cm.data;
using System.Collections.Specialized;
using System.Collections.Generic;



namespace sct.svc.mrp
{

    public interface IMaterialPurchaseItemService
    { 

         OperationResult Create(MaterialPurchaseItemInfo info);

         OperationResult Modify(MaterialPurchaseItemInfo info);

         OperationResult Remove(string key);

         MaterialPurchaseItemInfo Load(string key);

         OperationResult Create(IEnumerable<MaterialPurchaseItemInfo> infoList);

         OperationResult Modify(IEnumerable<MaterialPurchaseItemInfo> infoList);

         OperationResult Remove(IEnumerable<string> keyList);

         PageResult<MaterialPurchaseItemInfo>  ListByCondition(NameValueCollection searchCondtionCollection, NameValueCollection sortCollection, int pageNumber, int pageSize);

         List<MaterialPurchaseItemInfo> ListAllByCondition(NameValueCollection searchCondtionCollection, NameValueCollection sortCollection);


    }

}
