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
    
    public partial class Contracts
    {
        public int ID { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public Nullable<System.DateTime> ContractDate { get; set; }
        public string NumberContract { get; set; }
        public string NumberTemplateContract { get; set; }
        public int IDSystemUser { get; set; }
        public string Company { get; set; }
        public string StatutoryRepresent { get; set; }
        public Nullable<int> StatutoryRepresentGender { get; set; }
        public string StatutoryRepresentIdentifier { get; set; }
        public Nullable<int> ContractType { get; set; }
        public Nullable<System.DateTime> FromDate { get; set; }
        public Nullable<System.DateTime> ToDate { get; set; }
        public Nullable<int> SkuTableSalary { get; set; }
        public Nullable<double> Coefficent { get; set; }
        public Nullable<decimal> SalaryNet { get; set; }
        public Nullable<decimal> SalaryCross { get; set; }
        public Nullable<int> Type { get; set; }
        public Nullable<int> Status { get; set; }
        public Nullable<bool> Disable { get; set; }
    }
}
