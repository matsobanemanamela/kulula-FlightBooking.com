//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebApi.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Flight_Departure
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Flight_Departure()
        {
            this.PreferredClasses = new HashSet<PreferredClass>();
            this.FlightBookings = new HashSet<FlightBooking>();
        }
    
        public int AirportID { get; set; }
        public int AircraftID { get; set; }
        public int ArrivalID { get; set; }
        public string AirportName { get; set; }
        public string DepartingTime { get; set; }
        public string DepartingDate { get; set; }
    
        public virtual Aircraft Aircraft { get; set; }
        public virtual FlightArrival FlightArrival { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PreferredClass> PreferredClasses { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FlightBooking> FlightBookings { get; set; }
    }
}
