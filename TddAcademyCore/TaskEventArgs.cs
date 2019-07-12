using System;

namespace TddAcademy
{
    public class TaskEventArgs : EventArgs
    {
        public TaskEventArgs(string task)
        {
            this.Task = task;
        }

        public string Task { get; }
    }
}