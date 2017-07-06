using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCDemo.Models
{
    public class AgeDemography
    {
        public int TotalPeople { get; set; }
        public double AverageAge { get; set; }
        public int MinAge { get; set; }
        public int MaxAge { get; set; }
        public Dictionary<string, int> EthnicCount { get; set; }
    }
}