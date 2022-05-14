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
    public delegate IUser LoginDel(string username, string password);
    public delegate void LogoutDel(IUser user);
    public partial class LoginForm : MetroForm
    {


        private LoginDel LoginDelegate;
        private LogoutDel LogoutDelegate;
        public LoginForm()
        {
            InitializeComponent();
        }

        public void SetUp(LoginDel LoginDelegate, LogoutDel LogoutDelegate)
        {
            this.LoginDelegate = LoginDelegate;
            this.LogoutDelegate = LogoutDelegate;
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void uxLoginButton_Click(object sender, EventArgs e)
        {
            string username = uxUsernameTextBox.Text;
            string password = uxPasswordTextBox.Text;

            User user = (User)LoginDelegate(username, password);
            TaskList form = new TaskList(user, LogoutDelegate);
            form.ShowDialog();

        }

        private void uxCancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
