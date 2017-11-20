using Application.DomainClasses.Classes;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Application.Infrastructure.EntityConfigurations
{
    public class ApplicationUserClassConfiguration : IEntityTypeConfiguration<ApplicationUser>
    {
        public void Configure(EntityTypeBuilder<ApplicationUser> builder)
        {
            builder.Property(u => u.FirstName).HasMaxLength(31);
            builder.Property(u => u.FirstName).IsRequired();

            builder.Property(u => u.LastName).HasMaxLength(55);
            builder.Property(u => u.LastName).IsRequired();

            builder.Property(u => u.DateOfBirth).HasColumnType("datetime");
            builder.Property(u => u.DateOfBirth).IsRequired();

            builder.Property(u => u.Gender).IsRequired();

            //Set properties as migration created them
            builder.HasMany(u => u.UserMessages);
            builder.HasMany(u => u.SentMessages);

            //builder.HasOne(u => u.M)
            //builder.HasIndex(u => u.UserMessages.)
            //    .IsUnique()
            //    .HasName("MyIndexName");
        }
    }
}