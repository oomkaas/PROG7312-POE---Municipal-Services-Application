namespace PROG7312_POE___Municipal_Services_Application
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnReportIssues = new Button();
            btnEventsAnnouncements = new Button();
            btnServiceRequestStatus = new Button();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // btnReportIssues
            // 
            btnReportIssues.Location = new Point(111, 194);
            btnReportIssues.Name = "btnReportIssues";
            btnReportIssues.Size = new Size(159, 58);
            btnReportIssues.TabIndex = 0;
            btnReportIssues.Text = "Report Issues";
            btnReportIssues.UseVisualStyleBackColor = true;
            btnReportIssues.Click += btnReportIssues_Click;
            // 
            // btnEventsAnnouncements
            // 
            btnEventsAnnouncements.Enabled = false;
            btnEventsAnnouncements.Location = new Point(308, 194);
            btnEventsAnnouncements.Name = "btnEventsAnnouncements";
            btnEventsAnnouncements.Size = new Size(159, 58);
            btnEventsAnnouncements.TabIndex = 1;
            btnEventsAnnouncements.Text = "Local Events and Announcements";
            btnEventsAnnouncements.UseVisualStyleBackColor = true;
            // 
            // btnServiceRequestStatus
            // 
            btnServiceRequestStatus.Enabled = false;
            btnServiceRequestStatus.Location = new Point(508, 194);
            btnServiceRequestStatus.Name = "btnServiceRequestStatus";
            btnServiceRequestStatus.Size = new Size(159, 58);
            btnServiceRequestStatus.TabIndex = 2;
            btnServiceRequestStatus.Text = "Service Request Status";
            btnServiceRequestStatus.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F);
            label1.Location = new Point(243, 52);
            label1.Name = "label1";
            label1.Size = new Size(345, 41);
            label1.TabIndex = 3;
            label1.Text = "Municipal Services Portal";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11F);
            label2.Location = new Point(52, 116);
            label2.Name = "label2";
            label2.Size = new Size(701, 25);
            label2.TabIndex = 4;
            label2.Text = "Your platform for reporting issues, accessing events, and tracking service requests.";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnServiceRequestStatus);
            Controls.Add(btnEventsAnnouncements);
            Controls.Add(btnReportIssues);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnReportIssues;
        private Button btnEventsAnnouncements;
        private Button btnServiceRequestStatus;
        private Label label1;
        private Label label2;
    }
}
