using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCDemo.Models
{
    public class Angles : Person
    {
        public Angles(string name, int age) : base(name,age)
        {
            this.Ethnicity = PersonType.Angles;
            this.Height = (1.5 + (age * 0.45));
        }
    }
}