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
    
    public partial class TINCONGNGHE
    {
        public int MATCN { get; set; }
        public Nullable<int> MACHUDE { get; set; }
        public string TENTCN { get; set; }
        public string NOIDUNG { get; set; }
        public string ANH { get; set; }
        public Nullable<System.DateTime> NGAYDANG { get; set; }
        public Nullable<int> LUOTXEM { get; set; }
        public string TACGIA { get; set; }
    
        public virtual CHUDETCN CHUDETCN { get; set; }
    }
}
