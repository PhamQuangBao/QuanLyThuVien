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
    
    public partial class Account
    {
        public string UserName { get; set; }
        public string Pass_Word { get; set; }
        public int ID { get; set; }
        public int Type { get; set; }
    
        public virtual Nguoi_Dung Nguoi_Dung { get; set; }
    }
}
