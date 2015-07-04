using sct.dto.cms;
using sct.cm.data;
using System.Collections.Specialized;
using System.Collections.Generic;



namespace sct.svc.cms
{

    public interface IArticleAnnexService
    { 

         OperationResult Create(ArticleAnnexInfo info);

         OperationResult Modify(ArticleAnnexInfo info);

         OperationResult Remove(string key);

         ArticleAnnexInfo Load(string key);

         OperationResult Create(IEnumerable<ArticleAnnexInfo> infoList);

         OperationResult Modify(IEnumerable<ArticleAnnexInfo> infoList);

         OperationResult Remove(IEnumerable<string> keyList);

         PageResult<ArticleAnnexInfo>  ListByCondition(NameValueCollection searchCondtionCollection, NameValueCollection sortCollection, int pageNumber, int pageSize);

         List<ArticleAnnexInfo> ListAllByCondition(NameValueCollection searchCondtionCollection, NameValueCollection sortCollection);


    }

}
