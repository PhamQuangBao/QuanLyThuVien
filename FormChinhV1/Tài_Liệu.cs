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
    
    public partial class Tài_Liệu
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Tài_Liệu()
        {
            this.Phieu_Muon = new HashSet<Phieu_Muon>();
        }
    
        public string ID_TaiLieu { get; set; }
        public string Name_TaiLieu { get; set; }
        public string TacGia { get; set; }
        public string NXB { get; set; }
        public string ID_TheLoai { get; set; }
        public int SoLuong { get; set; }
        public string TinhTrang { get; set; }
        public string NamXB { get; set; }
        public int GiaThanh { get; set; }
        public int ID_ViTri { get; set; }
    
        public virtual Phan_Loai Phan_Loai { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Phieu_Muon> Phieu_Muon { get; set; }
        public virtual ViTri ViTri { get; set; }
    }
}
