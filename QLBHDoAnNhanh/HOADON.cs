//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace QLQCAFE
{
    using System;
    using System.Collections.Generic;
    
    public partial class HOADON
    {
        public string IDHOADON { get; set; }
        public string IDBAN { get; set; }
        public Nullable<System.DateTime> THOIGIANTOI { get; set; }
        public Nullable<System.DateTime> THOIGIANDI { get; set; }
    
        public virtual BAN BAN { get; set; }
    }
}