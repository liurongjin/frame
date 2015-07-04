using sct.dto.cms;
using sct.cm.data;
using System.Collections.Specialized;
using System.Collections.Generic;



namespace sct.svc.cms
{

    public interface IArticleVideoService
    { 

         OperationResult Create(ArticleVideoInfo info);

         OperationResult Modify(ArticleVideoInfo info);

         OperationResult Remove(string key);

         ArticleVideoInfo Load(string key);

         OperationResult Create(IEnumerable<ArticleVideoInfo> infoList);

         OperationResult Modify(IEnumerable<ArticleVideoInfo> infoList);

         OperationResult Remove(IEnumerable<string> keyList);

         PageResult<ArticleVideoInfo>  ListByCondition(NameValueCollection searchCondtionCollection, NameValueCollection sortCollection, int pageNumber, int pageSize);

         List<ArticleVideoInfo> ListAllByCondition(NameValueCollection searchCondtionCollection, NameValueCollection sortCollection);


    }

}
