﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Vinasa.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class TAIKHOANADMIN
    {
        public int ID { get; set; }
        public string Ten { get; set; }
        public string Email { get; set; }
        public int Quyen { get; set; }
        public int TrangThai { get; set; }
        public string Sdt { get; set; }
        public string PhongBan { get; set; }

        public string MatKhau { get; set; }
    
        public virtual QUYEN QUYEN1 { get; set; }
        public virtual TRANGTHAI TRANGTHAI1 { get; set; }
    }
}
