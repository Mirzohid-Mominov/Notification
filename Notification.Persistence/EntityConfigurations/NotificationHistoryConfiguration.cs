using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Notification.Domain.Entities;
using Notification.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Notification.Persistence.EntityConfigurations
{
    public class NotificationHistoryConfiguration : IEntityTypeConfiguration<NotificationHistory>
    {
        public void Configure(EntityTypeBuilder<NotificationHistory> builder)
        {
            builder.Property(template => template.Content).HasMaxLength(129_536);

            builder.ToTable("Notificationhistories")
                .HasDiscriminator(history => history.Type)
                .HasValue<EmailHistory>(NotificationType.Email)
                .HasValue<SmsHistory>(NotificationType.Sms);

            builder.HasOne<NotificationTemplate>(history => history.Template)
                .WithMany(template => template.Histories)
                .HasForeignKey(template => template.TemplateId);
        }
    }
}
