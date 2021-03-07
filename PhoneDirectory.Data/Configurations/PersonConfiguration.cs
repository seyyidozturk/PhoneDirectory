using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PhoneDirectory.Data.Entities;

namespace PhoneDirectory.Data.Configurations
{
    public class PersonConfiguration : BaseEntityTypeConfiguration<Person>
    {
        public override void OnConfigure(EntityTypeBuilder<Person> builder)
        {
            builder.Property(p => p.Name)
                .IsRequired()
                .HasMaxLength(100);

            builder.Property(p => p.Surname)
                .IsRequired()
                .HasMaxLength(100);
        }
    }
}
