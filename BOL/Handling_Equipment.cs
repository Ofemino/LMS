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
    
    public partial class Handling_Equipment
    {
        public int Id { get; set; }
        public string Refid { get; set; }
        public Nullable<int> MachineId { get; set; }
        public Nullable<int> Status { get; set; }
        public Nullable<int> Availability { get; set; }
        public string Location { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public Nullable<System.DateTime> LastModified { get; set; }
        public string ModifiedBy { get; set; }
    }
}