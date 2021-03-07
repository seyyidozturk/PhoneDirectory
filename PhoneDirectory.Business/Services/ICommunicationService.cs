using PhoneDirectory.Business.Model;
using PhoneDirectory.Data.Entities;
using System;

namespace PhoneDirectory.Business.Services
{
    public interface ICommunicationService : IService
    {
        Result CreateCommunication(Communication communication);
        Result DeleteCommunication(Guid id);

        Result GetById(Guid id);

    }
}
