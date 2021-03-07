using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PhoneDirectory.Data.Entities;

namespace PhoneDirectory.Data.Configurations
{
    public class CommunicationConfiguration : BaseEntityTypeConfiguration<Communication>
    {
        public override void OnConfigure(EntityTypeBuilder<Communication> builder)
        {
            builder
                .Property(c => c.InformationType)
                .IsRequired()
                .HasConversion<int>();
        }
    }
}
