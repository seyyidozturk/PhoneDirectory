using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PhoneDirectory.Data.Entities;

namespace PhoneDirectory.Data.Configurations
{
    public abstract class BaseEntityTypeConfiguration<T> : IEntityTypeConfiguration<T> where T : BaseEntity
    {
        public void Configure(EntityTypeBuilder<T> builder)
        {
            builder
                .HasKey(b => b.Id);
            builder
                .Property(b => b.Id)
                .ValueGeneratedOnAdd();
            builder
                .Property(b => b.CreatedOn)
                .IsRequired();

            //builder
            //    .HasIndex(x => x.Id)
            //    .HasName("asdasd")
            //    .IsUnique();

            OnConfigure(builder);
        }

        public abstract void OnConfigure(EntityTypeBuilder<T> builder);
    }
}
