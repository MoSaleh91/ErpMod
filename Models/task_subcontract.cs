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
    
    public partial class task_subcontract
    {
        public task_subcontract()
        {
            this.task_progress = new HashSet<task_progress>();
        }
    
        public int id { get; set; }
        public Nullable<int> task_id { get; set; }
        public string task_description { get; set; }
        public int contractor_rec { get; set; }
        public int assign_by { get; set; }
        public System.DateTime assign_date { get; set; }
    
        public virtual contractors_receipts contractors_receipts { get; set; }
        public virtual project_executive project_executive { get; set; }
        public virtual ICollection<task_progress> task_progress { get; set; }
        public virtual users users { get; set; }
    }
}
