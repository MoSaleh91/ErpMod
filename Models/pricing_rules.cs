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
    
    public partial class pricing_rules
    {
        public pricing_rules()
        {
            this.proj_pricing = new HashSet<proj_pricing>();
            this.project_contracts = new HashSet<project_contracts>();
        }
    
        public int id { get; set; }
        public bool type_of_rule { get; set; }
        public string price_rule { get; set; }
        public Nullable<decimal> price_percent { get; set; }
    
        public virtual ICollection<proj_pricing> proj_pricing { get; set; }
        public virtual ICollection<project_contracts> project_contracts { get; set; }
    }
}