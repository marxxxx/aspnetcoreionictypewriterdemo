using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using techplauscherltest2.Models;

namespace techplauscherltest2.Controllers
{
    [Route("api/[controller]")]
    public class PersonController : Controller
    {
        private static readonly List<PersonModel> persons = new List<PersonModel>()
        {
            new PersonModel() { Id = 1, Name = "Markus", Gender = Gender.Male, BirthDate = new DateTime(1990, 1,1)},
            new PersonModel() { Id = 2, Name = "Dominik", Gender = Gender.Male, BirthDate = DateTime.Now},
            new PersonModel() { Id = 3, Name = "Isabella", Gender = Gender.Female, BirthDate = DateTime.Now}
        };


        // GET api/values
        [HttpGet]
        public IEnumerable<PersonModel> Get()
        {
            return persons;
        }
    }
}
