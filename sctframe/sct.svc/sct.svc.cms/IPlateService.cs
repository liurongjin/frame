using sct.dto.cms;
using sct.cm.data;
using System.Collections.Specialized;
using System.Collections.Generic;



namespace sct.svc.cms
{

    public interface IPlateService
    { 

         OperationResult Create(PlateInfo info);

         OperationResult Modify(PlateInfo info);

         OperationResult Remove(string key);

         PlateInfo Load(string key);

         OperationResult Create(IEnumerable<PlateInfo> infoList);

         OperationResult Modify(IEnumerable<PlateInfo> infoList);

         OperationResult Remove(IEnumerable<string> keyList);

         PageResult<PlateInfo>  ListByCondition(NameValueCollection searchCondtionCollection, NameValueCollection sortCollection, int pageNumber, int pageSize);

         List<PlateInfo> ListAllByCondition(NameValueCollection searchCondtionCollection, NameValueCollection sortCollection);


    }

}
