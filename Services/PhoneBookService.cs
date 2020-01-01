using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NoBullshitBlazor.Data;
using NoBullshitBlazor.Services.Interfaces;

namespace NoBullshitBlazor.Services
{
    public class PhoneBookService : IPhonebookService
    {
        private List<Person> _people = new List<Person>();
        public void AddPerson(Person person)
        {
            _people.Add(person);   
        }

        public List<Person> GetPeople()
        {
            return _people;
        }

        public Person GetPerson(int id)
        {
            throw new NotImplementedException();
        }

        public Person GetPerson(string lastName, string firstName)
        {
            throw new NotImplementedException();
        }

        public bool DeletePerson(Person person)
        {
            throw new NotImplementedException();
        }
    }
}
