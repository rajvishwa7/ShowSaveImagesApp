using Microsoft.Reporting.WinForms;
using System;
using System.Data;
using System.Windows.Forms;

namespace ShowSaveImagesApp
{
    public partial class ReportViewerForm : Form
    {
        public ReportViewerForm()
        {
            InitializeComponent();
        }

        public string ReportName { get; set; }
        public DataTable ReportData { get; set; }
        private void ReportViewerForm_Load(object sender, EventArgs e)
        {

            try
            {
                ReportDataSource rds = new ReportDataSource("DataSet1", ReportData);
                reportViewer1.LocalReport.ReportPath = ReportName;
                reportViewer1.LocalReport.DataSources.Add(rds);
                reportViewer1.RefreshReport();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
