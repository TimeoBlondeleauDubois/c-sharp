using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace ToDoList
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void AddTask_Click(object sender, RoutedEventArgs e)
        {
            string task = taskTextBox.Text;
            DateTime dueDate = dueDatePicker.SelectedDate ?? DateTime.MinValue;

            if (!string.IsNullOrWhiteSpace(task))
            {
                TaskItem newTask = new TaskItem(task, dueDate);
                taskListBox.Items.Add(newTask);
                taskTextBox.Text = string.Empty;
                dueDatePicker.SelectedDate = null;
            }
        }

        private void DeleteTask_Click(object sender, RoutedEventArgs e)
        {
            if (taskListBox.SelectedItem != null)
            {
                taskListBox.Items.Remove(taskListBox.SelectedItem);
            }
        }

        private void CompleteTask_Click(object sender, RoutedEventArgs e)
        {
            if (taskListBox.SelectedItem != null)
            {
                TaskItem selectedTask = (TaskItem)taskListBox.SelectedItem;
                selectedTask.IsCompleted = !selectedTask.IsCompleted;
                UpdateTaskListBox();
            }
        }

        private void UpdateTaskListBox()
        {
            taskListBox.Items.Refresh();
        }

        private void taskListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (taskListBox.SelectedItem != null)
            {
                TaskItem selectedTask = (TaskItem)taskListBox.SelectedItem;
                selectedTask.IsCompleted = !selectedTask.IsCompleted;

                SolidColorBrush brush = selectedTask.IsCompleted ? Brushes.Green : Brushes.Red;
                taskListBox.Foreground = brush;
            }
        }
    }

    public class TaskItem
    {
        public string Task { get; set; }
        public DateTime DueDate { get; set; }
        public bool IsCompleted { get; set; }

        public string Status => IsCompleted ? "Terminé" : "En cours";
        public string StatusColor => IsCompleted ? "Green" : "Red";

        public TaskItem(string task, DateTime dueDate)
        {
            Task = task;
            DueDate = dueDate;
            IsCompleted = false;
        }

        public override string ToString()
        {
            return $"{Task} (Date d'échéance : {DueDate.ToShortDateString()}, Statut : {Status})";
        }
    }
}
