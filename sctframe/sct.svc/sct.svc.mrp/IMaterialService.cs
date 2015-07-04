using sct.dto.mrp;
using sct.cm.data;
using System.Collections.Specialized;
using System.Collections.Generic;



namespace sct.svc.mrp
{

    public interface IMaterialService
    { 

         OperationResult Create(MaterialInfo info);

         OperationResult Modify(MaterialInfo info);

         OperationResult Remove(string key);

         MaterialInfo Load(string key);

         OperationResult Create(IEnumerable<MaterialInfo> infoList);

         OperationResult Modify(IEnumerable<MaterialInfo> infoList);

         OperationResult Remove(IEnumerable<string> keyList);

         PageResult<MaterialInfo>  ListByCondition(NameValueCollection searchCondtionCollection, NameValueCollection sortCollection, int pageNumber, int pageSize);

         List<MaterialInfo> ListAllByCondition(NameValueCollection searchCondtionCollection, NameValueCollection sortCollection);


    }

}
