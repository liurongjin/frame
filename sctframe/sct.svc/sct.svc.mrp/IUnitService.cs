using sct.dto.mrp;
using sct.cm.data;
using System.Collections.Specialized;
using System.Collections.Generic;



namespace sct.svc.mrp
{

    public interface IUnitService
    { 

         OperationResult Create(UnitInfo info);

         OperationResult Modify(UnitInfo info);

         OperationResult Remove(string key);

         UnitInfo Load(string key);

         OperationResult Create(IEnumerable<UnitInfo> infoList);

         OperationResult Modify(IEnumerable<UnitInfo> infoList);

         OperationResult Remove(IEnumerable<string> keyList);

         PageResult<UnitInfo>  ListByCondition(NameValueCollection searchCondtionCollection, NameValueCollection sortCollection, int pageNumber, int pageSize);

         List<UnitInfo> ListAllByCondition(NameValueCollection searchCondtionCollection, NameValueCollection sortCollection);


    }

}
