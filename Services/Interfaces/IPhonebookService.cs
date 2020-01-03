using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NoBullshitBlazor.Data;

namespace NoBullshitBlazor.Services.Interfaces
{
    public interface IPhonebookService
    {
        void AddPerson(Person person);
        List<Person> GetPeople();
        Person GetPerson(int id);
        Person GetPerson(string lastName, string firstName);
        void DeletePerson(Person person);
    }
}
