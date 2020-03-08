//------------------------------------------------------------------------------
// <auto-generated>
//    此代码是根据模板生成的。
//
//    手动更改此文件可能会导致应用程序中发生异常行为。
//    如果重新生成代码，则将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace LG.OA.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Web.DynamicData;

    public partial class ActionInfo
    {
        public ActionInfo()
        {
            this.R_UserInfo_ActionInfo = new HashSet<R_UserInfo_ActionInfo>();
            this.RoleInfo = new HashSet<RoleInfo>();
        }

        [DisplayName("编号")]
        public int ID { get; set; }
        [DisplayName("注册时间")]
        public System.DateTime SubTime { get; set; }
        [DisplayName("修改时间")]
        public System.DateTime ModfiedOn { get; set; }
        [DisplayName("备注")]
        public string Remark { get; set; }
        public short DelFlag { get; set; }
        [DisplayName("Url")]
        public string Url { get; set; }
        [DisplayName("Http请求")]
        public string HttpMethd { get; set; }
        [DisplayName("名称")]
        public string ActionName { get; set; }
        [DisplayName("菜单")]
        public bool IsMenu { get; set; }
        [DisplayName("菜单图标")]
        public string MenuIcon { get; set; }
        [DisplayName("排序")]
        public int Sort { get; set; }

        public virtual ICollection<R_UserInfo_ActionInfo> R_UserInfo_ActionInfo { get; set; }
        public virtual ICollection<RoleInfo> RoleInfo { get; set; }
    }
}
