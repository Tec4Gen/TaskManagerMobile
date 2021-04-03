using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SSU.TaskManager.Models.Entities;

namespace SSU.TaskManager
{
    public class TaskConfiguration : IEntityTypeConfiguration<Task>
    {
        public void Configure(EntityTypeBuilder<Task> builder)
        {
            builder
                .HasKey(p => p.Id);

            builder
                .Property(p => p.Title)
                .IsRequired()
                .HasMaxLength(200);

            builder
                .Property(p => p.Description)
                .IsRequired()
                .HasMaxLength(300);

            builder
                .Property(p => p.DeadLine)
                .IsRequired()
                .HasMaxLength(200);

            builder
                .HasOne(t=>t.Board)
                .WithMany(b=>b.Tasks)
                .HasForeignKey(p=>p.BoardId);

            builder
                .HasOne(t => t.Group)
                .WithMany(b => b.Tasks)
                .HasForeignKey(p => p.GroupId);

            builder
                .ToTable("Task");
        }
    }
}