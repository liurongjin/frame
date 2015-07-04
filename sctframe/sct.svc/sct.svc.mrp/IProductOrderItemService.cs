using sct.dto.mrp;
using sct.cm.data;
using System.Collections.Specialized;
using System.Collections.Generic;



namespace sct.svc.mrp
{

    public interface IProductOrderItemService
    { 

         OperationResult Create(ProductOrderItemInfo info);

         OperationResult Modify(ProductOrderItemInfo info);

         OperationResult Remove(string key);

         ProductOrderItemInfo Load(string key);

         OperationResult Create(IEnumerable<ProductOrderItemInfo> infoList);

         OperationResult Modify(IEnumerable<ProductOrderItemInfo> infoList);

         OperationResult Remove(IEnumerable<string> keyList);

         PageResult<ProductOrderItemInfo>  ListByCondition(NameValueCollection searchCondtionCollection, NameValueCollection sortCollection, int pageNumber, int pageSize);

         List<ProductOrderItemInfo> ListAllByCondition(NameValueCollection searchCondtionCollection, NameValueCollection sortCollection);


    }

}
