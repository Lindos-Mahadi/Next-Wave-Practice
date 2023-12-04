﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace NextWave.Models
{
    public partial class TblTrust
    {
        public long Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string TrustType { get; set; }
        public string TrustName { get; set; }
        public DateTime? TrustSetupDate { get; set; }
        public string TrustState { get; set; }
        public string OrdinaryPrice { get; set; }
        public string TotalUnitHolders { get; set; }
        public DateTime? AddedDate { get; set; }
        public long? AddedBy { get; set; }
        public long? UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public bool? QuoteForTax { get; set; }
        public bool? LegalAssessment { get; set; }
        public bool? BorrowingReview { get; set; }
        public bool? Agreement { get; set; }
        public string Smsf { get; set; }
        public string Abn { get; set; }
        public string PropertyTrusteeName { get; set; }
        public string PropertyTrusteeAcn { get; set; }
        public string PropertyAddress { get; set; }
        public string LenderName { get; set; }
        public string SmsfcompanyName { get; set; }
        public string Smsfacn { get; set; }
        public DateTime? PropertyTrusteeSetupDate { get; set; }
        public DateTime? SmsftrusteeSetupDate { get; set; }
        public DateTime? MeetingTime { get; set; }
        public string ExistingSetupDate { get; set; }
        public string ClauseNumber { get; set; }
    }
}