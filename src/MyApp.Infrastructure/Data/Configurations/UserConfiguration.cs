using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MyApp.Domain.Entities;

namespace MyApp.Infrastructure.Data.Configurations
{
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.ToTable("Users");

            builder.HasKey(u => u.Id);

            builder.Property(u => u.FirstName).IsRequired().HasMaxLength(100);
            builder.Property(u => u.LastName).IsRequired().HasMaxLength(100);
            builder.Property(u => u.EmailId).IsRequired().HasMaxLength(255);
            builder.Property(u => u.Password).IsRequired();
            builder.Property(u => u.Status).IsRequired();

            builder.Property(u => u.CreatedOn).IsRequired();
            builder.Property(u => u.IsDeleted).IsRequired();
        }
    }
}
