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
    
    public partial class trn_kanban_productivity
    {
        public System.Guid id { get; set; }
        public Nullable<System.DateTime> factory_date { get; set; }
        public Nullable<byte> unit_id { get; set; }
        public Nullable<byte> mc_id { get; set; }
        public Nullable<decimal> building_productivity { get; set; }
        public Nullable<decimal> curing_productivity { get; set; }
        public Nullable<decimal> cycle_time { get; set; }
        public string created_by { get; set; }
        public Nullable<System.DateTime> created_at { get; set; }
    }
}
