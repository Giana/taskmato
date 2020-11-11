using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Taskmato.Models
{
    public class Task
    {
        private string Name;
        private string Details;
        private int Pomodoros;
        private bool Complete;

        public string GetName() { return Name; }

        public void SetName(string name) { Name = name; }

        public string GetDetails() { return Details; }

        public void SetDetails(string details) { Details = details; }

        public int GetPomodoros() { return Pomodoros; }

        public void SetPomodoros(int pomodoros) { Pomodoros = pomodoros; }

        public bool GetComplete() { return Complete; }

        public void SetComplete(bool complete) { Complete = complete; }

        public void IncrementPomodoros()
        {
            // Samantha's code
        }
    }
}