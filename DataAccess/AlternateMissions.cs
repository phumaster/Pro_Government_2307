//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DataAccess
{
    using System;
    using System.Collections.Generic;
    
    public partial class AlternateMissions
    {
        public int ID { get; set; }
        public Nullable<int> Type { get; set; }
        public string Subject { get; set; }
        public string Description { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public Nullable<System.DateTime> DecisionDate { get; set; }
        public string NumberDecision { get; set; }
        public string DecisionLevel { get; set; }
        public Nullable<int> Status { get; set; }
        public Nullable<bool> Disable { get; set; }
        public int IDSystemUser { get; set; }
        public Nullable<System.DateTime> FromDate { get; set; }
        public Nullable<System.DateTime> ToDate { get; set; }
        public string Country { get; set; }
    }
}
