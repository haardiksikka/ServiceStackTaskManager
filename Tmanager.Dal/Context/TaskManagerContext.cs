using System;
using System.Collections.Generic;
using System.Text;
using System.Data.Entity;
using Tmanager.Dal.Model;
{


namespace Tmanager.Dal.Context
{
   public class TaskManagerContext : DbContext
    {
        public TaskManagerContext() : base("TaskManagerContext")
        {
        }
        public DbSet<User> Users { get; set; }
        public DbSet<Task> Tasks { get; set; }
        public DbSet<Category> Categories { get; set; }
    }
}
