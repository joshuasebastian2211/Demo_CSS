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
    
    public partial class SMS_Units
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SMS_Units()
        {
            this.StationaryRequestDetails = new HashSet<StationaryRequestDetail>();
        }
    
        public short Unit_Id { get; set; }
        public string Unit_Description { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<StationaryRequestDetail> StationaryRequestDetails { get; set; }
    }
}