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
    
    public partial class vw__BookingRInfo__BookingRs_Customers_Companies_SystemUsers
    {
        public int BookingRs_ID { get; set; }
        public Nullable<System.DateTime> BookingRs_CreatedDate { get; set; }
        public Nullable<int> BookingRs_CustomerType { get; set; }
        public Nullable<int> BookingRs_BookingType { get; set; }
        public string BookingRs_Note { get; set; }
        public int BookingRs_IDCustomer { get; set; }
        public int BookingRs_IDSystemUser { get; set; }
        public Nullable<int> BookingRs_PayMenthod { get; set; }
        public Nullable<int> BookingRs_StatusPay { get; set; }
        public Nullable<decimal> BookingRs_BookingMoney { get; set; }
        public Nullable<decimal> BookingRs_ExchangeRate { get; set; }
        public Nullable<int> BookingRs_Status { get; set; }
        public Nullable<int> BookingRs_Type { get; set; }
        public Nullable<bool> BookingRs_Disable { get; set; }
        public int BookingRs_Level { get; set; }
        public string BookingRs_Subject { get; set; }
        public string BookingRs_Description { get; set; }
        public System.DateTime BookingRs_DatePay { get; set; }
        public System.DateTime BookingRs_DateEdit { get; set; }
        public int BookingRs_IDCustomerGroup { get; set; }
        public string SystemUsers_Username { get; set; }
        public Nullable<int> Customers_ID { get; set; }
        public string Customers_Name { get; set; }
        public string Customers_Identifier1 { get; set; }
        public string Customers_Identifier2 { get; set; }
        public string Customers_Identifier3 { get; set; }
        public Nullable<int> Customers_Type { get; set; }
        public Nullable<int> Companies_ID { get; set; }
        public string Companies_Name { get; set; }
        public Nullable<int> Companies_Type { get; set; }
        public Nullable<int> Companies_Status { get; set; }
        public Nullable<int> CustomerGroups_ID { get; set; }
        public string CustomerGroups_Name { get; set; }
        public Nullable<int> CustomerGroups_Type { get; set; }
        public Nullable<int> CustomerGroups_Status { get; set; }
        public string Customers_Gender { get; set; }
        public Nullable<int> Customers_Citizen { get; set; }
        public Nullable<int> BookingRs_BookingHs_IDBookingH { get; set; }
        public Nullable<int> BookingHs_Status { get; set; }
        public Nullable<int> BookingHs_StatusPay { get; set; }
        public Nullable<int> BookingHs_Type { get; set; }
        public Nullable<bool> BookingHs_Disable { get; set; }
        public string BookingHs_Subject { get; set; }
        public string BookingRs_InvoiceNumber { get; set; }
        public Nullable<System.DateTime> BookingRs_InvoiceDate { get; set; }
        public string Rooms_Sku { get; set; }
        public string Rooms_Code { get; set; }
    }
}
