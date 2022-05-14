using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;

namespace ToDoList
{
    public partial class TaskList : MetroForm
    {
        private LogoutDel LogoutDelegate;
        private User user;

        public TaskList(User user, LogoutDel LogoutDelegate)
        {
            this.user = user;
            this.LogoutDelegate = LogoutDelegate;
            InitializeComponent();
            uxUserTasksLabel.Text = user.Username + "'s Tasks";
            uxTaskListListBox.DataSource = null;
            uxTaskListListBox.DataSource = user.ToDoList;
        }

        private void uxAddTaskButton_Click(object sender, EventArgs e)
        {
            AddTaskForm form = new AddTaskForm(this.user);
            var result = form.ShowDialog();
            if(result == DialogResult.OK)
            {
                string taskName = form.taskName;
                TypeOfTasks typeOfTask = form.typeOfTasks;

                Task task = new Task(taskName, typeOfTask);
                user.ToDoList.Add(task);
            }
            if(result == DialogResult.Cancel)
            {
                form.Close();
            }
            uxTaskListListBox.DataSource = null;
            uxTaskListListBox.DataSource = this.user.ToDoList;

        }

        private void TaskList_Load(object sender, EventArgs e)
        {

        }

        private void uxLogOutButton_Click(object sender, EventArgs e)
        {
            IUser user = this.user;
            LogoutDelegate(user);
            this.Close();
        }

        private void uxRemoveButton_Click(object sender, EventArgs e)
        {
            Task task = (Task)uxTaskListListBox.SelectedItem;
            this.user.ToDoList.Remove(task);
            uxTaskListListBox.DataSource = null;
            uxTaskListListBox.DataSource = this.user.ToDoList;
        }

        private void uxChangePriorityButton_Click(object sender, EventArgs e)
        {
            ChangePriorityForm form = new ChangePriorityForm(this.user, (Task)uxTaskListListBox.SelectedItem);
            var result = form.ShowDialog();

            if (result == DialogResult.OK)
            {
                //MessageBox.Show("Priority changed");
                form.Close();
            }
            if (result == DialogResult.Cancel)
            {
                form.Close();
            }
            uxTaskListListBox.DataSource = null;
            uxTaskListListBox.DataSource = this.user.ToDoList;
        }
    }
}
