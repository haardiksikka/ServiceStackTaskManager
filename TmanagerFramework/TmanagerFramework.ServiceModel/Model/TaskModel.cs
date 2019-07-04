using System;
using ServiceStack.DataAnnotations;

namespace Tmanager.ServiceModel.Model
{
    public class TaskModel
    {
        public string Email { get; set; }

        public int TaskId { get; set; }
       
        public string UserStory { get; set; }
       
        public int TimeLogged { get; set; }
       
        public int AllocatedTime { get; set; }
       
        public string TaskDomain { get; set; }
      
        public DateTime CreatedOn { get; set; }

        public int UserId { get; set; }

        public int CategoryId { get; set; }
    }
}
