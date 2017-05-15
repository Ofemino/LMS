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
    
    public partial class Service_Request
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Service_Request()
        {
            this.QuoteRequests = new HashSet<QuoteRequest>();
        }
    
        public int Id { get; set; }
        public Nullable<int> Bid { get; set; }
        public Nullable<int> AssetId { get; set; }
        public Nullable<int> CustomerId { get; set; }
        public string CustomerRef { get; set; }
        public Nullable<int> AssetQty { get; set; }
        public Nullable<decimal> AssetUnitPrc { get; set; }
        public Nullable<int> ServRequestId { get; set; }
        public string ServRequestRef { get; set; }
        public Nullable<decimal> TotalAmount { get; set; }
        public Nullable<int> AssetOwnerid { get; set; }
        public Nullable<System.DateTime> CreateDate { get; set; }
        public string CreatedBy { get; set; }
    
        public virtual Customer Customer { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<QuoteRequest> QuoteRequests { get; set; }
    }
}