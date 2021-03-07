namespace PhoneDirectory.Business.Services
{
    public class BaseService
    {
        public BaseService(IUnitOfWork _unitOfWork)
        {
            UnitOfWork = _unitOfWork;
        }

        public IUnitOfWork UnitOfWork { get; }
    }
}
