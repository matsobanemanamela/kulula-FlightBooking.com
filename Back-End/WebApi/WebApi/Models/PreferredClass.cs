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
    
    public partial class PreferredClass
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PreferredClass()
        {
            this.Carts = new HashSet<Cart>();
        }
    
        public int PreferredClassID { get; set; }
        public int AirportID { get; set; }
        public string PreferredClassType { get; set; }
        public string FlightType { get; set; }
        public double Price { get; set; }
        public double Quantity { get; set; }
        public double Total { get; set; }
    
        public virtual Flight_Departure Flight_Departure { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Cart> Carts { get; set; }
    }
}
