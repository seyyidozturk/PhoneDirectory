using PhoneDirectory.Data;
using PhoneDirectory.Data.Entities;

namespace PhoneDirectory.Business.Repositories
{
    public class CommunicationRepository : Repository<Communication>, ICommunicationRepository
    {
        public CommunicationRepository(PhoneDirectoryContext context) : base(context)
        {

        }
    }
}
