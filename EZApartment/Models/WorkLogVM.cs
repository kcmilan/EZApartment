using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EZApartment.Models
{
    public class WorkLogVM
    {
        public Nullable<System.DateTime> Work_Date { get; set; }
        public string Apt_Task { get; set; }
        public string Apt_User { get; set; }
    }
}