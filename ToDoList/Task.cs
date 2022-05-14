using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoList
{
    public class Task : ITask
    {
        public string TaskName { get; set; }
        public bool Completed { get; set; }
        public TypeOfTasks typeOfTasks { get; set; }

        public Task(string TaskName, TypeOfTasks typeOfTasks)
        {
            this.TaskName = TaskName;
            this.typeOfTasks = typeOfTasks;
        }

        public void ChangeStatus(string completed)
        {
            if(completed == "Completed")
            {
                Completed = true;
            }
            else
            {
                Completed = false;
            }
        }

        public void ChangeType(TypeOfTasks typeOfTask)
        {
            this.typeOfTasks = typeOfTask;
        }

        public override string ToString()
        {
            return TaskName + ": "+ typeOfTasks.ToString();
        }
    }
}
