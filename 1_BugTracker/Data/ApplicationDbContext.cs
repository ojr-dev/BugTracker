using _1_BugTracker.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace _1_BugTracker.Data
{
    public class ApplicationDbContext : IdentityDbContext<BT_User>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        //dbset maps classes to table, data that moves in and out of database goes through this
        public DbSet<Company> Companies { get; set; }
        public DbSet<Invite> Invites { get; set; }
        public DbSet<Notification> Notifications { get; set; }
        public DbSet<NotificationStatus> NotificationStatuses { get; set; }
        public DbSet<Project> Projects { get; set; }
        public DbSet<ProjectPriority> ProjectPriorities { get; set; }
        public DbSet<Ticket> Tickets { get; set; }
        public DbSet<TicketAttachment> TicketAttachments { get; set; }
        public DbSet<TicketComment> TicketComments { get; set; }
        public DbSet<TicketHistory> TicketHistories { get; set; }
        public DbSet<TicketPriority> TicketPriorities { get; set; }
        public DbSet<TicketStatus> TicketStatuses { get; set; }
        public DbSet<TicketType> TicketTypes { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.ApplyConfiguration(new ApplicationUserEntityConfiguration());
        }

    }
}
public class ApplicationUserEntityConfiguration : IEntityTypeConfiguration<BT_User>
{
    public void Configure(EntityTypeBuilder<BT_User> builder)
    {
        builder.Property(u => u.FirstName).HasMaxLength(60);
        builder.Property(u => u.LastName).HasMaxLength(60);
  
    }
}
