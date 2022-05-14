using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoList
{
    public interface ITask
    {
        /// <summary>
        /// Gets the name of the task
        /// </summary>
        string TaskName { get; set; }

        /// <summary>
        /// Gets or sets the completed status
        /// </summary>
        bool Completed { get; set; }

        /// <summary>
        /// Type of task for this task
        /// </summary>
        TypeOfTasks typeOfTasks { get; set; }

        /// <summary>
        /// Method to change the status
        /// </summary>
        /// <param name="completed">Status that it needs to change to</param>
        void ChangeStatus(string completed);

        /// <summary>
        /// Method to change the type of tasks
        /// </summary>
        /// <returns></returns>
        void ChangeType(TypeOfTasks typeOfTasks);

    }
}
