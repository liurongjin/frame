using sct.dto.cms;
using sct.cm.data;
using System.Collections.Specialized;
using System.Collections.Generic;



namespace sct.svc.cms
{

    public interface IArticleImageService
    { 

         OperationResult Create(ArticleImageInfo info);

         OperationResult Modify(ArticleImageInfo info);

         OperationResult Remove(string key);

         ArticleImageInfo Load(string key);

         OperationResult Create(IEnumerable<ArticleImageInfo> infoList);

         OperationResult Modify(IEnumerable<ArticleImageInfo> infoList);

         OperationResult Remove(IEnumerable<string> keyList);

         PageResult<ArticleImageInfo>  ListByCondition(NameValueCollection searchCondtionCollection, NameValueCollection sortCollection, int pageNumber, int pageSize);

         List<ArticleImageInfo> ListAllByCondition(NameValueCollection searchCondtionCollection, NameValueCollection sortCollection);


    }

}
