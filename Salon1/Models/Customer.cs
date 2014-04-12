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
    
    public partial class Customer
    {
        public Customer()
        {
            this.Bookings = new HashSet<Booking>();
            this.Contacts = new HashSet<Contact>();
            this.Notifiers = new HashSet<Notifier>();
        }
    
        public int CustomerID { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string Gender { get; set; }
        public Nullable<System.DateTime> DOB { get; set; }
    
        public virtual ICollection<Booking> Bookings { get; set; }
        public virtual ICollection<Contact> Contacts { get; set; }
        public virtual ICollection<Notifier> Notifiers { get; set; }
    }
}