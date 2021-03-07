using System.Collections.Generic;

namespace PhoneDirectory.Data.Entities
{
    public class Person : BaseEntity
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Company { get; set; }

        public virtual List<Communication> Communications{ get; set; }
    }
}
