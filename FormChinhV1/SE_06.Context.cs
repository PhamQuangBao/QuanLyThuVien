﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class SE_06Entities : DbContext
    {
        public SE_06Entities()
            : base("name=SE_06Entities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Account> Accounts { get; set; }
        public virtual DbSet<Độc_giả> Độc_giả { get; set; }
        public virtual DbSet<Độc_Giả_Vi_Phạm> Độc_Giả_Vi_Phạm { get; set; }
        public virtual DbSet<Nguoi_Dung> Nguoi_Dung { get; set; }
        public virtual DbSet<Phan_Loai> Phan_Loai { get; set; }
        public virtual DbSet<Phieu_Muon> Phieu_Muon { get; set; }
        public virtual DbSet<Phieu_Muon_Tra> Phieu_Muon_Tra { get; set; }
        public virtual DbSet<Phieu_Tra> Phieu_Tra { get; set; }
        public virtual DbSet<Tài_Liệu> Tài_Liệu { get; set; }
        public virtual DbSet<ViTri> ViTris { get; set; }
    }
}
