
namespace ToDoList
{
    partial class TaskList
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
            this.uxAddTaskButton = new MetroFramework.Controls.MetroButton();
            this.uxRemoveButton = new MetroFramework.Controls.MetroButton();
            this.uxChangePriorityButton = new MetroFramework.Controls.MetroButton();
            this.uxLogOutButton = new MetroFramework.Controls.MetroButton();
            this.uxUserTasksLabel = new MetroFramework.Controls.MetroLabel();
            this.metroTile1 = new MetroFramework.Controls.MetroTile();
            this.uxTaskListListBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // uxAddTaskButton
            // 
            this.uxAddTaskButton.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.uxAddTaskButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.uxAddTaskButton.Location = new System.Drawing.Point(376, 82);
            this.uxAddTaskButton.Name = "uxAddTaskButton";
            this.uxAddTaskButton.Size = new System.Drawing.Size(177, 48);
            this.uxAddTaskButton.TabIndex = 1;
            this.uxAddTaskButton.Text = "Add";
            this.uxAddTaskButton.UseSelectable = true;
            this.uxAddTaskButton.Click += new System.EventHandler(this.uxAddTaskButton_Click);
            // 
            // uxRemoveButton
            // 
            this.uxRemoveButton.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.uxRemoveButton.Location = new System.Drawing.Point(376, 163);
            this.uxRemoveButton.Name = "uxRemoveButton";
            this.uxRemoveButton.Size = new System.Drawing.Size(177, 48);
            this.uxRemoveButton.TabIndex = 2;
            this.uxRemoveButton.Text = "Remove";
            this.uxRemoveButton.UseSelectable = true;
            this.uxRemoveButton.Click += new System.EventHandler(this.uxRemoveButton_Click);
            // 
            // uxChangePriorityButton
            // 
            this.uxChangePriorityButton.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.uxChangePriorityButton.Location = new System.Drawing.Point(376, 243);
            this.uxChangePriorityButton.Name = "uxChangePriorityButton";
            this.uxChangePriorityButton.Size = new System.Drawing.Size(177, 48);
            this.uxChangePriorityButton.TabIndex = 3;
            this.uxChangePriorityButton.Text = "Change Priority";
            this.uxChangePriorityButton.UseSelectable = true;
            this.uxChangePriorityButton.Click += new System.EventHandler(this.uxChangePriorityButton_Click);
            // 
            // uxLogOutButton
            // 
            this.uxLogOutButton.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.uxLogOutButton.Location = new System.Drawing.Point(376, 454);
            this.uxLogOutButton.Name = "uxLogOutButton";
            this.uxLogOutButton.Size = new System.Drawing.Size(177, 48);
            this.uxLogOutButton.TabIndex = 4;
            this.uxLogOutButton.Text = "Log out";
            this.uxLogOutButton.UseSelectable = true;
            this.uxLogOutButton.Click += new System.EventHandler(this.uxLogOutButton_Click);
            // 
            // uxUserTasksLabel
            // 
            this.uxUserTasksLabel.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.uxUserTasksLabel.Location = new System.Drawing.Point(23, 26);
            this.uxUserTasksLabel.Name = "uxUserTasksLabel";
            this.uxUserTasksLabel.Size = new System.Drawing.Size(323, 33);
            this.uxUserTasksLabel.TabIndex = 5;
            // 
            // metroTile1
            // 
            this.metroTile1.ActiveControl = null;
            this.metroTile1.Location = new System.Drawing.Point(376, 311);
            this.metroTile1.Name = "metroTile1";
            this.metroTile1.Size = new System.Drawing.Size(177, 131);
            this.metroTile1.TabIndex = 6;
            this.metroTile1.UseSelectable = true;
            // 
            // uxTaskListListBox
            // 
            this.uxTaskListListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxTaskListListBox.FormattingEnabled = true;
            this.uxTaskListListBox.ItemHeight = 20;
            this.uxTaskListListBox.Location = new System.Drawing.Point(24, 82);
            this.uxTaskListListBox.Name = "uxTaskListListBox";
            this.uxTaskListListBox.Size = new System.Drawing.Size(346, 404);
            this.uxTaskListListBox.TabIndex = 7;
            // 
            // TaskList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(576, 519);
            this.Controls.Add(this.uxTaskListListBox);
            this.Controls.Add(this.metroTile1);
            this.Controls.Add(this.uxUserTasksLabel);
            this.Controls.Add(this.uxLogOutButton);
            this.Controls.Add(this.uxChangePriorityButton);
            this.Controls.Add(this.uxRemoveButton);
            this.Controls.Add(this.uxAddTaskButton);
            this.Name = "TaskList";
            this.Text = "List Of Tasks";
            this.Load += new System.EventHandler(this.TaskList_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private MetroFramework.Controls.MetroButton uxAddTaskButton;
        private MetroFramework.Controls.MetroButton uxRemoveButton;
        private MetroFramework.Controls.MetroButton uxChangePriorityButton;
        private MetroFramework.Controls.MetroButton uxLogOutButton;
        private MetroFramework.Controls.MetroLabel uxUserTasksLabel;
        private MetroFramework.Controls.MetroTile metroTile1;
        private System.Windows.Forms.ListBox uxTaskListListBox;
    }
}