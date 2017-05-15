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
    
    public partial class SalesOrder
    {
        public int Id { get; set; }
        public Nullable<int> QuoteId { get; set; }
        public Nullable<int> CustomerId { get; set; }
        public string QuoteRef { get; set; }
        public string OrderNo { get; set; }
        public Nullable<System.DateTime> OrderDate { get; set; }
        public string SalesPerson { get; set; }
        public string BillToId { get; set; }
        public Nullable<int> SrNo { get; set; }
        public string ItemCode { get; set; }
        public string ItemDescription { get; set; }
        public string Quatity { get; set; }
        public Nullable<decimal> UnitPrice { get; set; }
        public Nullable<decimal> TotalPrice { get; set; }
        public Nullable<decimal> TotalAed { get; set; }
        public Nullable<decimal> GrandTotal { get; set; }
        public Nullable<System.DateTime> DateAdded { get; set; }
        public string CreatedBy { get; set; }
    
        public virtual Customer Customer { get; set; }
    }
}
