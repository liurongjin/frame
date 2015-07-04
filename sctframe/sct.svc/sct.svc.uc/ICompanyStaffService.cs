using sct.dto.uc;
using sct.cm.data;
using System.Collections.Specialized;
using System.Collections.Generic;



namespace sct.svc.uc
{

    public interface ICompanyStaffService
    { 

         OperationResult Create(CompanyStaffInfo info);

         OperationResult Modify(CompanyStaffInfo info);

         OperationResult Remove(string key);

         CompanyStaffInfo Load(string key);

         OperationResult Create(IEnumerable<CompanyStaffInfo> infoList);

         OperationResult Modify(IEnumerable<CompanyStaffInfo> infoList);

         OperationResult Remove(IEnumerable<string> keyList);

         PageResult<CompanyStaffInfo>  ListByCondition(NameValueCollection searchCondtionCollection, NameValueCollection sortCollection, int pageNumber, int pageSize);

         List<CompanyStaffInfo> ListAllByCondition(NameValueCollection searchCondtionCollection, NameValueCollection sortCollection);


    }

}
