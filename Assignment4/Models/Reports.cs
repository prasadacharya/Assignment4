using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
namespace Assignment4.Models
{
      public class Report
        {
            [Key]
            public int id { get; set; }
            public string name { get; set; }
            public string desc { get; set; }
        }
    public class Reports
    {
        [Key]
        public string status { get; set; }
        //public Info info { get; set; }
        public List<Report> data { get; set; }
    }
}


