using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PHR_University
{
    public partial class courseList : Form
    {
        SqlConnection sqlCon = null;
        int semester;

        public courseList()
        {
            InitializeComponent();
            CreateDatabaseConnection();
            populateLists();

        }

        private Boolean CreateDatabaseConnection()
        {
            try
            {
                /* get database parameters from App.config file */
                string strServer = ConfigurationManager.AppSettings["server"];
                string strDatabase = ConfigurationManager.AppSettings["database"];

                /* open a connection to database */
                //  typical connection string:
                //   sqlCon = new SqlConnection("Server=DESKTOP-17VOE83;Database=Finance;Trusted_Connection=True;");
                //string strConnect = $"Server={strServer};Database={strDatabase};Trusted_Connection=True;";
                string strConnect = "Server=ML-RefVm-231318\\SQLExpress;Database=SchoolSystem;Trusted_Connection=True;";

                sqlCon = new SqlConnection(strConnect);
                sqlCon.Open();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(" " + DateTime.Now.ToLongTimeString() + "  " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return false;
        }

        private void populateLists()
        {
            SqlCommand sqlCmd = new SqlCommand("getSemesterList", sqlCon);
            sqlCmd.CommandType = CommandType.StoredProcedure;
            sqlCmd.ExecuteNonQuery();
            SqlDataAdapter da = new SqlDataAdapter(sqlCmd);
            DataSet dataset = new DataSet();
            da.Fill(dataset, "Semester");
            sqlCmd.ExecuteNonQuery();


            for (int i = 0; i < dataset.Tables[0].Rows.Count; i++)
            {
                semesterComboBox.Items.Add(dataset.Tables[0].Rows[i].ItemArray[0]);
            }
        }


        private void courseList_Load(object sender, EventArgs e)
        {

        }

        private void semesterTextBox(object sender, EventArgs e)
        {

        }

        private void courseListPanel_(object sender, PaintEventArgs e)
        {
            
        }

        private void semesterComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (semesterComboBox.SelectedItem.ToString() != null)
            {
                String name = semesterComboBox.SelectedItem.ToString();
                Console.WriteLine(name);
                SqlCommand sqlCmd = new SqlCommand("getSemesterClasses", sqlCon);
                sqlCmd.CommandType = CommandType.StoredProcedure;
                sqlCmd.Parameters.Add("@semester", System.Data.SqlDbType.VarChar).Value = name;
                sqlCmd.ExecuteNonQuery();
                SqlDataAdapter da = new SqlDataAdapter(sqlCmd);
                DataSet dataset = new DataSet();
                da.Fill(dataset, "Classes");
                dataGridView1.AutoGenerateColumns = true;
                dataGridView1.DataSource = dataset.Tables["Classes"];
                dataGridView1.ColumnHeadersVisible = true;
                dataGridView1.RowHeadersVisible = false;

                foreach (DataGridViewColumn column in dataGridView1.Columns)
                {
                    column.Width = (dataGridView1.Width / 7); // Set the desired width
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
