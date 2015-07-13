using sct.dto.mrp;
using sct.cm.data;
using System.Collections.Specialized;
using System.Collections.Generic;



namespace sct.svc.mrp
{

    public interface IProductWareStockService
    { 

         OperationResult Create(ProductWareStockInfo info);

         OperationResult Modify(ProductWareStockInfo info);

         OperationResult Remove(string key);

         ProductWareStockInfo Load(string key);

         OperationResult Create(IEnumerable<ProductWareStockInfo> infoList);

         OperationResult Modify(IEnumerable<ProductWareStockInfo> infoList);

         OperationResult Remove(IEnumerable<string> keyList);

         PageResult<ProductWareStockInfo>  ListByCondition(NameValueCollection searchCondtionCollection, NameValueCollection sortCollection, int pageNumber, int pageSize);

         List<ProductWareStockInfo> ListAllByCondition(NameValueCollection searchCondtionCollection, NameValueCollection sortCollection);


    }

}
