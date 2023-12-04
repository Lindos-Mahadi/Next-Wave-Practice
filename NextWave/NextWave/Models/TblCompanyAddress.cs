﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace NextWave.Models
{
    public partial class TblCompanyAddress
    {
        public long Id { get; set; }
        public long? CompanyId { get; set; }
        public string UnitLevel { get; set; }
        public string Street { get; set; }
        public string State { get; set; }
        public string Suburb { get; set; }
        public string PostCode { get; set; }
        public bool? IsRegisteredAddress { get; set; }
        public bool? IsPrincipleAddress { get; set; }
        public DateTime? AddedDate { get; set; }
        public long? AddedBy { get; set; }
        public long? UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }

        public virtual TblCompany Company { get; set; }
    }
}