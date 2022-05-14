
namespace ToDoList
{
    partial class AddTaskForm
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
            this.uxTaskNameLabel = new MetroFramework.Controls.MetroLabel();
            this.uxAddTaskButton = new MetroFramework.Controls.MetroButton();
            this.uxTaskNameTextBox = new MetroFramework.Controls.MetroTextBox();
            this.Priority = new MetroFramework.Controls.MetroLabel();
            this.uxCancelButton = new MetroFramework.Controls.MetroButton();
            this.uxPriorityComboBox = new MetroFramework.Controls.MetroComboBox();
            this.SuspendLayout();
            // 
            // uxTaskNameLabel
            // 
            this.uxTaskNameLabel.AutoSize = true;
            this.uxTaskNameLabel.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.uxTaskNameLabel.Location = new System.Drawing.Point(23, 64);
            this.uxTaskNameLabel.Name = "uxTaskNameLabel";
            this.uxTaskNameLabel.Size = new System.Drawing.Size(93, 25);
            this.uxTaskNameLabel.TabIndex = 0;
            this.uxTaskNameLabel.Text = "Task Name";
            // 
            // uxAddTaskButton
            // 
            this.uxAddTaskButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.uxAddTaskButton.DisplayFocus = true;
            this.uxAddTaskButton.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.uxAddTaskButton.Location = new System.Drawing.Point(24, 154);
            this.uxAddTaskButton.Name = "uxAddTaskButton";
            this.uxAddTaskButton.Size = new System.Drawing.Size(154, 23);
            this.uxAddTaskButton.TabIndex = 1;
            this.uxAddTaskButton.Text = "Add";
            this.uxAddTaskButton.UseSelectable = true;
            this.uxAddTaskButton.Click += new System.EventHandler(this.uxAddTaskButton_Click);
            // 
            // uxTaskNameTextBox
            // 
            // 
            // 
            // 
            this.uxTaskNameTextBox.CustomButton.Image = null;
            this.uxTaskNameTextBox.CustomButton.Location = new System.Drawing.Point(132, 1);
            this.uxTaskNameTextBox.CustomButton.Name = "";
            this.uxTaskNameTextBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.uxTaskNameTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.uxTaskNameTextBox.CustomButton.TabIndex = 1;
            this.uxTaskNameTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.uxTaskNameTextBox.CustomButton.UseSelectable = true;
            this.uxTaskNameTextBox.CustomButton.Visible = false;
            this.uxTaskNameTextBox.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.uxTaskNameTextBox.Lines = new string[0];
            this.uxTaskNameTextBox.Location = new System.Drawing.Point(24, 107);
            this.uxTaskNameTextBox.MaxLength = 32767;
            this.uxTaskNameTextBox.Name = "uxTaskNameTextBox";
            this.uxTaskNameTextBox.PasswordChar = '\0';
            this.uxTaskNameTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.uxTaskNameTextBox.SelectedText = "";
            this.uxTaskNameTextBox.SelectionLength = 0;
            this.uxTaskNameTextBox.SelectionStart = 0;
            this.uxTaskNameTextBox.ShortcutsEnabled = true;
            this.uxTaskNameTextBox.Size = new System.Drawing.Size(154, 23);
            this.uxTaskNameTextBox.TabIndex = 2;
            this.uxTaskNameTextBox.UseSelectable = true;
            this.uxTaskNameTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.uxTaskNameTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // Priority
            // 
            this.Priority.AutoSize = true;
            this.Priority.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.Priority.Location = new System.Drawing.Point(218, 64);
            this.Priority.Name = "Priority";
            this.Priority.Size = new System.Drawing.Size(65, 25);
            this.Priority.TabIndex = 3;
            this.Priority.Text = "Priority";
            // 
            // uxCancelButton
            // 
            this.uxCancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.uxCancelButton.DisplayFocus = true;
            this.uxCancelButton.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.uxCancelButton.Location = new System.Drawing.Point(218, 154);
            this.uxCancelButton.Name = "uxCancelButton";
            this.uxCancelButton.Size = new System.Drawing.Size(154, 23);
            this.uxCancelButton.TabIndex = 5;
            this.uxCancelButton.Text = "Cancel";
            this.uxCancelButton.UseSelectable = true;
            this.uxCancelButton.Click += new System.EventHandler(this.uxCancelButton_Click);
            // 
            // uxPriorityComboBox
            // 
            this.uxPriorityComboBox.FormattingEnabled = true;
            this.uxPriorityComboBox.ItemHeight = 23;
            this.uxPriorityComboBox.Location = new System.Drawing.Point(218, 107);
            this.uxPriorityComboBox.Name = "uxPriorityComboBox";
            this.uxPriorityComboBox.Size = new System.Drawing.Size(154, 29);
            this.uxPriorityComboBox.TabIndex = 6;
            this.uxPriorityComboBox.UseSelectable = true;
            // 
            // AddTaskForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(422, 225);
            this.Controls.Add(this.uxPriorityComboBox);
            this.Controls.Add(this.uxCancelButton);
            this.Controls.Add(this.Priority);
            this.Controls.Add(this.uxTaskNameTextBox);
            this.Controls.Add(this.uxAddTaskButton);
            this.Controls.Add(this.uxTaskNameLabel);
            this.Name = "AddTaskForm";
            this.Text = "AddTaskForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel uxTaskNameLabel;
        private MetroFramework.Controls.MetroButton uxAddTaskButton;
        private MetroFramework.Controls.MetroTextBox uxTaskNameTextBox;
        private MetroFramework.Controls.MetroLabel Priority;
        private MetroFramework.Controls.MetroButton uxCancelButton;
        private MetroFramework.Controls.MetroComboBox uxPriorityComboBox;
    }
}