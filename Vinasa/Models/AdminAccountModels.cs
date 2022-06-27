﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Vinasa.Models
{
    public class AdminAccountModels
    {
        public int ID { get; set; }
        public string Ten { get; set; }
        public string Email { get; set; }
        public int Quyen { get; set; }
        public int TrangThai { get; set; }
        public int Sdt { get; set; }
        public string PhongBan { get; set; }
        public string MatKhau { get; set; }

        public virtual QUYEN QUYEN1 { get; set; }
        public virtual TRANGTHAI TRANGTHAI1 { get; set; }
    }
}