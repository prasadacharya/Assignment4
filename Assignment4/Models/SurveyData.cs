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
        public string id { get; set; }
        public string name { get; set; }
        public string farmtype { get; set; }
        public string Report { get; set; }
        public string variablename { get; set; }
        public double estimate { get; set; }
        public object median { get; set; }

    }

    public class SurveyDatas
    {
        public string status { get; set; }
        
        public List<SurveyData> data { get; set; }
    }
}

