﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class prManSysEntities1 : DbContext
    {
        public prManSysEntities1()
            : base("name=prManSysEntities1")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<analysis_status> analysis_status { get; set; }
        public DbSet<clients> clients { get; set; }
        public DbSet<clients_receipts> clients_receipts { get; set; }
        public DbSet<common_units> common_units { get; set; }
        public DbSet<contractors> contractors { get; set; }
        public DbSet<contractors_receipts> contractors_receipts { get; set; }
        public DbSet<currency_list> currency_list { get; set; }
        public DbSet<departments> departments { get; set; }
        public DbSet<fin_rec_status> fin_rec_status { get; set; }
        public DbSet<fin_rec_types> fin_rec_types { get; set; }
        public DbSet<financial_records> financial_records { get; set; }
        public DbSet<init_risk> init_risk { get; set; }
        public DbSet<init_status> init_status { get; set; }
        public DbSet<item_list> item_list { get; set; }
        public DbSet<item_source> item_source { get; set; }
        public DbSet<item_types> item_types { get; set; }
        public DbSet<pricing_rules> pricing_rules { get; set; }
        public DbSet<pricing_status> pricing_status { get; set; }
        public DbSet<proj_domain> proj_domain { get; set; }
        public DbSet<proj_phases> proj_phases { get; set; }
        public DbSet<proj_pricing> proj_pricing { get; set; }
        public DbSet<project_contracts> project_contracts { get; set; }
        public DbSet<project_executive> project_executive { get; set; }
        public DbSet<project_payment_types> project_payment_types { get; set; }
        public DbSet<project_status> project_status { get; set; }
        public DbSet<project_users> project_users { get; set; }
        public DbSet<projects> projects { get; set; }
        public DbSet<purchase_trx_types> purchase_trx_types { get; set; }
        public DbSet<revenue_rules> revenue_rules { get; set; }
        public DbSet<risk_rules> risk_rules { get; set; }
        public DbSet<roles> roles { get; set; }
        public DbSet<storage_receipts> storage_receipts { get; set; }
        public DbSet<storage_trx_types> storage_trx_types { get; set; }
        public DbSet<suppliers> suppliers { get; set; }
        public DbSet<suppliers_receipts> suppliers_receipts { get; set; }
        public DbSet<sysdiagrams> sysdiagrams { get; set; }
        public DbSet<task_funding> task_funding { get; set; }
        public DbSet<task_items> task_items { get; set; }
        public DbSet<task_progress> task_progress { get; set; }
        public DbSet<task_subcontract> task_subcontract { get; set; }
        public DbSet<task_worker> task_worker { get; set; }
        public DbSet<tax_rules> tax_rules { get; set; }
        public DbSet<users> users { get; set; }
    }
}
