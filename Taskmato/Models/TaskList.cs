using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Taskmato.Models
{
    public class TaskList
    {
        private DateTime Date;
        private List<Task> Tasks;

        public DateTime GetDate() { return Date; }

        public void SetDate(DateTime date) { Date = date; }

        public List<Task> GetTasks() { return Tasks; }

        public void SetTasks(List<Task> tasks) { Tasks = tasks; }

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