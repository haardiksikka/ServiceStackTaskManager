using System;
using System.Collections.Generic;

namespace Tmanager.Dal.Model
{
    public class User
    {

        public int UserId { get; set; }

        public string FirstName { get; set; }

        public string Lastname { get; set; }

        public string Email { get; set; }

        public string Password { get; set; }

        public string Salt { get; set; }

        public ICollection<Task> Tasks { get; set; }

    }
}
