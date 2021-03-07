using PhoneDirectory.Business.Model;
using PhoneDirectory.Data.Entities;
using System;

namespace PhoneDirectory.Business.Services
{
    public interface IPersonService : IService
    {
        Result CreatePerson(Person person);
        Result UpdatePerson(Person person);
        Result DeletePerson(Guid id);
        Result GetAllPersons();
        Result GetPersonByIdWithCommunication(Guid id);
        Result GetPersonById(Guid id);
    }
}
