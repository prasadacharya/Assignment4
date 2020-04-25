using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Assignment4.Models
{
    public class SurveyData
    {
        public int year { get; set; }
        public string state { get; set; }
        public string category { get; set; }
        public string farmtype { get; set; }
        public string report { get; set; }
        public string variable_name { get; set; }
        public double estimate { get; set; }

    }

    public class SurveyDatas
    {
        public string status { get; set; }
        
        public List<SurveyData> data { get; set; }
    }
}

