using PhoneDirectory.Business.Model;
using PhoneDirectory.Data.Entities;
using System;

namespace PhoneDirectory.Business.Services
{
    public class PersonService : BaseService, IPersonService
    {
        public PersonService(IUnitOfWork _UnitOfWork) : base(_UnitOfWork)
        {
        }

        public Result CreatePerson(Person person)
        {
            UnitOfWork.Persons.Add(person);
            UnitOfWork.Commit();
            return Result.GetSuccess("Created");
        }

        public Result DeletePerson(Guid id)
        {
            var result = GetPersonById(id);
            UnitOfWork.Persons.Remove((Person)result.Data);
            UnitOfWork.Commit();
            return Result.GetSuccess("Deleted");
        }

        public Result GetAllPersons()
        {
            var list = UnitOfWork.Persons.GetList();
            return Result.GetSuccess("Was Received", list);
        }

        public Result GetPersonById(Guid id)
        {
            var person = UnitOfWork.Persons.GetById(id);
            return Result.GetSuccess("Was Found", person);
        }

        public Result GetPersonByIdWithCommunication(Guid id)
        {
            var person = UnitOfWork.Persons.GetPersonByIdWithCommunication(id);
            return Result.GetSuccess("Was Found", person);
        }

        public Result UpdatePerson(Person person)
        {
            UnitOfWork.Persons.Update(person);
            UnitOfWork.Commit();
            return Result.GetSuccess("Updated", person);
        }
    }
}
