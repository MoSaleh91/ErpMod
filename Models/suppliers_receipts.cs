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
    
    public partial class suppliers_receipts
    {
        public suppliers_receipts()
        {
            this.task_items = new HashSet<task_items>();
        }
    
        public int id { get; set; }
        public Nullable<int> supplier_id { get; set; }
        public Nullable<int> item_id { get; set; }
        public Nullable<int> item_unit { get; set; }
        public Nullable<int> fin_rec_id { get; set; }
        public Nullable<int> transaction_type { get; set; }
        public string purchase_detail { get; set; }
    
        public virtual common_units common_units { get; set; }
        public virtual financial_records financial_records { get; set; }
        public virtual item_list item_list { get; set; }
        public virtual purchase_trx_types purchase_trx_types { get; set; }
        public virtual suppliers suppliers { get; set; }
        public virtual ICollection<task_items> task_items { get; set; }
    }
}
