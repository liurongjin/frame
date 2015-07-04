using sct.dto.mrp;
using sct.cm.data;
using System.Collections.Specialized;
using System.Collections.Generic;



namespace sct.svc.mrp
{

    public interface IMaterialPurchaseService
    { 

         OperationResult Create(MaterialPurchaseInfo info);

         OperationResult Modify(MaterialPurchaseInfo info);

         OperationResult Remove(string key);

         MaterialPurchaseInfo Load(string key);

         OperationResult Create(IEnumerable<MaterialPurchaseInfo> infoList);

         OperationResult Modify(IEnumerable<MaterialPurchaseInfo> infoList);

         OperationResult Remove(IEnumerable<string> keyList);

         PageResult<MaterialPurchaseInfo>  ListByCondition(NameValueCollection searchCondtionCollection, NameValueCollection sortCollection, int pageNumber, int pageSize);

         List<MaterialPurchaseInfo> ListAllByCondition(NameValueCollection searchCondtionCollection, NameValueCollection sortCollection);


    }

}
