namespace TaskManager.DAL.Context
{
    using System.Data.Entity;
    using TaskManager.DAL.Configuration;
    using TaskManager.DAL.Model;

    public class TaskManagerContext : DbContext
    {
        public TaskManagerContext() : base("TaskManagerContext")
        {
        }
        public DbSet<User> Users { get; set; }
        public DbSet<Task> Tasks { get; set; }
        public DbSet<Category> Category { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //Configure Column
            modelBuilder.Configurations.Add(new UserConfiguration());
            modelBuilder.Configurations.Add(new TaskConfiguration());
            modelBuilder.Entity<Task>()
                        .Property(p => p.CreatedOn)
                        .HasColumnType("datetime2");
        }
    }
}
