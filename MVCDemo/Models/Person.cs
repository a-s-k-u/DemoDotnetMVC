using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCDemo.Models
{
    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set;}
        public Double Height { get; set; }
        public PersonType Ethnicity {  get;set; }

        public override string ToString()
        {
            return "My name is " + Name + " and I'm " + Age + " years old and of " + Ethnicity.ToString() + " origin";
        }
        public Person(string name, int Age)
        {
            this.Name = name;
            this.Age = Age;
        }
    }
    
}