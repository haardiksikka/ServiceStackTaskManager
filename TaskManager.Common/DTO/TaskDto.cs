namespace TaskManager.Common.DTO
{
    using System;

    public class TaskDto
    {
        public string Email { get; set; }
        public int TaskId { get; set; }

        public string UserStory { get; set; }

        public int TimeLogged { get; set; }

        public int AllocatedTime { get; set; }

        public string TaskDomain { get; set; }

        public DateTime CreatedOn { get; set; } = DateTime.Now;

        public int UserId { get; set; }

        public int CategoryId { get; set; }

        public CategoryDto TaskCategory { get; set; }
    }
}
