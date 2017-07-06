using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCDemo.Models
{
    public class Jutes : Person
    {
        public Jutes(string name, int age) : base(name,age)
        {
            this.Ethnicity = PersonType.Jutes;
            this.Height = ((age * 1.6)/2);
        }
    }
}