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
    public partial class stdCourseSchedue : Form
    {
        SqlConnection sqlCon = null;
        int studentID;
        public stdCourseSchedue(int studentID)
        {
            InitializeComponent();
            createDataBaseConnection();
            this.studentID = studentID;
            loadCurrentSchedule();
        }

        private Boolean createDataBaseConnection()
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
                string strConnect = "Server=DESKTOP-2NS3C4L\\SQLEXPRESS;Database=SchoolSystem;Trusted_Connection=True;";

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

        private Boolean loadCurrentSchedule()
        {

            SqlCommand sqlCmd = new SqlCommand("getCurrentSemesterSTD", sqlCon);
            sqlCmd.CommandType = CommandType.StoredProcedure;
            sqlCmd.Parameters.Add("@studentID", System.Data.SqlDbType.VarChar).Value = studentID;
            sqlCmd.ExecuteNonQuery();
            SqlDataAdapter da = new SqlDataAdapter(sqlCmd);
            DataSet dataset = new DataSet();
            da.Fill(dataset, "Semester");
            sqlCmd.ExecuteNonQuery();

            String semester = (String)dataset.Tables[0].Rows[0].ItemArray[0];

            selectedSemester.Text = semester;

            SqlCommand sqlCmd1 = new SqlCommand("getStudentSchedule", sqlCon);
            sqlCmd1.CommandType = CommandType.StoredProcedure;
            sqlCmd1.Parameters.Add("@studentID", System.Data.SqlDbType.VarChar).Value = studentID;
            sqlCmd1.Parameters.Add("@semester", System.Data.SqlDbType.VarChar).Value = semester;
            sqlCmd1.ExecuteNonQuery();
            SqlDataAdapter da1 = new SqlDataAdapter(sqlCmd1);
            DataSet dataset1 = new DataSet();
            da1.Fill(dataset1, "Classes");
            dataGridView1.AutoGenerateColumns = true;
            dataGridView1.DataSource = dataset1.Tables["Classes"];
            dataGridView1.ColumnHeadersVisible = true;
            dataGridView1.RowHeadersVisible = false;

            foreach (DataGridViewColumn column in dataGridView1.Columns)
            {
                column.Width = (dataGridView1.Width / 7); // Set the desired width
            }


            return false;
        }
    }
}
