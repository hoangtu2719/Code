//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EducationCode.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class KHOAHOC
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public KHOAHOC()
        {
            this.BAIHOCs = new HashSet<BAIHOC>();
        }
    
        public int MAKHOAHOC { get; set; }
        public string TENKHOAHOC { get; set; }
        public string NOIDUNG { get; set; }
        public string TACGIA { get; set; }
        public string ANHKHOAHOC { get; set; }
        public Nullable<int> MABAIHOC { get; set; }
        public Nullable<System.DateTime> NGAYDANG { get; set; }
        public Nullable<int> LUOTXEM { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BAIHOC> BAIHOCs { get; set; }
        public virtual BAIHOC BAIHOC { get; set; }
    }
}
