//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DataAccess
{
    using System;
    using System.Collections.Generic;
    
    public partial class Permits_SystemUsers
    {
        public int ID { get; set; }
        public int IDPermit { get; set; }
        public int IDSystemUser { get; set; }
        public Nullable<bool> IsView { get; set; }
        public Nullable<bool> IsUpdate { get; set; }
        public Nullable<bool> IsDelete { get; set; }
        public Nullable<bool> IsSpecial { get; set; }
        public Nullable<bool> IsInsert { get; set; }
        public string Description { get; set; }
        public string Logs { get; set; }
        public Nullable<int> Type { get; set; }
        public Nullable<int> Status { get; set; }
        public Nullable<bool> Disable { get; set; }
    }
}
