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
    
    public partial class proj_domain
    {
        public proj_domain()
        {
            this.contractors = new HashSet<contractors>();
            this.init_risk = new HashSet<init_risk>();
            this.projects = new HashSet<projects>();
        }
    
        public int id { get; set; }
        public string p_domains { get; set; }
    
        public virtual ICollection<contractors> contractors { get; set; }
        public virtual ICollection<init_risk> init_risk { get; set; }
        public virtual ICollection<projects> projects { get; set; }
    }
}
