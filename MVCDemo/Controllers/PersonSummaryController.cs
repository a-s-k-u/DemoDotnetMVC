using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using MVCDemo.BL;
using MVCDemo.Models;

namespace MVCDemo.Controllers
{
    
    public class PersonSummaryController : ApiController
    {
        //GET api/PersonSummary
        public AgeDemography Get()
        {
            AgeDemography ageSummary = new AgeDemography();
            List<Person> People = PeopleCacheManager.PersonList;
            ageSummary.TotalPeople = People.Count;
            ageSummary.MinAge = People.Min(r => r.Age);
            ageSummary.MinAge = People.Max(r => r.Age);
            ageSummary.AverageAge = People.Average(r => r.Age);

            ageSummary.EthnicCount = new Dictionary<string, int>();
            foreach (var group in People.GroupBy(info => info.Ethnicity)
                        .Select(group => new {
                            Name = group.Key,
                            Count = group.Count()
                        }).OrderBy(x => x.Name))
              {
                ageSummary.EthnicCount.Add(group.Name.ToString(), group.Count);
            }
            return ageSummary;
        }
        
    }
}
