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
    
    public partial class vw__BookingRInfo__BookingRooms_Room_Customers_CustomerGroups
    {
        public string Customers_Name { get; set; }
        public string Customers_Identifier1 { get; set; }
        public string Customers_Identifier2 { get; set; }
        public string Customers_Identifier3 { get; set; }
        public string Customers_Nationality { get; set; }
        public Nullable<System.DateTime> Customers_Birthday { get; set; }
        public string Customers_Tel { get; set; }
        public string Customers_Address { get; set; }
        public string Customers_Email { get; set; }
        public string Customers_Gender { get; set; }
        public Nullable<int> Customers_Citizen { get; set; }
        public Nullable<System.DateTime> Customers_Identifier1CreatedDate { get; set; }
        public Nullable<System.DateTime> Customers_Identifier3CreatedDate { get; set; }
        public Nullable<System.DateTime> Customers_Identifier2CreatedDate { get; set; }
        public string Customers_PlaceOfIssue1 { get; set; }
        public string Customers_PlaceOfIssue2 { get; set; }
        public string Customers_PlaceOfIssue3 { get; set; }
        public Nullable<System.DateTime> BookingRooms_CheckInPlan { get; set; }
        public Nullable<System.DateTime> BookingRooms_CheckInActual { get; set; }
        public Nullable<System.DateTime> BookingRooms_CheckOutPlan { get; set; }
        public Nullable<System.DateTime> BookingRooms_CheckOutActual { get; set; }
        public string Rooms_Code { get; set; }
        public Nullable<int> Rooms_IDLang { get; set; }
        public string Rooms_Sku { get; set; }
        public Nullable<int> BookingRooms_IDBookingR { get; set; }
        public Nullable<int> BookingRooms_ID { get; set; }
        public int IDBookingRoom { get; set; }
        public int IDCustomer { get; set; }
    }
}