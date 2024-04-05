namespace ToDoListApp
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            taskTextBox = new TextBox();
            addButton = new Button();
            deleteButton = new Button();
            tasksListBox = new ListBox();
            SuspendLayout();
            // 
            // taskTextBox
            // 
            taskTextBox.Location = new Point(11, 12);
            taskTextBox.Name = "taskTextBox";
            taskTextBox.Size = new Size(223, 27);
            taskTextBox.TabIndex = 0;
            // 
            // addButton
            // 
            addButton.Location = new Point(238, 12);
            addButton.Name = "addButton";
            addButton.Size = new Size(67, 29);
            addButton.TabIndex = 1;
            addButton.Text = "Add";
            addButton.UseVisualStyleBackColor = true;
            addButton.Click += addButton_Click;
            // 
            // deleteButton
            // 
            deleteButton.Location = new Point(238, 47);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(67, 29);
            deleteButton.TabIndex = 3;
            deleteButton.Text = "Delete";
            deleteButton.UseVisualStyleBackColor = true;
            deleteButton.Click += deleteButton_Click;
            // 
            // tasksListBox
            // 
            tasksListBox.FormattingEnabled = true;
            tasksListBox.Location = new Point(11, 47);
            tasksListBox.Name = "tasksListBox";
            tasksListBox.Size = new Size(223, 204);
            tasksListBox.TabIndex = 2;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 515);
            Controls.Add(deleteButton);
            Controls.Add(tasksListBox);
            Controls.Add(addButton);
            Controls.Add(taskTextBox);
            Name = "Form1";
            Text = "To-Do List";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox taskTextBox;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.ListBox tasksListBox;
    }
}
