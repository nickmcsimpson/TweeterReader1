﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TweeterReader.Data
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class TweeterTyper : DbContext
    {
        public TweeterTyper()
            : base("name=TweeterTyper")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<C__MigrationHistory> C__MigrationHistory { get; set; }
        public virtual DbSet<AspNetRole> AspNetRoles { get; set; }
        public virtual DbSet<AspNetUserClaim> AspNetUserClaims { get; set; }
        public virtual DbSet<AspNetUserLogin> AspNetUserLogins { get; set; }
        public virtual DbSet<AspNetUser> AspNetUsers { get; set; }
        public virtual DbSet<GCAffiliation> GCAffiliations { get; set; }
        public virtual DbSet<GCCrimeReportNote> GCCrimeReportNotes { get; set; }
        public virtual DbSet<GCCrimeReport> GCCrimeReports { get; set; }
        public virtual DbSet<GCCrimeReportStatu> GCCrimeReportStatus { get; set; }
        public virtual DbSet<GCLocation> GCLocations { get; set; }
        public virtual DbSet<GCPerson> GCPersons { get; set; }
        public virtual DbSet<GCPersonStatu> GCPersonStatus { get; set; }
    }
}
