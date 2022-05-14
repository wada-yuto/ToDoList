
namespace ToDoList
{
    partial class LoginForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.uxUsernameLabel = new MetroFramework.Controls.MetroLabel();
            this.uxUsernameTextBox = new MetroFramework.Controls.MetroTextBox();
            this.uxPasswordLabel = new MetroFramework.Controls.MetroLabel();
            this.uxPasswordTextBox = new MetroFramework.Controls.MetroTextBox();
            this.uxLoginButton = new MetroFramework.Controls.MetroButton();
            this.uxCancelButton = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // uxUsernameLabel
            // 
            this.uxUsernameLabel.AutoSize = true;
            this.uxUsernameLabel.Location = new System.Drawing.Point(24, 64);
            this.uxUsernameLabel.Name = "uxUsernameLabel";
            this.uxUsernameLabel.Size = new System.Drawing.Size(68, 19);
            this.uxUsernameLabel.TabIndex = 0;
            this.uxUsernameLabel.Text = "Username";
            // 
            // uxUsernameTextBox
            // 
            // 
            // 
            // 
            this.uxUsernameTextBox.CustomButton.Image = null;
            this.uxUsernameTextBox.CustomButton.Location = new System.Drawing.Point(182, 1);
            this.uxUsernameTextBox.CustomButton.Name = "";
            this.uxUsernameTextBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.uxUsernameTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.uxUsernameTextBox.CustomButton.TabIndex = 1;
            this.uxUsernameTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.uxUsernameTextBox.CustomButton.UseSelectable = true;
            this.uxUsernameTextBox.CustomButton.Visible = false;
            this.uxUsernameTextBox.Lines = new string[0];
            this.uxUsernameTextBox.Location = new System.Drawing.Point(24, 87);
            this.uxUsernameTextBox.MaxLength = 32767;
            this.uxUsernameTextBox.Name = "uxUsernameTextBox";
            this.uxUsernameTextBox.PasswordChar = '\0';
            this.uxUsernameTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.uxUsernameTextBox.SelectedText = "";
            this.uxUsernameTextBox.SelectionLength = 0;
            this.uxUsernameTextBox.SelectionStart = 0;
            this.uxUsernameTextBox.ShortcutsEnabled = true;
            this.uxUsernameTextBox.Size = new System.Drawing.Size(204, 23);
            this.uxUsernameTextBox.TabIndex = 1;
            this.uxUsernameTextBox.UseSelectable = true;
            this.uxUsernameTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.uxUsernameTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // uxPasswordLabel
            // 
            this.uxPasswordLabel.AutoSize = true;
            this.uxPasswordLabel.Location = new System.Drawing.Point(24, 161);
            this.uxPasswordLabel.Name = "uxPasswordLabel";
            this.uxPasswordLabel.Size = new System.Drawing.Size(63, 19);
            this.uxPasswordLabel.TabIndex = 2;
            this.uxPasswordLabel.Text = "Password";
            // 
            // uxPasswordTextBox
            // 
            // 
            // 
            // 
            this.uxPasswordTextBox.CustomButton.Image = null;
            this.uxPasswordTextBox.CustomButton.Location = new System.Drawing.Point(182, 1);
            this.uxPasswordTextBox.CustomButton.Name = "";
            this.uxPasswordTextBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.uxPasswordTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.uxPasswordTextBox.CustomButton.TabIndex = 1;
            this.uxPasswordTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.uxPasswordTextBox.CustomButton.UseSelectable = true;
            this.uxPasswordTextBox.CustomButton.Visible = false;
            this.uxPasswordTextBox.Lines = new string[0];
            this.uxPasswordTextBox.Location = new System.Drawing.Point(24, 183);
            this.uxPasswordTextBox.MaxLength = 32767;
            this.uxPasswordTextBox.Name = "uxPasswordTextBox";
            this.uxPasswordTextBox.PasswordChar = '\0';
            this.uxPasswordTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.uxPasswordTextBox.SelectedText = "";
            this.uxPasswordTextBox.SelectionLength = 0;
            this.uxPasswordTextBox.SelectionStart = 0;
            this.uxPasswordTextBox.ShortcutsEnabled = true;
            this.uxPasswordTextBox.Size = new System.Drawing.Size(204, 23);
            this.uxPasswordTextBox.TabIndex = 3;
            this.uxPasswordTextBox.UseSelectable = true;
            this.uxPasswordTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.uxPasswordTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // uxLoginButton
            // 
            this.uxLoginButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.uxLoginButton.Location = new System.Drawing.Point(24, 267);
            this.uxLoginButton.Name = "uxLoginButton";
            this.uxLoginButton.Size = new System.Drawing.Size(75, 39);
            this.uxLoginButton.TabIndex = 4;
            this.uxLoginButton.Text = "Log In";
            this.uxLoginButton.UseSelectable = true;
            this.uxLoginButton.Click += new System.EventHandler(this.uxLoginButton_Click);
            // 
            // uxCancelButton
            // 
            this.uxCancelButton.Location = new System.Drawing.Point(153, 267);
            this.uxCancelButton.Name = "uxCancelButton";
            this.uxCancelButton.Size = new System.Drawing.Size(75, 39);
            this.uxCancelButton.TabIndex = 5;
            this.uxCancelButton.Text = "Cancel";
            this.uxCancelButton.UseSelectable = true;
            this.uxCancelButton.Click += new System.EventHandler(this.uxCancelButton_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(251, 329);
            this.Controls.Add(this.uxCancelButton);
            this.Controls.Add(this.uxLoginButton);
            this.Controls.Add(this.uxPasswordTextBox);
            this.Controls.Add(this.uxPasswordLabel);
            this.Controls.Add(this.uxUsernameTextBox);
            this.Controls.Add(this.uxUsernameLabel);
            this.Name = "LoginForm";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel uxUsernameLabel;
        private MetroFramework.Controls.MetroTextBox uxUsernameTextBox;
        private MetroFramework.Controls.MetroLabel uxPasswordLabel;
        private MetroFramework.Controls.MetroTextBox uxPasswordTextBox;
        private MetroFramework.Controls.MetroButton uxLoginButton;
        private MetroFramework.Controls.MetroButton uxCancelButton;
    }
}

