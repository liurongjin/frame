using System;
using System.Runtime.Serialization;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;


namespace sct.dto.uc
{
    public partial class StaffInfo
    {

        [DataMember]
        [StringLength(36)]
        public string CompanyId { get; set; }

        [DataMember]
        [StringLength(200)]
        public string CompanyName { get; set; }

        [DataMember]
        [StringLength(200)]
        public string DepartmentName { get; set; }

        ///*�û��༭ʱ�õ�*/
        //[DataMember]
        //public List<MenuInfo> MenuInfoList { get; set; }

        ///*�û��༭ʱ�õ�*/
        //[DataMember]
        //public List<FacilityFunctionInfo> FacilityFunctionInfoList { get; set; }

        /*�û��༭ʱ�õ�*/
        [DataMember]
        public List<StaffStationInfo> StaffStationInfoList { get; set; }

        /*��¼�ж�ʱ�õ�*/
        [DataMember]
        public List<FacilityInfo> FacilityInfoList { get; set; }

    }

}
