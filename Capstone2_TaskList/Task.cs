using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capstone2_TaskList
{
    class Task
    {
        public string TaskOwner { get; set; }
        public string TaskName { get; set; }
        public DateTime DueDate { get; set; }
        public bool Completed { get; set; }

        public Task(string taskOwner, string taskName, DateTime dueDate)
        {
            TaskOwner = taskOwner;
            TaskName = taskName;
            DueDate = dueDate;
            Completed = false;
        }
    }
}
