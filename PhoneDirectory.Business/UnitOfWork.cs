using PhoneDirectory.Business.Repositories;
using PhoneDirectory.Data;

namespace PhoneDirectory.Business
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly PhoneDirectoryContext context;
        public UnitOfWork(PhoneDirectoryContext _context)
        {
            this.context = _context;
        }

        private readonly PersonRepository _personRepository;
        private readonly CommunicationRepository _communicationRepository;

        public IPersonRepository Persons => _personRepository ?? new PersonRepository(context);

        public ICommunicationRepository Communications => _communicationRepository ?? new CommunicationRepository(context);

        public void Dispose() => context.Dispose();

        public int Commit()
        {
            return context.SaveChanges();
        }
    }
}
