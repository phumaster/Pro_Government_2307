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
    
    public partial class vw__BookingHalls_ServicesInfo__BookingHalls_BookingHallsServices_Services_ServiceGroups
    {
        public int BookingHalls_IDBookingH { get; set; }
        public int BookingHalls_Services_IDBookingHall { get; set; }
        public int ServiceGroups_ID { get; set; }
        public int Services_ID { get; set; }
        public int BookingHalls_Services_ID { get; set; }
        public string Services_Name { get; set; }
        public Nullable<decimal> Services_CostRef { get; set; }
        public string Services_Unit { get; set; }
        public Nullable<int> Services_Status { get; set; }
        public Nullable<int> Services_Type { get; set; }
        public Nullable<bool> Services_Disable { get; set; }
        public string ServiceGroups_Name { get; set; }
        public Nullable<int> ServiceGroups_Type { get; set; }
        public Nullable<bool> ServiceGroups_Disable { get; set; }
        public string BookingHalls_Services_Info { get; set; }
        public Nullable<int> BookingHalls_Services_Type { get; set; }
        public Nullable<int> BookingHalls_Services_Status { get; set; }
        public Nullable<bool> BookingHalls_Services_Disable { get; set; }
        public Nullable<decimal> BookingHalls_Services_Cost { get; set; }
        public Nullable<System.DateTime> BookingHalls_Services_Date { get; set; }
        public Nullable<double> BookingHalls_Services_PercentTax { get; set; }
        public Nullable<double> BookingHalls_Services_Quantity { get; set; }
        public Nullable<decimal> BookingHalls_Services_CostRef_Services { get; set; }
        public string BookingHalls_CodeHall { get; set; }
        public Nullable<int> BookingHalls_Services_IndexSubPayment { get; set; }
        public Nullable<System.DateTime> BookingHalls_Services_InvoiceDate { get; set; }
        public string BookingHalls_Services_InvoiceNumber { get; set; }
        public Nullable<System.DateTime> BookingHalls_Services_AcceptDate { get; set; }
        public string BookingHalls_Services_Tag { get; set; }
    }
}
