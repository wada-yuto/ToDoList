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
    public partial class ChangePriorityForm : MetroForm
    {

        public IUser user { get; set; }
        public string taskName { get; set; }
        public TypeOfTasks typeOfTasks { get; set; }
        private Task task { get; set; }
        public ChangePriorityForm(IUser user, Task task)
        {
            this.user = user;
            this.task = task;
            InitializeComponent();
            uxPriorityComboBox.DataSource = Enum.GetValues(typeof(TypeOfTasks));
        }

        private void uxChangeButton_Click(object sender, EventArgs e)
        {
            typeOfTasks = (TypeOfTasks)uxPriorityComboBox.SelectedItem;
            task.typeOfTasks = typeOfTasks;
        }
    }
}
