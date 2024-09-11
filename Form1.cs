namespace PROG7312_POE___Municipal_Services_Application
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnReportIssues_Click(object sender, EventArgs e)
        {
            ReportIssues reportIssuesForm = new ReportIssues();
            reportIssuesForm.Show();                                // Open ReportIssues form
        }
    }
}
