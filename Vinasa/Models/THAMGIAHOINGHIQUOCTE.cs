//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Vinasa.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class THAMGIAHOINGHIQUOCTE
    {
        public int ID { get; set; }
        public string TenDonVi { get; set; }
        public string DonViChungToiLa { get; set; }
        public string DiaChi { get; set; }
        public string DienThoai { get; set; }
        public string DaiDienLienHe { get; set; }
        public string ChucVu { get; set; }
        public string DiDong { get; set; }
        public string Email { get; set; }
        public bool DangKyThamDu { get; set; }
        public bool DangKyPhatBieu { get; set; }
        public bool DangKyGianHangTrienLam { get; set; }
        public bool DangKyBusinessMatchingOnline { get; set; }
        public bool DangKyBusinessMatchingOffline { get; set; }
        public bool DangKyTaiTro { get; set; }
        public bool DangKyQuangCao { get; set; }
        public Nullable<int> HoiNghiQT_ID { get; set; }
    
        public virtual HOINGHIQUOCTE HOINGHIQUOCTE { get; set; }
    }
}
