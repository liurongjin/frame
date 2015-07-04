using sct.dto.mrp;
using sct.cm.data;
using System.Collections.Specialized;
using System.Collections.Generic;



namespace sct.svc.mrp
{

    public interface IProductCatalogService
    { 

         OperationResult Create(ProductCatalogInfo info);

         OperationResult Modify(ProductCatalogInfo info);

         OperationResult Remove(string key);

         ProductCatalogInfo Load(string key);

         OperationResult Create(IEnumerable<ProductCatalogInfo> infoList);

         OperationResult Modify(IEnumerable<ProductCatalogInfo> infoList);

         OperationResult Remove(IEnumerable<string> keyList);

         PageResult<ProductCatalogInfo>  ListByCondition(NameValueCollection searchCondtionCollection, NameValueCollection sortCollection, int pageNumber, int pageSize);

         List<ProductCatalogInfo> ListAllByCondition(NameValueCollection searchCondtionCollection, NameValueCollection sortCollection);


    }

}
