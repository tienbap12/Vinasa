﻿//------------------------------------------------------------------------------
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
    using System.ComponentModel.DataAnnotations;
    using System.Linq;
    using System.Web;
    using Vinasa.Validation;

    public partial class KyPhi
    {
        public int ID { get; set; }

        public string MaSoThue { get; set; }

        public string TenCongTy { get; set; }

        public int Nam { get; set; }
        public decimal SoTienDong { get; set; }
    }
}