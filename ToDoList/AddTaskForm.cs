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
    public partial class AddTaskForm : MetroForm
    {
        public IUser user { get; set; }
        public string taskName { get; set; }
        public TypeOfTasks typeOfTasks { get; set; }
        public AddTaskForm(IUser user)
        {
            this.user = user;
            InitializeComponent();
            uxPriorityComboBox.DataSource = Enum.GetValues(typeof(TypeOfTasks));

        }

        private void uxAddTaskButton_Click(object sender, EventArgs e)
        {
            taskName = uxTaskNameTextBox.Text;
            typeOfTasks = (TypeOfTasks)uxPriorityComboBox.SelectedItem;
        }

        private void uxCancelButton_Click(object sender, EventArgs e)
        {
            
        }
    }


}

