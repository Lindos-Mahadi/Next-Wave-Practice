﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace NextWave.Models
{
    public partial class TblTrustOption
    {
        public long Id { get; set; }
        public bool? QuoteForTax { get; set; }
        public bool? LegalAssessment { get; set; }
        public bool? BorrowingReview { get; set; }
        public bool? Agreement { get; set; }
        public long? TrustId { get; set; }
        public DateTime? AddedDate { get; set; }
        public long? AddedBy { get; set; }
    }
}