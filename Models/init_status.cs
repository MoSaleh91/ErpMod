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
    
    public partial class init_status
    {
        public init_status()
        {
            this.project_status = new HashSet<project_status>();
        }
    
        public int id { get; set; }
        public string init_stat { get; set; }
    
        public virtual ICollection<project_status> project_status { get; set; }
    }
}
