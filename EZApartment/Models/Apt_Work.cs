//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EZApartment.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Apt_Work
    {
        public int ID { get; set; }
        public Nullable<int> User_ID { get; set; }
        public Nullable<int> Task_ID { get; set; }
        public Nullable<System.DateTime> Work_Date { get; set; }
    
        public virtual Apt_Task Apt_Task { get; set; }
        public virtual Apt_User Apt_User { get; set; }
    }
}
