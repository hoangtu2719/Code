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
    
    public partial class BLOG
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public BLOG()
        {
            this.BINHLUANBLOGs = new HashSet<BINHLUANBLOG>();
        }
    
        public int MABLOG { get; set; }
        public Nullable<int> MANGUOIDUNG { get; set; }
        public string NOIDUNG { get; set; }
        public Nullable<System.DateTime> NGAYDANG { get; set; }
        public Nullable<int> LUOTXEM { get; set; }
        public Nullable<int> MACHUDEBLOG { get; set; }
        public Nullable<int> MABINHLUANBLOG { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BINHLUANBLOG> BINHLUANBLOGs { get; set; }
        public virtual BINHLUANBLOG BINHLUANBLOG { get; set; }
        public virtual CHUDEBLOG CHUDEBLOG { get; set; }
        public virtual NGUOIDUNG NGUOIDUNG { get; set; }
        public virtual NGUOIDUNG NGUOIDUNG1 { get; set; }
    }
}
