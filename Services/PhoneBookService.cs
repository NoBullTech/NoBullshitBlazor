using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Rendering;
using NoBullshitBlazor.Data;
using NoBullshitBlazor.Services.Interfaces;

namespace NoBullshitBlazor.Services
{
    public class PhoneBookService : IPhonebookService
    {
        private List<Person> _people = new List<Person>();
        private static int _lastId = 1;
        public void AddPerson(Person person)
        {
            person.Id = _lastId++;
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

        public Person GetPerson(string lastName, string firstName)
        {
            return _people.FirstOrDefault(p => p.LastName == lastName && p.FirstName == firstName);
        }

        public void DeletePerson(Person person)
        {
            _people.RemoveAll(p=>p.Id == person.Id || p.FirstName == person.FirstName && p.LastName==person.LastName);
        }
    }
}
