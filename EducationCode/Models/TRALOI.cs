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
    
    public partial class TRALOI
    {
        public int MATRALOI { get; set; }
        public int MANGUOIDUNG { get; set; }
        public int MABINHLUAN { get; set; }
        public string NOIDUNG { get; set; }
        public Nullable<System.DateTime> NGAYDANG { get; set; }
    
        public virtual BINHLUAN BINHLUAN { get; set; }
        public virtual NGUOIDUNG NGUOIDUNG { get; set; }
    }
}
