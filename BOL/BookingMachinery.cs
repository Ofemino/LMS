//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BOL
{
    using System;
    using System.Collections.Generic;
    
    public partial class BookingMachinery
    {
        public int Id { get; set; }
        public Nullable<int> BookingId { get; set; }
        public Nullable<int> MachineryId { get; set; }
        public Nullable<int> CargoLocationId { get; set; }
        public Nullable<decimal> Rate { get; set; }
        public string CreatedBy { get; set; }
        public Nullable<System.DateTime> CreatedAt { get; set; }
    }
}