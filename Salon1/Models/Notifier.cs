//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Salon1.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Notifier
    {
        public int NotifierID { get; set; }
        public int CustomerID { get; set; }
        public int BookingID { get; set; }
    
        public virtual Booking Booking { get; set; }
        public virtual Customer Customer { get; set; }
    }
}