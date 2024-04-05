using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ToDoListApp
{
    public partial class Form1 : Form
    {
        private List<string> tasks = new List<string>();

        public Form1()
        {
            InitializeComponent();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            string task = taskTextBox.Text.Trim();
            if (!string.IsNullOrEmpty(task))
            {
                tasks.Add(task);
                RefreshTaskList();
                taskTextBox.Text = "";
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (tasksListBox.SelectedIndex != -1)
            {
                tasks.RemoveAt(tasksListBox.SelectedIndex);
                RefreshTaskList();
            }
        }

        private void RefreshTaskList()
        {
            tasksListBox.Items.Clear();
            foreach (string task in tasks)
            {
                tasksListBox.Items.Add(task);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
