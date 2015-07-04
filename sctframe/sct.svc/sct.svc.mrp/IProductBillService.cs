using sct.dto.mrp;
using sct.cm.data;
using System.Collections.Specialized;
using System.Collections.Generic;



namespace sct.svc.mrp
{

    public interface IProductBillService
    { 

         OperationResult Create(ProductBillInfo info);

         OperationResult Modify(ProductBillInfo info);

         OperationResult Remove(string key);

         ProductBillInfo Load(string key);

         OperationResult Create(IEnumerable<ProductBillInfo> infoList);

         OperationResult Modify(IEnumerable<ProductBillInfo> infoList);

         OperationResult Remove(IEnumerable<string> keyList);

         PageResult<ProductBillInfo>  ListByCondition(NameValueCollection searchCondtionCollection, NameValueCollection sortCollection, int pageNumber, int pageSize);

         List<ProductBillInfo> ListAllByCondition(NameValueCollection searchCondtionCollection, NameValueCollection sortCollection);


    }

}
