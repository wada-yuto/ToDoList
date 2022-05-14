using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoList
{
    public class User : IUser
    {
        /// <summary>
        /// Username
        /// </summary>
        public string Username { get; set; }

        /// <summary>
        /// Password
        /// </summary>
        public string Password { get; set; }

        /// <summary>
        /// Checks to see if all tasks are completed
        /// </summary>
        public bool AllCompleted { get; set; }

        /// <summary>
        /// Status of the user
        /// </summary>
        public string Status { get; set; }

        /// <summary>
        /// List of tasks
        /// </summary>
        public BindingList<Task> ToDoList = new BindingList<Task>();

        /// <summary>
        /// Constructor for the User
        /// </summary>
        /// <param name="username">username of the user</param>
        /// <param name="password">password for the user</param>
        public User(string username, string password)
        {
            this.Username = username;
            this.Password = password;
            this.Status = "Online";
            
        }
        /// <summary>
        /// Method to check to see if all tasks are completed
        /// </summary>
        /// <param name="ToDoList">List of tasks</param>
        public void CheckToDoListForCompletion(BindingList<ITask> ToDoList)
        {

        }
    }
}
