using System;
using static PhoneDirectory.Data.Enums.CommunicationEnum;

namespace PhoneDirectory.Data.Entities
{
    public class Communication : BaseEntity
    {
        public InformationType InformationType { get; set; }
        public string Content { get; set; }

        public Guid? PersonId { get; set; }
        public virtual Person Person { get; set; }
    }
}
