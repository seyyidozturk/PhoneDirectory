using Microsoft.EntityFrameworkCore;
using PhoneDirectory.Data;
using PhoneDirectory.Data.Entities;
using System;
using System.Linq;

namespace PhoneDirectory.Business.Repositories
{
    public class PersonRepository : Repository<Person>, IPersonRepository
    {
        public PersonRepository(PhoneDirectoryContext context) : base(context)
        {

        }

        public Person GetPersonByIdWithCommunication(Guid id)
        {
           return db.Include(x => x.Communications).SingleOrDefault(x => x.Id == id);
        }
    }
}
