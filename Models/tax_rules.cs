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
    
    public partial class tax_rules
    {
        public tax_rules()
        {
            this.proj_pricing = new HashSet<proj_pricing>();
        }
    
        public int id { get; set; }
        public string tax_rule { get; set; }
        public Nullable<decimal> tax_percent { get; set; }
    
        public virtual ICollection<proj_pricing> proj_pricing { get; set; }
    }
}
