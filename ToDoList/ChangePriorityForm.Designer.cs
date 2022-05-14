
namespace ToDoList
{
    partial class ChangePriorityForm
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
            this.uxPriorityComboBox = new MetroFramework.Controls.MetroComboBox();
            this.uxPriorityLabel = new MetroFramework.Controls.MetroLabel();
            this.uxCancelButton = new MetroFramework.Controls.MetroButton();
            this.uxChangeButton = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // uxPriorityComboBox
            // 
            this.uxPriorityComboBox.FormattingEnabled = true;
            this.uxPriorityComboBox.ItemHeight = 23;
            this.uxPriorityComboBox.Location = new System.Drawing.Point(33, 109);
            this.uxPriorityComboBox.Name = "uxPriorityComboBox";
            this.uxPriorityComboBox.Size = new System.Drawing.Size(188, 29);
            this.uxPriorityComboBox.TabIndex = 0;
            this.uxPriorityComboBox.UseSelectable = true;
            // 
            // uxPriorityLabel
            // 
            this.uxPriorityLabel.AutoSize = true;
            this.uxPriorityLabel.Location = new System.Drawing.Point(33, 74);
            this.uxPriorityLabel.Name = "uxPriorityLabel";
            this.uxPriorityLabel.Size = new System.Drawing.Size(51, 19);
            this.uxPriorityLabel.TabIndex = 1;
            this.uxPriorityLabel.Text = "Priority";
            // 
            // uxCancelButton
            // 
            this.uxCancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.uxCancelButton.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.uxCancelButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.uxCancelButton.Location = new System.Drawing.Point(140, 172);
            this.uxCancelButton.Name = "uxCancelButton";
            this.uxCancelButton.Size = new System.Drawing.Size(81, 38);
            this.uxCancelButton.TabIndex = 3;
            this.uxCancelButton.Text = "Cancel";
            this.uxCancelButton.UseSelectable = true;
            // 
            // uxChangeButton
            // 
            this.uxChangeButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.uxChangeButton.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.uxChangeButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.uxChangeButton.Location = new System.Drawing.Point(33, 172);
            this.uxChangeButton.Name = "uxChangeButton";
            this.uxChangeButton.Size = new System.Drawing.Size(80, 38);
            this.uxChangeButton.TabIndex = 4;
            this.uxChangeButton.Text = "Change";
            this.uxChangeButton.UseSelectable = true;
            this.uxChangeButton.Click += new System.EventHandler(this.uxChangeButton_Click);
            // 
            // ChangePriorityForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(261, 250);
            this.Controls.Add(this.uxChangeButton);
            this.Controls.Add(this.uxCancelButton);
            this.Controls.Add(this.uxPriorityLabel);
            this.Controls.Add(this.uxPriorityComboBox);
            this.Name = "ChangePriorityForm";
            this.Text = "ChangePriorityForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroComboBox uxPriorityComboBox;
        private MetroFramework.Controls.MetroLabel uxPriorityLabel;
        private MetroFramework.Controls.MetroButton uxCancelButton;
        private MetroFramework.Controls.MetroButton uxChangeButton;
    }
}