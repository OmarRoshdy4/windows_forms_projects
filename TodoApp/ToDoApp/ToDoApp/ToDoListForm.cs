using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;


namespace ToDoApp
{
    public partial class ToDoListForm : Form
    {
        //------------------------------------------------------
        List<Task> tasks = new List<Task>();
        string filePath = "tasks.txt";

        private void LoadTasks()
        {
            if (!File.Exists(filePath)) return;
            tasks = File.ReadAllLines(filePath).Select(Task.FromString).ToList();
        }

        private void SaveTasks()
        {
            File.WriteAllLines(filePath, tasks.Select(t => t.ToString()));
        }

        private void RefreshTaskList()
        {
            dgvTasks.Rows.Clear();
            foreach (var t in tasks)
            {
                if (!chkShowCompleted.Checked && t.IsCompleted) continue;
                if (rbToday.Checked && t.DueDate.Date != DateTime.Today) continue;
                dgvTasks.Rows.Add(t.Description, t.Priority, t.DueDate.ToShortDateString(), t.IsCompleted);
            }
        }
        //------------------------------------------------------
        public ToDoListForm()
        {
            InitializeComponent();
        }

        private void ToDoListForm_Load(object sender, EventArgs e)
        {
            cmbPriority.Items.AddRange(new string[] { "Low", "Medium", "High" });
            LoadTasks();
            RefreshTaskList();
            autoSaveTimer.Tick += autoSaveTimer_Tick;
        }

        private void txtDescription_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void rbAll_CheckedChanged(object sender, EventArgs e)
        {
            RefreshTaskList();
        }

        private void rbToday_CheckedChanged(object sender, EventArgs e)
        {

            RefreshTaskList();
        }


        private void btnAddTask_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtDescription.Text))
            {
                MessageBox.Show("Please enter a task description.");
                return;
            }

            var task = new Task
            {
                Description = txtDescription.Text,
                Priority = cmbPriority.Text,
                DueDate = dtpDueDate.Value.Date,
                IsCompleted = false,
                ImagePath = ""
            };

            tasks.Add(task);
            SaveTasks();
            RefreshTaskList();
            txtDescription.Clear();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveTasks();
            MessageBox.Show("Tasks saved successfully!");
        }

        private void btnDeleteTask_Click(object sender, EventArgs e)
        {
            if (dgvTasks.CurrentRow == null)
            {
                MessageBox.Show("Please select a task to delete.");
                return;
            }

            int index = dgvTasks.CurrentRow.Index;

            if (index >= 0 && index < tasks.Count)
            {
                var confirm = MessageBox.Show("Are you sure you want to delete this task?", "Confirm Delete", MessageBoxButtons.YesNo);
                if (confirm == DialogResult.Yes)
                {
                    tasks.RemoveAt(index);
                    SaveTasks();
                    RefreshTaskList();
                }
            }
        }

        private void dtpDueDate_ValueChanged(object sender, EventArgs e)
        {

        }

        private void cmbPriority_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void chkShowCompleted_CheckedChanged(object sender, EventArgs e)
        {
            RefreshTaskList();
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void dgvTasks_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void autoSaveTimer_Tick(object sender, EventArgs e)
        {
            SaveTasks();
            progressBar1.Style = ProgressBarStyle.Marquee;
            progressBar1.Visible = true;
            Timer tempTimer = new Timer { Interval = 1000 };
            tempTimer.Tick += (s, args) => { progressBar1.Visible = false; tempTimer.Stop(); };
            tempTimer.Start();
        }

        private void menuNew_Click(object sender, EventArgs e)
        {
            MessageBox.Show("New clicked");
        }
     
        private void menuSettings_Click(object sender, EventArgs e)
        {
            var settingsForm = new SettingsForm();
            settingsForm.Show();
            this.Hide();
        }

        private void menuExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void contextMarkComplete_Click(object sender, EventArgs e)
        {
            if (dgvTasks.CurrentRow != null)
            {
                var index = dgvTasks.CurrentRow.Index;
                tasks[index].IsCompleted = true;
                SaveTasks();
                RefreshTaskList();
            }
        }

        private void contextDetails_Click(object sender, EventArgs e)
        {
            if (dgvTasks.CurrentRow != null)
            {
                //var index = dgvTasks.CurrentRow.Index;
                //TaskDetailsForm details = new TaskDetailsForm(tasks[index]);
                //details.Show();
            }
        }

        

    }
}
