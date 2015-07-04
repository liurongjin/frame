using sct.dto.cms;
using sct.cm.data;
using System.Collections.Specialized;
using System.Collections.Generic;



namespace sct.svc.cms
{

    public interface IArticleDetailService
    { 

         OperationResult Create(ArticleDetailInfo info);

         OperationResult Modify(ArticleDetailInfo info);

         OperationResult Remove(string key);

         ArticleDetailInfo Load(string key);

         OperationResult Create(IEnumerable<ArticleDetailInfo> infoList);

         OperationResult Modify(IEnumerable<ArticleDetailInfo> infoList);

         OperationResult Remove(IEnumerable<string> keyList);

         PageResult<ArticleDetailInfo>  ListByCondition(NameValueCollection searchCondtionCollection, NameValueCollection sortCollection, int pageNumber, int pageSize);

         List<ArticleDetailInfo> ListAllByCondition(NameValueCollection searchCondtionCollection, NameValueCollection sortCollection);


    }

}
