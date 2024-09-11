namespace PROG7312_POE___Municipal_Services_Application
{
    partial class ReportIssues
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
            txtLocation = new TextBox();
            cmbCategory = new ComboBox();
            rtxtDescription = new RichTextBox();
            btnAttachment = new Button();
            btnSubmit = new Button();
            progressBar1 = new ProgressBar();
            btnBack = new Button();
            lstReportedIssues = new ListBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            SuspendLayout();
            // 
            // txtLocation
            // 
            txtLocation.Location = new Point(131, 122);
            txtLocation.Name = "txtLocation";
            txtLocation.Size = new Size(234, 27);
            txtLocation.TabIndex = 0;
            // 
            // cmbCategory
            // 
            cmbCategory.FormattingEnabled = true;
            cmbCategory.Items.AddRange(new object[] { "Sanitation & Waste Management", "Roads & Traffic", "Water & Sanitation", "Utilities (Electricity & Gas)", "Public Safety", "Public Transport", "Parks & Recreation", "Environmental Issues", "Housing & Infrastructure", "Animal Control", "Community Services", "Other", "" });
            cmbCategory.Location = new Point(134, 181);
            cmbCategory.Name = "cmbCategory";
            cmbCategory.Size = new Size(231, 28);
            cmbCategory.TabIndex = 1;
            // 
            // rtxtDescription
            // 
            rtxtDescription.Location = new Point(135, 238);
            rtxtDescription.Name = "rtxtDescription";
            rtxtDescription.Size = new Size(230, 66);
            rtxtDescription.TabIndex = 2;
            rtxtDescription.Text = "";
            // 
            // btnAttachment
            // 
            btnAttachment.Location = new Point(135, 329);
            btnAttachment.Name = "btnAttachment";
            btnAttachment.Size = new Size(121, 29);
            btnAttachment.TabIndex = 3;
            btnAttachment.Text = "Attach Media";
            btnAttachment.UseVisualStyleBackColor = true;
            btnAttachment.Click += btnAttachment_Click;
            // 
            // btnSubmit
            // 
            btnSubmit.Location = new Point(135, 375);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(121, 29);
            btnSubmit.TabIndex = 4;
            btnSubmit.Text = "Submit";
            btnSubmit.UseVisualStyleBackColor = true;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(61, 433);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(711, 25);
            progressBar1.TabIndex = 5;
            progressBar1.Click += progressBar1_Click;
            // 
            // btnBack
            // 
            btnBack.Location = new Point(21, 21);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(73, 29);
            btnBack.TabIndex = 6;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // lstReportedIssues
            // 
            lstReportedIssues.FormattingEnabled = true;
            lstReportedIssues.Location = new Point(510, 122);
            lstReportedIssues.Name = "lstReportedIssues";
            lstReportedIssues.Size = new Size(252, 184);
            lstReportedIssues.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(37, 122);
            label1.Name = "label1";
            label1.Size = new Size(66, 20);
            label1.TabIndex = 8;
            label1.Text = "Location";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(37, 181);
            label2.Name = "label2";
            label2.Size = new Size(69, 20);
            label2.TabIndex = 9;
            label2.Text = "Category";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(37, 238);
            label3.Name = "label3";
            label3.Size = new Size(85, 20);
            label3.TabIndex = 10;
            label3.Text = "Description";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(71, 384);
            label4.Name = "label4";
            label4.Size = new Size(0, 20);
            label4.TabIndex = 11;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11F);
            label5.Location = new Point(61, 76);
            label5.Name = "label5";
            label5.Size = new Size(280, 25);
            label5.TabIndex = 12;
            label5.Text = "Provide details about your issue";
            // 
            // ReportIssues
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(813, 470);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lstReportedIssues);
            Controls.Add(btnBack);
            Controls.Add(progressBar1);
            Controls.Add(btnSubmit);
            Controls.Add(btnAttachment);
            Controls.Add(rtxtDescription);
            Controls.Add(cmbCategory);
            Controls.Add(txtLocation);
            Name = "ReportIssues";
            Text = "ReportIssues";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtLocation;
        private ComboBox cmbCategory;
        private RichTextBox rtxtDescription;
        private Button btnAttachment;
        private Button btnSubmit;
        private ProgressBar progressBar1;
        private Button btnBack;
        private ListBox lstReportedIssues;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
    }
}