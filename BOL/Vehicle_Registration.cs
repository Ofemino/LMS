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
    
    public partial class Vehicle_Registration
    {
        public int Id { get; set; }
        public string v_ref { get; set; }
        public Nullable<int> registered_to { get; set; }
        public string vin { get; set; }
        public string ven { get; set; }
        public string plateNumber { get; set; }
        public string v_make { get; set; }
        public string v_model { get; set; }
        public string v_year { get; set; }
        public Nullable<decimal> v_weight { get; set; }
        public string v_body_type { get; set; }
        public string v_colour { get; set; }
        public Nullable<System.DateTime> v_compliance_date { get; set; }
        public string v_outside_wheels { get; set; }
        public string v_seating_capacity { get; set; }
        public string v_condition { get; set; }
        public string v_transmission { get; set; }
        public string v_engine_type { get; set; }
        public string v_fuel_type { get; set; }
        public string v_left_hand { get; set; }
        public Nullable<System.DateTime> created_at { get; set; }
        public Nullable<System.DateTime> last_modified { get; set; }
        public string created_by { get; set; }
        public Nullable<int> o_id { get; set; }
        public string truck_type { get; set; }
        public string truck_capacity { get; set; }
        public string truck_destination { get; set; }
    }
}