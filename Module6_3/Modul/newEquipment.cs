//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Module6_3.Modul
{
    using System;
    using System.Collections.Generic;
    
    public partial class newEquipment
    {
        public int intEquipmentID { get; set; }
        public string intGarageRoom { get; set; }
        public int intManufacturerID { get; set; }
        public int intModelID { get; set; }
        public string strManufYear { get; set; }
        public int intSNPrefixID { get; set; }
        public string strSerialNo { get; set; }
        public int intEquipmentTypeID { get; set; }
        public int intSMCSFamilyID { get; set; }
        public int intSizeID { get; set; }
        public Nullable<System.DateTime> CreateDate { get; set; }
        public double intMetered { get; set; }
        public System.DateTime LastDate { get; set; }
        public double intLastMetered { get; set; }
        public double intTotalMetered { get; set; }
        public Nullable<int> intlimitDay { get; set; }
        public Nullable<int> intlimitWeek { get; set; }
        public bool bitActive { get; set; }
        public bool bitPreservation { get; set; }
        public bool bitMeter { get; set; }
        public bool bitKTG { get; set; }
        public bool isDelete { get; set; }
        public int intLocationId { get; set; }
        public string strDescription { get; set; }
        public Nullable<double> floatCostTires { get; set; }
        public Nullable<int> intCostTiresCurrency { get; set; }
        public Nullable<double> floatAverageDivergence { get; set; }
        public Nullable<double> floatFullPrice { get; set; }
        public Nullable<int> intFullPriceCurrency { get; set; }
        public Nullable<System.DateTime> dateStartUpDate { get; set; }
        public Nullable<int> intServiceLife { get; set; }
        public Nullable<int> intHoweverOddsAcceleration { get; set; }
        public bool bitMethodAmortization { get; set; }
    }
}
