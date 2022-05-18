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
