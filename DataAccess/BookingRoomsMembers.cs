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
    
    public partial class BookingRoomsMembers
    {
        public int ID { get; set; }
        public int IDBookingRoom { get; set; }
        public int IDCustomer { get; set; }
        public Nullable<int> Status { get; set; }
        public Nullable<int> Disable { get; set; }
        public Nullable<int> Type { get; set; }
        public string PurposeComeVietnam { get; set; }
        public Nullable<System.DateTime> DateEnterCountry { get; set; }
        public string EnterGate { get; set; }
        public Nullable<System.DateTime> TemporaryResidenceDate { get; set; }
        public Nullable<System.DateTime> LeaveDate { get; set; }
        public string Organization { get; set; }
        public Nullable<System.DateTime> LimitDateEnterCountry { get; set; }
    }
}
