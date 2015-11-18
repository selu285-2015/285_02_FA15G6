using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _285ProjectDemo.Models
{
    public class Major
    {
        public int ID { get; set; }
        public string Description { get; set; }
        public List<Concentration> Concentrations { get; set; } 
    }
}