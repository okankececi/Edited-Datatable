//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace dataTable_edited.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class trn_kanban_machine_planned_loss
    {
        public System.Guid id { get; set; }
        public Nullable<System.DateTime> factory_date { get; set; }
        public Nullable<int> unit_id { get; set; }
        public Nullable<int> mc_no { get; set; }
        public string size_code { get; set; }
        public Nullable<int> loss_time { get; set; }
        public string created_by { get; set; }
        public Nullable<System.DateTime> created_at { get; set; }
        public string updated_by { get; set; }
        public Nullable<System.DateTime> updated_at { get; set; }
    }
}
