namespace TaskManager.DAL.Context
{
    using System.Data.Entity.ModelConfiguration;
    using TaskManager.DAL.Model;


    public class TaskConfiguration : EntityTypeConfiguration<Task>
    {
        public TaskConfiguration()
        {
            this.Property(t => t.UserStory)
            .IsRequired()
            .HasMaxLength(50);

            this.HasKey(t => t.TaskId);

            this.Property(t => t.TimeLogged)          
           .IsRequired();

            this.Property(t => t.AllocatedTime)          
           .IsRequired();

            this.Property(t => t.Email)              
               .IsRequired();
        }
    }
}
