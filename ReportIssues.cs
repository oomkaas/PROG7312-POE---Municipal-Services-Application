using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROG7312_POE___Municipal_Services_Application
{
    public partial class ReportIssues : Form
    {

        // List to store reported issues
        private List<Issue> reportedIssues = new List<Issue>();

        // stores media file
        private string attachedMediaFilePath = "";
        public ReportIssues()
        {
            InitializeComponent();

            progressBar1.Minimum = 0;
            progressBar1.Maximum = 100;
            progressBar1.Value = 0;
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void btnAttachment_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                //Handle the selected file
                MessageBox.Show($"File {ofd.FileName} selected.");
            }
        }

        private async void btnSubmit_Click(object sender, EventArgs e)
        {
            //Collects data from the form
            string location = txtLocation.Text;
            string category = cmbCategory.SelectedItem?.ToString();
            string description = rtxtDescription.Text;

            //Validates the inputs
            if (string.IsNullOrEmpty(location) || string.IsNullOrEmpty(category) || string.IsNullOrEmpty(description))
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }

            
            progressBar1.Value = 0;
            for (int i = 0; i <= 100; i += 20)
            {
                progressBar1.Value = i;
                await Task.Delay(300);  
            }

            //Creates a new Issue object and adds it to the list
            Issue newIssue = new Issue(location, category, description, attachedMediaFilePath);
            reportedIssues.Add(newIssue);

            //Adds reported issue summary to ListBox 
            lstReportedIssues.Items.Add($"{location} - {category}");

            MessageBox.Show("Issue Submitted Successfully!");

            //Clears the form for the next input
            txtLocation.Clear();
            cmbCategory.SelectedIndex = -1;
            rtxtDescription.Clear();
            attachedMediaFilePath = ""; 

            // Reset progress bar for next submission
            progressBar1.Value = 0;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close(); // Closes the ReportIssues form and return to the main menu
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
