using PhoneDirectory.Business.Model;
using PhoneDirectory.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneDirectory.Business.Services
{
    public class CommunicationService : ICommunicationService
    {
        private readonly IUnitOfWork unitOfWork;
        public CommunicationService(IUnitOfWork _unitOfWork)
        {
            unitOfWork = _unitOfWork;
        }

        public Result CreateCommunication(Communication communication)
        {
            unitOfWork.Communications.Add(communication);
            unitOfWork.Commit();
            return Result.GetSuccess("Created");
        }

        public Result DeleteCommunication(Guid id)
        {
            var result = GetById(id);
            unitOfWork.Communications.Remove((Communication)result.Data);
            unitOfWork.Commit();
            return Result.GetSuccess("Deleted");
        }

        public Result GetById(Guid id)
        {
            var communication = unitOfWork.Communications.GetById(id);
            return Result.GetSuccess("Was Found", communication);
        }
    }
}
