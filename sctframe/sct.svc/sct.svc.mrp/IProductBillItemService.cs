using sct.dto.mrp;
using sct.cm.data;
using System.Collections.Specialized;
using System.Collections.Generic;



namespace sct.svc.mrp
{

    public interface IProductBillItemService
    { 

         OperationResult Create(ProductBillItemInfo info);

         OperationResult Modify(ProductBillItemInfo info);

         OperationResult Remove(string key);

         ProductBillItemInfo Load(string key);

         OperationResult Create(IEnumerable<ProductBillItemInfo> infoList);

         OperationResult Modify(IEnumerable<ProductBillItemInfo> infoList);

         OperationResult Remove(IEnumerable<string> keyList);

         PageResult<ProductBillItemInfo>  ListByCondition(NameValueCollection searchCondtionCollection, NameValueCollection sortCollection, int pageNumber, int pageSize);

         List<ProductBillItemInfo> ListAllByCondition(NameValueCollection searchCondtionCollection, NameValueCollection sortCollection);


    }

}
