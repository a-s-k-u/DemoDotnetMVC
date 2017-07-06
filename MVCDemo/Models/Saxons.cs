using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCDemo.Models
{
    public class Saxons : Person
    {
        public Saxons(string name, int age) : base(name,age)
        {
            this.Ethnicity = PersonType.Saxons;
            this.Height = (1.5 + (age * 0.45));
        }
    }
}