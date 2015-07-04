using sct.dto.mrp;
using sct.cm.data;
using System.Collections.Specialized;
using System.Collections.Generic;



namespace sct.svc.mrp
{

    public interface IMaterialPurchasePlanService
    { 

         OperationResult Create(MaterialPurchasePlanInfo info);

         OperationResult Modify(MaterialPurchasePlanInfo info);

         OperationResult Remove(string key);

         MaterialPurchasePlanInfo Load(string key);

         OperationResult Create(IEnumerable<MaterialPurchasePlanInfo> infoList);

         OperationResult Modify(IEnumerable<MaterialPurchasePlanInfo> infoList);

         OperationResult Remove(IEnumerable<string> keyList);

         PageResult<MaterialPurchasePlanInfo>  ListByCondition(NameValueCollection searchCondtionCollection, NameValueCollection sortCollection, int pageNumber, int pageSize);

         List<MaterialPurchasePlanInfo> ListAllByCondition(NameValueCollection searchCondtionCollection, NameValueCollection sortCollection);


    }

}
