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
    
    public partial class ExtraCosts
    {
        public int ID { get; set; }
        public string Sku { get; set; }
        public string PriceType { get; set; }
        public Nullable<int> NumberPeople { get; set; }
        public string CustomerType { get; set; }
        public Nullable<decimal> ExtraValue { get; set; }
        public Nullable<int> Status { get; set; }
        public Nullable<bool> Disable { get; set; }
        public Nullable<int> Type { get; set; }
    }
}
