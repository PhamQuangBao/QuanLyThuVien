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
    
    public partial class Phieu_Muon_Tra
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Phieu_Muon_Tra()
        {
            this.Phieu_Muon = new HashSet<Phieu_Muon>();
        }
    
        public string ID_MuonTra { get; set; }
        public string ID_ĐG { get; set; }
        public int ID_NguoiLapPhieu { get; set; }
        public System.DateTime NgayTao { get; set; }
        public System.DateTime NgayHetHan { get; set; }
    
        public virtual Độc_giả Độc_giả { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Phieu_Muon> Phieu_Muon { get; set; }
    }
}
