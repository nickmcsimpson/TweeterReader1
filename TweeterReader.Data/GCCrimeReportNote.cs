//------------------------------------------------------------------------------
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
    using System.Collections.Generic;
    
    public partial class GCCrimeReportNote
    {
        public int CrimeReportNoteID { get; set; }
        public int CRNAuthorID { get; set; }
        public string CRNote { get; set; }
        public int CRNCrimeID { get; set; }
        public System.DateTime CRNDate { get; set; }
    
        public virtual GCCrimeReport GCCrimeReport { get; set; }
        public virtual GCPerson GCPerson { get; set; }
    }
}
