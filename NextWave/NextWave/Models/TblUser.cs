﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace NextWave.Models
{
    public partial class TblUser
    {
        public TblUser()
        {
            TblCompanyAddedByNavigations = new HashSet<TblCompany>();
            TblCompanyUpdatedByNavigations = new HashSet<TblCompany>();
        }

        public long Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string ProfilePic { get; set; }
        public bool? EmailVerified { get; set; }
        public string Role { get; set; }
        public DateTime? LastLogIn { get; set; }
        public DateTime? AddedDate { get; set; }
        public int? AddedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public int? UpdatedBy { get; set; }
        public DateTime? DeletedDate { get; set; }
        public int? DeletedBy { get; set; }
        public bool? Del { get; set; }
        public string Phone { get; set; }
        public long? Regid { get; set; }
        public string Tuser { get; set; }

        public virtual ICollection<TblCompany> TblCompanyAddedByNavigations { get; set; }
        public virtual ICollection<TblCompany> TblCompanyUpdatedByNavigations { get; set; }
    }
}