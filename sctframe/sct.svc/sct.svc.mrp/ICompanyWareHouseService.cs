using sct.dto.mrp;
using sct.cm.data;
using System.Collections.Specialized;
using System.Collections.Generic;



namespace sct.svc.mrp
{

    public interface ICompanyWareHouseService
    { 

         OperationResult Create(CompanyWareHouseInfo info);

         OperationResult Modify(CompanyWareHouseInfo info);

         OperationResult Remove(string key);

         CompanyWareHouseInfo Load(string key);

         OperationResult Create(IEnumerable<CompanyWareHouseInfo> infoList);

         OperationResult Modify(IEnumerable<CompanyWareHouseInfo> infoList);

         OperationResult Remove(IEnumerable<string> keyList);

         PageResult<CompanyWareHouseInfo>  ListByCondition(NameValueCollection searchCondtionCollection, NameValueCollection sortCollection, int pageNumber, int pageSize);

         List<CompanyWareHouseInfo> ListAllByCondition(NameValueCollection searchCondtionCollection, NameValueCollection sortCollection);


    }

}
