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
    
    public partial class sp_Get_Status_ListRooms_In_Month_Result
    {
        public Nullable<int> DayIndex { get; set; }
        public Nullable<int> BookingRs_ID { get; set; }
        public Nullable<int> BookingRs_CustomerType { get; set; }
        public Nullable<int> BookingRs_PayMethod { get; set; }
        public string Rooms_Sku { get; set; }
        public string Rooms_Code { get; set; }
        public Nullable<int> BookingRooms_ID { get; set; }
        public Nullable<System.DateTime> BookingRooms_CheckInActual { get; set; }
        public Nullable<System.DateTime> BookingRooms_CheckOutActual { get; set; }
        public Nullable<int> BookingRooms_Type { get; set; }
        public Nullable<int> BookingRooms_Status { get; set; }
        public Nullable<decimal> BookingRooms_AddTimeStart { get; set; }
        public Nullable<decimal> BookingRooms_AddTimeEnd { get; set; }
        public string Company_Name { get; set; }
        public Nullable<int> Company_Type { get; set; }
        public Nullable<int> Company_ID { get; set; }
        public string CustomerGroups_Name { get; set; }
        public Nullable<int> CustomerGroups_Type { get; set; }
        public string Customers_Name { get; set; }
        public Nullable<int> NumberCustomer { get; set; }
    }
}
