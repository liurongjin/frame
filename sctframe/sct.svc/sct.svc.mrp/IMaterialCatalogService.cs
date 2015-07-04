using sct.dto.mrp;
using sct.cm.data;
using System.Collections.Specialized;
using System.Collections.Generic;



namespace sct.svc.mrp
{

    public interface IMaterialCatalogService
    { 

         OperationResult Create(MaterialCatalogInfo info);

         OperationResult Modify(MaterialCatalogInfo info);

         OperationResult Remove(string key);

         MaterialCatalogInfo Load(string key);

         OperationResult Create(IEnumerable<MaterialCatalogInfo> infoList);

         OperationResult Modify(IEnumerable<MaterialCatalogInfo> infoList);

         OperationResult Remove(IEnumerable<string> keyList);

         PageResult<MaterialCatalogInfo>  ListByCondition(NameValueCollection searchCondtionCollection, NameValueCollection sortCollection, int pageNumber, int pageSize);

         List<MaterialCatalogInfo> ListAllByCondition(NameValueCollection searchCondtionCollection, NameValueCollection sortCollection);


    }

}
