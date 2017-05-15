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
    
    public partial class ConsignmentEvacuation
    {
        public int Id { get; set; }
        public Nullable<int> ConsignmentId { get; set; }
        public Nullable<int> BookingId { get; set; }
        public string BookingStatus { get; set; }
        public Nullable<decimal> InitialTonnage { get; set; }
        public Nullable<decimal> TakenTonnage { get; set; }
        public Nullable<decimal> FinalTonnage { get; set; }
        public Nullable<int> InitialPackets { get; set; }
        public Nullable<int> TakenPackets { get; set; }
        public Nullable<int> FinalPackets { get; set; }
        public Nullable<System.DateTime> DateTaken { get; set; }
        public Nullable<System.DateTime> DateAdded { get; set; }
        public string AddedBy { get; set; }
    }
}