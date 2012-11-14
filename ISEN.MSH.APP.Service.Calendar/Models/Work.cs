using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ISEN.MSH.APP.Service.Calendar.Models
{
    public class Work
    {
        public string idcode { get; set; }
        public string title { get; set; }
        public string isallday { get; set; }
        public string start { get; set; }
        public string end { get; set; }
        public string remindtime { get; set; }
        public string isremind { get; set; }
        public string content { get; set; }
    }
}
