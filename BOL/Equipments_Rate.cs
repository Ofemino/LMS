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
    
    public partial class Equipments_Rate
    {
        public int Id { get; set; }
        public string RateRef { get; set; }
        public int MachineId { get; set; }
        public Nullable<decimal> AssetRate { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public Nullable<System.DateTime> ModifiedDate { get; set; }
        public string ModifiedBy { get; set; }
        public string Duration { get; set; }
        public Nullable<bool> IsRated { get; set; }
        public string RateKey { get; set; }
    }
}