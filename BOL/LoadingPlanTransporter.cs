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
    
    public partial class LoadingPlanTransporter
    {
        public int Id { get; set; }
        public Nullable<int> TransporterId { get; set; }
        public Nullable<int> StorageBillId { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public string RefCode { get; set; }
        public Nullable<decimal> TruckQty { get; set; }
        public Nullable<int> Batch { get; set; }
    }
}
