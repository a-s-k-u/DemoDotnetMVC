using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCDemo.Models;
using MVCDemo.BL;

namespace MVCDemo.Controllers
{
    public class PersonController : Controller
    {
        // GET: Person
        public ActionResult Index(string id)
        {
            try
            {
                int PersonType = 0;
                List<Person> People = PeopleCacheManager.PersonList;
                if (id == null)
                {
                    PersonType = 1; //defaulting to 1.
                }
                else
                {
                    PersonType = int.Parse(id);
                }
                //People = PeopleCacheManager.PersonList;
                var querySpecificGroup  = from person in People
                                           where (person.Ethnicity == (PersonType)PersonType) && (person.Age % 2 == 0)
                                           select person;
                return View(querySpecificGroup.ToList());
            }
            catch (Exception)
            {
                // TODO - Error handling.
                //throwing the error so as to assist debugging. 
                throw;
            }
            
        }

        private Person CreatePerson(string name, int age, PersonType personType)
        {
            if (personType == PersonType.Angles)
                return new Angles(name,age);
            else if (personType == PersonType.Saxons)
                return new Saxons(name,age);
            else if (personType == PersonType.Saxons)
                return new Saxons(name,age);
            else if (personType == PersonType.Saxons)
                return new Saxons(name,age);
            else
                return new Person(name,age);
        }
    }
}