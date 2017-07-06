using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCDemo.Models
{
    public class People : IEnumerable<Person>
    {
        public List<Person> people { get; set; }

        public IEnumerator<Person> GetEnumerator()
        {
            return ((IEnumerable<Person>)people).GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return ((IEnumerable<Person>)people).GetEnumerator();
        }
    }
}