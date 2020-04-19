using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Assignment4.Models
{
    public class Category
    {
          // [Key]
            public string id { get; set; }
            public string name { get; set; }
            public string description { get; set; }
            public int sequence { get; set; }
        
    }
    public class Categories
    {
        [Key]
        public string status { get; set; }
        public List<Category> data { get; set; } 
    }   
}

