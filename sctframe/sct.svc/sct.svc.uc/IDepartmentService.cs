using sct.dto.uc;
using sct.cm.data;
using System.Collections.Specialized;
using System.Collections.Generic;



namespace sct.svc.uc
{

    public interface IDepartmentService
    { 

         OperationResult Create(DepartmentInfo info);

         OperationResult Modify(DepartmentInfo info);

         OperationResult Remove(string key);

         DepartmentInfo Load(string key);

         OperationResult Create(IEnumerable<DepartmentInfo> infoList);

         OperationResult Modify(IEnumerable<DepartmentInfo> infoList);

         OperationResult Remove(IEnumerable<string> keyList);

         PageResult<DepartmentInfo>  ListByCondition(NameValueCollection searchCondtionCollection, NameValueCollection sortCollection, int pageNumber, int pageSize);

         List<DepartmentInfo> ListAllByCondition(NameValueCollection searchCondtionCollection, NameValueCollection sortCollection);


    }

}
