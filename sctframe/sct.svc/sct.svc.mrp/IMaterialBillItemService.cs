using sct.dto.mrp;
using sct.cm.data;
using System.Collections.Specialized;
using System.Collections.Generic;



namespace sct.svc.mrp
{

    public interface IMaterialBillItemService
    { 

         OperationResult Create(MaterialBillItemInfo info);

         OperationResult Modify(MaterialBillItemInfo info);

         OperationResult Remove(string key);

         MaterialBillItemInfo Load(string key);

         OperationResult Create(IEnumerable<MaterialBillItemInfo> infoList);

         OperationResult Modify(IEnumerable<MaterialBillItemInfo> infoList);

         OperationResult Remove(IEnumerable<string> keyList);

         PageResult<MaterialBillItemInfo>  ListByCondition(NameValueCollection searchCondtionCollection, NameValueCollection sortCollection, int pageNumber, int pageSize);

         List<MaterialBillItemInfo> ListAllByCondition(NameValueCollection searchCondtionCollection, NameValueCollection sortCollection);


    }

}
