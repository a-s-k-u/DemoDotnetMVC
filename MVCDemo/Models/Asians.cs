using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCDemo.Models
{
    public class Asians : Person
    {
        public Asians(string name, int age) : base(name,age)
        {
            this.Ethnicity = PersonType.Asians;
            this.Height = (1.7 + ((age + 2) * 0.23));
        }
    }
}