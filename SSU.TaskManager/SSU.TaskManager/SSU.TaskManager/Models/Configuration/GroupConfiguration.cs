using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SSU.TaskManager.Entities;

namespace SSU.TaskManager
{
    public class GroupConfiguration : IEntityTypeConfiguration<Group>
    {
        public void Configure(EntityTypeBuilder<Group> builder)
        {
            builder
                .HasKey(p=>p.Id);

            builder
                .Property(p => p.Title)
                .IsRequired()
                .HasMaxLength(200);

            builder
                .ToTable("Group");
        }
    }
}