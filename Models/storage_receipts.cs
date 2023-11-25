//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ErpModV.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class storage_receipts
    {
        public storage_receipts()
        {
            this.task_items = new HashSet<task_items>();
        }
    
        public int id { get; set; }
        public Nullable<int> item_id { get; set; }
        public Nullable<int> item_unit { get; set; }
        public decimal item_amount { get; set; }
        public Nullable<decimal> unit_price { get; set; }
        public Nullable<int> transaction_type { get; set; }
        public string transaction_detail { get; set; }
        public int assign_by { get; set; }
        public Nullable<System.DateTime> assign_date { get; set; }
    
        public virtual common_units common_units { get; set; }
        public virtual item_list item_list { get; set; }
        public virtual users users { get; set; }
        public virtual storage_trx_types storage_trx_types { get; set; }
        public virtual ICollection<task_items> task_items { get; set; }
    }
}
