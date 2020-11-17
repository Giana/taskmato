using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Taskmato.Models
{
    public class TaskList
    {
        public int ID { get; set; }
        public DateTime Date { get; set; }
        public List<Task> Tasks { get; set; }

        public void AddTask(Task task)
        {
            // Steven's code
        }

        public void DeleteTask(Task task)
        {
            // Mason's code
        }
    }
}