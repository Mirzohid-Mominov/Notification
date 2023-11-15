using Microsoft.EntityFrameworkCore;
using Notification.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Notification.Persistence.DataContexts
{
    public class NotificationDbContext : DbContext
    {
        public DbSet<SmsTemplate> SmsTemplates => Set<SmsTemplate>();

        public DbSet<EmailTemplate> EmailTemplates => Set<EmailTemplate>();

        public DbSet<SmsHistory> SmsHistories => Set<SmsHistory>();

        public DbSet<EmailHistory> EmailHistories => Set<EmailHistory>();

        public NotificationDbContext(DbContextOptions<NotificationDbContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(NotificationDbContext).Assembly);
        }
    }
}
