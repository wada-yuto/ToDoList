using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace ToDoList
{
    public interface IUser
    {
        /// <summary>
        /// Username
        /// </summary>
        string Username { get; set; }

        /// <summary>
        /// Password
        /// </summary>
        string Password { get; set; }


        /// <summary>
        /// Boolean representing if all tasks are completed or not
        /// </summary>
        bool AllCompleted { get; set; }

        /// <summary>
        /// Status of the user
        /// </summary>
        string Status { get; set; }



        /// <summary>
        /// Method to check to see if all tasks are completed
        /// </summary>
        /// <param name="ToDoList">List of tasks</param>
        void CheckToDoListForCompletion(BindingList<ITask> ToDoList);


    }
}
