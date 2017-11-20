using Application.DomainClasses.Classes;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Application.Infrastructure.EntityConfigurations
{
    public class ViewCheckClassConfiguration : IEntityTypeConfiguration<ViewCheck>
    {
        public void Configure(EntityTypeBuilder<ViewCheck> builder)
        {
            builder.HasKey(u => u.ViewCheckId);

            builder.Property(u => u.ViewController).IsRequired();
            builder.Property(u => u.ActionName).IsRequired();
            builder.Property(u => u.ViewName).IsRequired();
        }
    }
}