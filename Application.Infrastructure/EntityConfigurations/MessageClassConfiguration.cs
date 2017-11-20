using Application.DomainClasses.Classes;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Application.Infrastructure.EntityConfigurations
{
    public class MessageClassConfiguration : IEntityTypeConfiguration<Message>
    {
        public void Configure(EntityTypeBuilder<Message> builder)
        {
            builder.HasKey(u => u.MessageId);

            builder.Property(u => u.MessageContent).HasMaxLength(500);
            builder.Property(u => u.MessageContent).IsRequired();

            builder.Property(u => u.MessageCreatedOn).HasColumnType("datetime");
            builder.Property(u => u.MessageCreatedOn).IsRequired();

            builder.Property(u => u.MessageForUserId).IsRequired();
            builder.Property(u => u.MessageFromUserId).IsRequired();

            builder.HasOne(u => u.MessageForUser)
                .WithMany(v => v.UserMessages)
                .HasForeignKey(u => u.MessageForUserId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(u => u.MessageFromUser)
                .WithMany(v => v.SentMessages)
                .HasForeignKey(u => u.MessageFromUserId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}