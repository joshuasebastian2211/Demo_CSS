//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SampleBoilerTemp.Web.Models.DAO
{
    using System;
    using System.Collections.Generic;
    
    public partial class AbpPermission
    {
        public long Id { get; set; }
        public Nullable<int> TenantId { get; set; }
        public string Name { get; set; }
        public bool IsGranted { get; set; }
        public System.DateTime CreationTime { get; set; }
        public Nullable<long> CreatorUserId { get; set; }
        public Nullable<int> RoleId { get; set; }
        public Nullable<long> UserId { get; set; }
        public string Discriminator { get; set; }
    
        public virtual AbpRole AbpRole { get; set; }
        public virtual AbpUser AbpUser { get; set; }
    }
}
