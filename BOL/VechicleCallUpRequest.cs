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
    
    public partial class VechicleCallUpRequest
    {
        public int Id { get; set; }
        public Nullable<int> StorageBillId { get; set; }
        public Nullable<bool> IsCallUpp { get; set; }
        public Nullable<System.DateTime> IsCallUpDate { get; set; }
        public Nullable<System.DateTime> CallUpReqDate { get; set; }
        public Nullable<System.DateTime> CreatedAt { get; set; }
        public string CreatedBy { get; set; }
    }
}
