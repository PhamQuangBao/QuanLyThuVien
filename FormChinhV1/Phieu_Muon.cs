//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace FormChinhV1
{
    using System;
    using System.Collections.Generic;
    
    public partial class Phieu_Muon
    {
        public int ID { get; set; }
        public string ID_TaiLieu { get; set; }
        public string ID_PhieuMuon { get; set; }
        public int Count_ { get; set; }
        public int ID_NguoiDung { get; set; }
        public System.DateTime NgayMuon { get; set; }
        public System.DateTime NgayPhaiTra { get; set; }
        public string Trang_Thai_Muon { get; set; }
    
        public virtual Phieu_Muon_Tra Phieu_Muon_Tra { get; set; }
        public virtual Tài_Liệu Tài_Liệu { get; set; }
    }
}
