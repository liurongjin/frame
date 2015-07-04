using sct.dto.cms;
using sct.cm.data;
using System.Collections.Specialized;
using System.Collections.Generic;



namespace sct.svc.cms
{

    public interface IArticleCatalogService
    { 

         OperationResult Create(ArticleCatalogInfo info);

         OperationResult Modify(ArticleCatalogInfo info);

         OperationResult Remove(string key);

         ArticleCatalogInfo Load(string key);

         OperationResult Create(IEnumerable<ArticleCatalogInfo> infoList);

         OperationResult Modify(IEnumerable<ArticleCatalogInfo> infoList);

         OperationResult Remove(IEnumerable<string> keyList);

         PageResult<ArticleCatalogInfo>  ListByCondition(NameValueCollection searchCondtionCollection, NameValueCollection sortCollection, int pageNumber, int pageSize);

         List<ArticleCatalogInfo> ListAllByCondition(NameValueCollection searchCondtionCollection, NameValueCollection sortCollection);


    }

}
