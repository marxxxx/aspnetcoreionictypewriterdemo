using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace backend.Models
{
    public class PersonModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Gender Gender { get; set; }
        public string Adress { get; set; }

        public PersonModel(int id, string name, Gender gender)
        {
            this.Id = id;
            this.Name = name;
            this.Gender = gender;
        }
    }
}
