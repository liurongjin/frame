using sct.dto.mrp;
using sct.cm.data;
using System.Collections.Specialized;
using System.Collections.Generic;



namespace sct.svc.mrp
{

    public interface IGatherBillService
    { 

         OperationResult Create(GatherBillInfo info);

         OperationResult Modify(GatherBillInfo info);

         OperationResult Remove(string key);

         GatherBillInfo Load(string key);

         OperationResult Create(IEnumerable<GatherBillInfo> infoList);

         OperationResult Modify(IEnumerable<GatherBillInfo> infoList);

         OperationResult Remove(IEnumerable<string> keyList);

         PageResult<GatherBillInfo>  ListByCondition(NameValueCollection searchCondtionCollection, NameValueCollection sortCollection, int pageNumber, int pageSize);

         List<GatherBillInfo> ListAllByCondition(NameValueCollection searchCondtionCollection, NameValueCollection sortCollection);


    }

}
