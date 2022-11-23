using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Net.Http;
using System.Web.Http;
using WebApi_Assignment.Models;

namespace WebApi_Assignment.Controllers
{
    public class CountryController : ApiController
    {
        // GET: Country
        static List<Country> countrylist = new List<Country>
        {
            new Country{ID = 1,CountryName="India",Capital="New Delhi"},
            new Country{ID = 2,CountryName="America",Capital="Washington"},
            new Country{ID = 3,CountryName="England",Capital = "London"},
            new Country{ID = 4,CountryName="Australia",Capital = "Canberra"},
            new Country{ID = 5,CountryName="Argentina",Capital = "Buenos Aires"},
            new Country{ID = 6,CountryName="West Indies",Capital = "Chaguaramas"},



        };

        
        public IEnumerable<Country> Get()
        {
            return countrylist;
        }
       
        public Country Get(int id)
        {
            return countrylist[id - 1];
        }

        public IEnumerable<Country> Post([FromBody] Country c)
        {
            countrylist.Add(c);
            return countrylist;
        }
        public IEnumerable<Country> Delete(int id)
        {
            countrylist.RemoveAt(id - 1);
            return countrylist;
        }

    }
}