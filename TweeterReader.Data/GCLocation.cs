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
    
    public partial class GCLocation
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public GCLocation()
        {
            this.GCCrimeReports = new HashSet<GCCrimeReport>();
            this.GCPersons = new HashSet<GCPerson>();
        }
    
        public int LocationID { get; set; }
        public string LocationZoneName { get; set; }
        public string LocationZoneDescription { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<GCCrimeReport> GCCrimeReports { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<GCPerson> GCPersons { get; set; }
    }
}
