using sct.dto.cms;
using sct.cm.data;
using System.Collections.Specialized;
using System.Collections.Generic;



namespace sct.svc.cms
{

    public interface IArticleService
    { 

         OperationResult Create(ArticleInfo info);

         OperationResult Modify(ArticleInfo info);

         OperationResult Remove(string key);

         ArticleInfo Load(string key);

         OperationResult Create(IEnumerable<ArticleInfo> infoList);

         OperationResult Modify(IEnumerable<ArticleInfo> infoList);

         OperationResult Remove(IEnumerable<string> keyList);

         PageResult<ArticleInfo>  ListByCondition(NameValueCollection searchCondtionCollection, NameValueCollection sortCollection, int pageNumber, int pageSize);

         List<ArticleInfo> ListAllByCondition(NameValueCollection searchCondtionCollection, NameValueCollection sortCollection);


    }

}
