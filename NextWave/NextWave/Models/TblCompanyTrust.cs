﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace NextWave.Models
{
    public partial class TblCompanyTrust
    {
        public long Id { get; set; }
        public long? CompanyId { get; set; }
        public string TrustName { get; set; }
        public string TrustAbn { get; set; }
        public string TrustTfn { get; set; }
        public string Country { get; set; }
        public DateTime? AddedDate { get; set; }
        public long? AddedBy { get; set; }
        public long? UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string TrustAddress { get; set; }

        public virtual TblCompany Company { get; set; }
    }
}