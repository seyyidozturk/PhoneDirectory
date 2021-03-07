using PhoneDirectory.Business.Repositories;
using System;

namespace PhoneDirectory.Business
{
    public interface IUnitOfWork : IDisposable
    {
        IPersonRepository Persons { get; }
        ICommunicationRepository Communications { get; }
        int Commit();
    }
}
