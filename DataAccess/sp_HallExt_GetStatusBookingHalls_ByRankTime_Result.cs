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
    
    public partial class sp_HallExt_GetStatusBookingHalls_ByRankTime_Result
    {
        public int ID { get; set; }
        public Nullable<bool> Disable { get; set; }
        public byte[] Image { get; set; }
        public Nullable<int> NumTableMax { get; set; }
        public Nullable<int> NumTableStandard { get; set; }
        public Nullable<decimal> CostRef { get; set; }
        public string Sku { get; set; }
        public Nullable<int> Type { get; set; }
        public string Code { get; set; }
        public int BookingHalls_ID { get; set; }
        public Nullable<System.DateTime> Date { get; set; }
        public string Note { get; set; }
        public Nullable<System.TimeSpan> EndTime { get; set; }
        public Nullable<System.TimeSpan> StartTime { get; set; }
        public Nullable<System.DateTime> LunarDate { get; set; }
        public string Location { get; set; }
        public Nullable<int> TableOrPerson { get; set; }
        public Nullable<int> Unit { get; set; }
        public Nullable<bool> Color { get; set; }
        public string Customers_Name { get; set; }
        public string Customers_Tel { get; set; }
        public string Customers_Address { get; set; }
        public string Customers_Nationality { get; set; }
        public Nullable<int> BookingHalls_Status { get; set; }
        public string CustomerGroups_Name { get; set; }
        public Nullable<int> BookingHs_ID { get; set; }
        public string BookingHs_Subject { get; set; }
        public Nullable<int> BookingHs_CustomerType { get; set; }
        public Nullable<decimal> BookingHs_BookingMoney { get; set; }
        public string Companies_Name { get; set; }
    }
}
