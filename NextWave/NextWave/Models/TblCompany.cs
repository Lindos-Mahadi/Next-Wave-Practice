﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace NextWave.Models
{
    public partial class TblCompany
    {
        public TblCompany()
        {
            TblCompanyDirectors = new HashSet<TblCompanyDirector>();
        }

        public long Id { get; set; }
        public string CompanyName { get; set; }
        public bool? NameReserved { get; set; }
        public string Abn { get; set; }
        public string CompanyPurpose { get; set; }
        public string CompanyUseFor { get; set; }
        public string RegistrationState { get; set; }
        public DateTime? AddedDate { get; set; }
        public long? AddedBy { get; set; }
        public long? UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public bool Registered { get; set; }
        public string Status { get; set; }
        public bool? Smsfdeclaration { get; set; }
        public bool? QuoteForTax { get; set; }
        public bool? LegalAssessment { get; set; }
        public bool? BorrowingReview { get; set; }
        public bool? Agreement { get; set; }
        public string CompanySecretary { get; set; }
        public string PublicOfficerOfCompany { get; set; }
        public string HowfstmeetingOfDirheld { get; set; }
        public string DateOfIncorporation { get; set; }

        public virtual TblUser AddedByNavigation { get; set; }
        public virtual TblUser UpdatedByNavigation { get; set; }
        public virtual ICollection<TblCompanyDirector> TblCompanyDirectors { get; set; }
    }
}