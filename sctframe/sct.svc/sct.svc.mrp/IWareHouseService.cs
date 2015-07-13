using sct.dto.mrp;
using sct.cm.data;
using System.Collections.Specialized;
using System.Collections.Generic;



namespace sct.svc.mrp
{

    public interface IWareHouseService
    { 

         OperationResult Create(WareHouseInfo info);

         OperationResult Modify(WareHouseInfo info);

         OperationResult Remove(string key);

         WareHouseInfo Load(string key);

         OperationResult Create(IEnumerable<WareHouseInfo> infoList);

         OperationResult Modify(IEnumerable<WareHouseInfo> infoList);

         OperationResult Remove(IEnumerable<string> keyList);

         PageResult<WareHouseInfo>  ListByCondition(NameValueCollection searchCondtionCollection, NameValueCollection sortCollection, int pageNumber, int pageSize);

         List<WareHouseInfo> ListAllByCondition(NameValueCollection searchCondtionCollection, NameValueCollection sortCollection);


    }

}
