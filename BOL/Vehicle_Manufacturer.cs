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
    
    public partial class Vehicle_Manufacturer
    {
        public int Id { get; set; }
        public string man_code { get; set; }
        public string man_fullname { get; set; }
        public string man_otherdetails { get; set; }
        public Nullable<System.DateTime> created_at { get; set; }
        public Nullable<System.DateTime> last_modified { get; set; }
        public string created_by { get; set; }
    }
}
