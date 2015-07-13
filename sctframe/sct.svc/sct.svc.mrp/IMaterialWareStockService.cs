using sct.dto.mrp;
using sct.cm.data;
using System.Collections.Specialized;
using System.Collections.Generic;



namespace sct.svc.mrp
{

    public interface IMaterialWareStockService
    { 

         OperationResult Create(MaterialWareStockInfo info);

         OperationResult Modify(MaterialWareStockInfo info);

         OperationResult Remove(string key);

         MaterialWareStockInfo Load(string key);

         OperationResult Create(IEnumerable<MaterialWareStockInfo> infoList);

         OperationResult Modify(IEnumerable<MaterialWareStockInfo> infoList);

         OperationResult Remove(IEnumerable<string> keyList);

         PageResult<MaterialWareStockInfo>  ListByCondition(NameValueCollection searchCondtionCollection, NameValueCollection sortCollection, int pageNumber, int pageSize);

         List<MaterialWareStockInfo> ListAllByCondition(NameValueCollection searchCondtionCollection, NameValueCollection sortCollection);


    }

}
