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
    
    public partial class Nguoi_Dung
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Nguoi_Dung()
        {
            this.Accounts = new HashSet<Account>();
        }
    
        public int ID_NguoiDung { get; set; }
        public string Name_NguoiDung { get; set; }
        public System.DateTime Birth { get; set; }
        public bool Gender { get; set; }
        public string DiaChi { get; set; }
        public string PhoneNumber { get; set; }
        public string Chuc_Vu { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Account> Accounts { get; set; }
    }
}
