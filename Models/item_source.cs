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
    
    public partial class item_source
    {
        public item_source()
        {
            this.proj_pricing = new HashSet<proj_pricing>();
        }
    
        public int id { get; set; }
        public int phase_id { get; set; }
        public Nullable<decimal> amount_in_stock { get; set; }
        public Nullable<decimal> stock_avg_price { get; set; }
        public Nullable<decimal> prev_purchase_price { get; set; }
        public Nullable<decimal> is_new_price { get; set; }
    
        public virtual proj_phases proj_phases { get; set; }
        public virtual ICollection<proj_pricing> proj_pricing { get; set; }
    }
}
