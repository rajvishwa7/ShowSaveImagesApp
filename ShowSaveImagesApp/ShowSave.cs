using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace ShowSaveImagesApp
{
    public partial class ShowSave : Form
    {
        string imagepath = "";
        string connStr = "Data Source=DESKTOP-FP7REI9\\SQLEXPRESS;Initial Catalog = ShowSaveImageDB; Integrated Security = True";
        public ShowSave()
        {
            InitializeComponent();
        }

        private void tabSave_Click(object sender, EventArgs e)
        {

        }

        private void btnBrowseImg_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "image files (*.jpg;*.jpeg;*.png)|*.jpg;*.jpeg;*.png";
            if (open.ShowDialog() == DialogResult.OK)
            {
                picBoxSave.Image = new Bitmap(open.FileName);
                imagepath = open.FileName;
            }
        }

        private void btnSaveData_Click(object sender, EventArgs e)
        {

            byte[] imagedata = null;
            if (imagepath != "")
            {
                using (Stream stm = File.OpenRead(imagepath))
                {
                    imagedata = new byte[stm.Length];
                    stm.Read(imagedata, 0, imagedata.Length);
                }
            }
            else
            {
                string appPath = Application.StartupPath.Substring(0, Application.StartupPath.Length - 10);
                string imagepath = appPath + "\\image\\no-image-available.png";
                using (Stream stm = File.OpenRead(imagepath))
                {
                    imagedata = new byte[stm.Length];
                    stm.Read(imagedata, 0, imagedata.Length);
                }
            }

            SqlConnection conn = new SqlConnection(connStr);
            conn.Open();
            try
            {
                string sql = "insert into tbl_imgRecord(Uname,Uemail,Uimage)values(@Uname,@Uemail,@Uimage)";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@Uname", txtSaveName.Text);
                cmd.Parameters.AddWithValue("@Uemail", txtSaveEmail.Text);
                cmd.Parameters.AddWithValue("@Uimage", imagedata);
                int result = cmd.ExecuteNonQuery();
                if (result > 0)
                {
                    MessageBox.Show("Data Saved Perfectly!");
                }
                else
                {
                    MessageBox.Show("Data Not Saved!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            conn.Close();

        }

        private void btnClearImg_Click(object sender, EventArgs e)
        {
            picBoxSave.Image = null;
        }

        private void btnClearData_Click(object sender, EventArgs e)
        {
            txtSaveName.Clear();
            txtSaveEmail.Clear();
        }

        private void txtShowSearch_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnShowSearch_Click(object sender, EventArgs e)
        {
            picBoxShow.Image = null;
            txtShowName.Text = string.Empty;
            txtShowEmail.Text = string.Empty;

            byte[] imagename;

            SqlConnection conn = new SqlConnection(connStr);
            conn.Open();
            try
            {
                string sql = "select * from tbl_imgRecord where id=@id";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@id", txtShowSearch.Text);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    txtShowName.Text = reader["Uname"].ToString();
                    txtShowEmail.Text = reader["Uemail"].ToString();
                    imagename = (byte[])reader["Uimage"];
                    picBoxShow.Image = Image.FromStream(new MemoryStream(imagename));
                }
                else
                {
                    MessageBox.Show("No Record Found!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            conn.Close();
        }

        private void btnShowReport_Click(object sender, EventArgs e)
        {
            if (txtShowSearch.Text == string.Empty)
            {
                MessageBox.Show("Please Enter ID");
                txtShowSearch.Focus();
            }
            else
            {
                int id = Convert.ToInt32(txtShowSearch.Text);
                DataTable dt = GetDataBasedOnID(id);
                if (dt.Rows.Count > 0)
                {
                    string apppath = Application.StartupPath;
                    string reportpath = @"Reports/RecordReport.rdlc";
                    string fullpath = Path.Combine(apppath, reportpath);

                    ReportViewerForm rpt = new ReportViewerForm();
                    rpt.ReportName = fullpath;
                    rpt.ReportData = dt;
                    rpt.ShowDialog();
                }
                else
                {
                    MessageBox.Show("No Record Found");
                }
            }
        }


        // Method for Get Data

        private DataTable GetDataBasedOnID(int id)
        {
            DataTable dt = new DataTable();
            SqlConnection conn = new SqlConnection(connStr);
            conn.Open();
            try
            {
                string sql = "select * from tbl_imgRecord where id=@id";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("id", id);
                SqlDataAdapter adp = new SqlDataAdapter(cmd);
                adp.Fill(dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return dt;
        }
    }
}
