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
    
    public partial class VepMonitoring
    {
        public int Id { get; set; }
        public Nullable<int> VepId { get; set; }
        public Nullable<int> VepExpected { get; set; }
        public Nullable<int> VepReceived { get; set; }
        public Nullable<int> VepDispensed { get; set; }
        public Nullable<System.DateTime> VepDate { get; set; }
        public string CreatedBy { get; set; }
        public Nullable<System.DateTime> CreatedAt { get; set; }
    }
}
