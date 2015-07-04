using sct.dto.mrp;
using sct.cm.data;
using System.Collections.Specialized;
using System.Collections.Generic;



namespace sct.svc.mrp
{

    public interface IMaterialBillService
    { 

         OperationResult Create(MaterialBillInfo info);

         OperationResult Modify(MaterialBillInfo info);

         OperationResult Remove(string key);

         MaterialBillInfo Load(string key);

         OperationResult Create(IEnumerable<MaterialBillInfo> infoList);

         OperationResult Modify(IEnumerable<MaterialBillInfo> infoList);

         OperationResult Remove(IEnumerable<string> keyList);

         PageResult<MaterialBillInfo>  ListByCondition(NameValueCollection searchCondtionCollection, NameValueCollection sortCollection, int pageNumber, int pageSize);

         List<MaterialBillInfo> ListAllByCondition(NameValueCollection searchCondtionCollection, NameValueCollection sortCollection);


    }

}
