using Oops.Models;
using System.Collections.Generic;
using System.Linq;

namespace Oops.Repositories
{
    public class PersonRepository
    {
        private List<Person> _people = new List<Person>();

        public void Add(Person person)
        {
            _people.Add(person);
        }

        public List<Person> GetPeople()
        {
            return _people;
        }

        public Person GetPerson(int id)
        {
            return _people.FirstOrDefault(p => p.Id == id);
        }
    }
}
