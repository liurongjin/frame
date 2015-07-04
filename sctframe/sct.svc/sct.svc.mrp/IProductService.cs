using sct.dto.mrp;
using sct.cm.data;
using System.Collections.Specialized;
using System.Collections.Generic;



namespace sct.svc.mrp
{

    public interface IProductService
    { 

         OperationResult Create(ProductInfo info);

         OperationResult Modify(ProductInfo info);

         OperationResult Remove(string key);

         ProductInfo Load(string key);

         OperationResult Create(IEnumerable<ProductInfo> infoList);

         OperationResult Modify(IEnumerable<ProductInfo> infoList);

         OperationResult Remove(IEnumerable<string> keyList);

         PageResult<ProductInfo>  ListByCondition(NameValueCollection searchCondtionCollection, NameValueCollection sortCollection, int pageNumber, int pageSize);

         List<ProductInfo> ListAllByCondition(NameValueCollection searchCondtionCollection, NameValueCollection sortCollection);


    }

}
