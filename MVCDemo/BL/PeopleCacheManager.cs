using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Runtime.Caching;
using MVCDemo.Models;

namespace MVCDemo.BL
{
    public static class PeopleCacheManager
    {
        private static MemoryCache _cache = MemoryCache.Default;

        public static List<Person> PersonList
        {
            get
            {
                if (!_cache.Contains("PersonList"))
                    GetPersonList();
                return _cache.Get("PersonList") as List<Person>;
            }
        }

        public static void GetPersonList()
        {
            List<Person> People = new List<Person>();
            int personType = 0;
            Random rnd = new Random();

            for (int i = 0; i < 10000; i++)
            {
                personType = rnd.Next(1, 5);
                People.Add(CreatePerson("Person#" + i.ToString(), rnd.Next(1, 99), (PersonType)personType));
            }

            CacheItemPolicy cacheItemPolicy = new CacheItemPolicy();
            cacheItemPolicy.AbsoluteExpiration = DateTime.Now.AddDays(1);

            _cache.Add("PersonList", People, cacheItemPolicy);
        }

        private static Person CreatePerson(string name, int age, PersonType personType)
        {
            if (personType == PersonType.Angles)
                return new Angles(name, age);
            else if (personType == PersonType.Saxons)
                return new Saxons(name, age);
            else if (personType == PersonType.Jutes)
                return new Jutes(name, age);
            else if (personType == PersonType.Asians)
                return new Asians(name, age);
            else
                return null;
        }

        //loop through the list and increment the age by 1
        private static void incrementAge()
        {
            foreach (var person in PeopleCacheManager.PersonList)
            {
                person.Age = person.Age + 1;
            }
        }

    }
}