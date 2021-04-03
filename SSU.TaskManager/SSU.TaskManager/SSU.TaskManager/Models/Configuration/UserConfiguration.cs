using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SSU.TaskManager.Models.Entities;

namespace SSU.TaskManager
{
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder
                .HasKey(p => p.Id);

            builder
                .Property(p => p.FirstName)
                .IsRequired()
                .HasMaxLength(200);

            builder
                .Property(p => p.LastName)
                .IsRequired()
                .HasMaxLength(200);

            builder
                .HasOne(g => g.Group)
                .WithMany(t => t.Users)
                .HasForeignKey(p => p.GroupId);

            builder
                .HasOne(g => g.Role)
                .WithMany(t => t.Users)
                .HasForeignKey(p => p.RoleId);

            builder
                .ToTable("User");
        }
    }
}