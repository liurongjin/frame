using sct.dto.uc;
using sct.cm.data;
using System.Collections.Specialized;
using System.Collections.Generic;



namespace sct.svc.uc
{

    public interface ICompanyClientTypeService
    { 

         OperationResult Create(CompanyClientTypeInfo info);

         OperationResult Modify(CompanyClientTypeInfo info);

         OperationResult Remove(string key);

         CompanyClientTypeInfo Load(string key);

         OperationResult Create(IEnumerable<CompanyClientTypeInfo> infoList);

         OperationResult Modify(IEnumerable<CompanyClientTypeInfo> infoList);

         OperationResult Remove(IEnumerable<string> keyList);

         PageResult<CompanyClientTypeInfo>  ListByCondition(NameValueCollection searchCondtionCollection, NameValueCollection sortCollection, int pageNumber, int pageSize);

         List<CompanyClientTypeInfo> ListAllByCondition(NameValueCollection searchCondtionCollection, NameValueCollection sortCollection);


    }

}
