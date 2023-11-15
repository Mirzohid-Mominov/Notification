using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Notification.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Notification.Persistence.EntityConfigurations
{
    public class EmailHistoryConfigurations : IEntityTypeConfiguration<EmailHistory>
    {
        public void Configure(EntityTypeBuilder<EmailHistory> builder)
        {
            builder.Property(template => template.SendEmailAddres).IsRequired().HasMaxLength(256);
            builder.Property(template => template.ReceiverEmailAddress).IsRequired().HasMaxLength(256);
            builder.Property(template => template.Subject).IsRequired().HasMaxLength(256);
        }
    }
}
