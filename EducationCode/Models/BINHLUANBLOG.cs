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
    
    public partial class BINHLUANBLOG
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public BINHLUANBLOG()
        {
            this.BLOGs = new HashSet<BLOG>();
        }
    
        public int MABINHLUANBLOG { get; set; }
        public Nullable<int> MACHUDEBLOG { get; set; }
        public Nullable<int> MANGUOIDUNG { get; set; }
        public string NOIDUNG { get; set; }
        public Nullable<System.DateTime> NGAYDANG { get; set; }
        public Nullable<int> MABLOG { get; set; }
    
        public virtual BLOG BLOG { get; set; }
        public virtual NGUOIDUNG NGUOIDUNG { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BLOG> BLOGs { get; set; }
    }
}