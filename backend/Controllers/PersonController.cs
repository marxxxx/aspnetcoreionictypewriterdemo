using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using backend.Models;

namespace backend.Controllers
{
    [Route("api/[controller]")]
    public class PersonController : Controller
    {
        // GET api/values
        [HttpGet]
        public IEnumerable<PersonModel> Get()
        {
            var result = new List<PersonModel>()
            {
                new PersonModel(1, "Dominik", Gender.Male),
                new PersonModel(2, "Markus", Gender.Male),
                new PersonModel(3, "Isabella", Gender.Female),
                new PersonModel(4, "Martina", Gender.Female)
            };

            return result;
        }
    }
}
