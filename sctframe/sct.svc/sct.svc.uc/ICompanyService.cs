using sct.dto.uc;
using sct.cm.data;
using System.Collections.Specialized;
using System.Collections.Generic;



namespace sct.svc.uc
{

    public interface ICompanyService
    { 

         OperationResult Create(CompanyInfo info);

         OperationResult Modify(CompanyInfo info);

         OperationResult Remove(string key);

         CompanyInfo Load(string key);

         OperationResult Create(IEnumerable<CompanyInfo> infoList);

         OperationResult Modify(IEnumerable<CompanyInfo> infoList);

         OperationResult Remove(IEnumerable<string> keyList);

         PageResult<CompanyInfo>  ListByCondition(NameValueCollection searchCondtionCollection, NameValueCollection sortCollection, int pageNumber, int pageSize);

         List<CompanyInfo> ListAllByCondition(NameValueCollection searchCondtionCollection, NameValueCollection sortCollection);


    }

}
