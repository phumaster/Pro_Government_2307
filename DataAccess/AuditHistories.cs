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
    
    public partial class AuditHistories
    {
        public int ID { get; set; }
        public Nullable<System.DateTime> From { get; set; }
        public Nullable<System.DateTime> To { get; set; }
        public string Note { get; set; }
        public Nullable<int> Type { get; set; }
        public int IDSystemUser { get; set; }
    }
}
