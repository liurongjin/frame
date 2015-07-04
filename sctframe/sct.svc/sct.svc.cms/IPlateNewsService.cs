using sct.dto.cms;
using sct.cm.data;
using System.Collections.Specialized;
using System.Collections.Generic;



namespace sct.svc.cms
{

    public interface IPlateNewsService
    { 

         OperationResult Create(PlateNewsInfo info);

         OperationResult Modify(PlateNewsInfo info);

         OperationResult Remove(string key);

         PlateNewsInfo Load(string key);

         OperationResult Create(IEnumerable<PlateNewsInfo> infoList);

         OperationResult Modify(IEnumerable<PlateNewsInfo> infoList);

         OperationResult Remove(IEnumerable<string> keyList);

         PageResult<PlateNewsInfo>  ListByCondition(NameValueCollection searchCondtionCollection, NameValueCollection sortCollection, int pageNumber, int pageSize);

         List<PlateNewsInfo> ListAllByCondition(NameValueCollection searchCondtionCollection, NameValueCollection sortCollection);


    }

}
