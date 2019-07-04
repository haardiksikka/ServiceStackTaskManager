using System;
using System.Collections.Generic;
using System.Text;

namespace Tmanager.Common.DTO
{
    public class TaskDto
    {
        public string Email { get; set; }
        public int TaskId { get; set; }

        public string UserStory { get; set; }

        public int TimeLogged { get; set; }

        public int AllocatedTime { get; set; }

        public string TaskDomain { get; set; }

        public DateTime DateTime { get; set; }

        public int UserId { get; set; }

        public int CategoryId { get; set; }
    }
}
