using PhoneDirectory.Data.Entities;
using System;

namespace PhoneDirectory.Business.Repositories
{
    public interface IPersonRepository : IRepository<Person>
    {
        Person GetPersonByIdWithCommunication(Guid id);
    }
}
