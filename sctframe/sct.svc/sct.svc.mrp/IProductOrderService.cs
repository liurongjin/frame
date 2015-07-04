using sct.dto.mrp;
using sct.cm.data;
using System.Collections.Specialized;
using System.Collections.Generic;



namespace sct.svc.mrp
{

    public interface IProductOrderService
    { 

         OperationResult Create(ProductOrderInfo info);

         OperationResult Modify(ProductOrderInfo info);

         OperationResult Remove(string key);

         ProductOrderInfo Load(string key);

         OperationResult Create(IEnumerable<ProductOrderInfo> infoList);

         OperationResult Modify(IEnumerable<ProductOrderInfo> infoList);

         OperationResult Remove(IEnumerable<string> keyList);

         PageResult<ProductOrderInfo>  ListByCondition(NameValueCollection searchCondtionCollection, NameValueCollection sortCollection, int pageNumber, int pageSize);

         List<ProductOrderInfo> ListAllByCondition(NameValueCollection searchCondtionCollection, NameValueCollection sortCollection);


    }

}
