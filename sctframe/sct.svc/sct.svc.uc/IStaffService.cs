using sct.dto.uc;
using sct.cm.data;
using System.Collections.Specialized;
using System.Collections.Generic;



namespace sct.svc.uc
{

    public interface IStaffService
    { 

         OperationResult Create(StaffInfo info);

         OperationResult Modify(StaffInfo info);

         OperationResult Remove(string key);

         StaffInfo Load(string key);

         OperationResult Create(IEnumerable<StaffInfo> infoList);

         OperationResult Modify(IEnumerable<StaffInfo> infoList);

         OperationResult Remove(IEnumerable<string> keyList);

         PageResult<StaffInfo>  ListByCondition(NameValueCollection searchCondtionCollection, NameValueCollection sortCollection, int pageNumber, int pageSize);

         List<StaffInfo> ListAllByCondition(NameValueCollection searchCondtionCollection, NameValueCollection sortCollection);

         OperationResult Login(string usercode, string password);

    }

}
