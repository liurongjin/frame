using sct.dto.cms;
using sct.cm.data;
using System.Collections.Specialized;
using System.Collections.Generic;



namespace sct.svc.cms
{

    public interface IFriendLinkService
    { 

         OperationResult Create(FriendLinkInfo info);

         OperationResult Modify(FriendLinkInfo info);

         OperationResult Remove(string key);

         FriendLinkInfo Load(string key);

         OperationResult Create(IEnumerable<FriendLinkInfo> infoList);

         OperationResult Modify(IEnumerable<FriendLinkInfo> infoList);

         OperationResult Remove(IEnumerable<string> keyList);

         PageResult<FriendLinkInfo>  ListByCondition(NameValueCollection searchCondtionCollection, NameValueCollection sortCollection, int pageNumber, int pageSize);

         List<FriendLinkInfo> ListAllByCondition(NameValueCollection searchCondtionCollection, NameValueCollection sortCollection);


    }

}
