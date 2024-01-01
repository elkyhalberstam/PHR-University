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
    public partial class PEmailForm : Form
    {
        SqlConnection sqlCon = null;
        int TeacherID;
        public PEmailForm(int teacherID)
        {
            InitializeComponent();
            TeacherID = teacherID;
            CreateDatabaseConnection();
            PopulateEmailView();
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
                string strConnect = "Server=DESKTOP-ID4TL0U\\SQLExpress;Database=SchoolSystem;Trusted_Connection=True;";

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
        private void PopulateEmailView()
        {
            SqlCommand sqlCmd = new SqlCommand("getTeacherEmail", sqlCon);
            sqlCmd.CommandType = CommandType.StoredProcedure;
            sqlCmd.Parameters.Add("@teacherID", System.Data.SqlDbType.Int).Value = TeacherID;
            sqlCmd.ExecuteNonQuery();
            SqlDataAdapter da = new SqlDataAdapter(sqlCmd);
            DataSet dataset = new DataSet();
            da.Fill(dataset, "Email");
            sqlCmd.ExecuteNonQuery();
            EmailGridView.AutoGenerateColumns = true;
            EmailGridView.DataSource = dataset.Tables["Email"];
            EmailGridView.ColumnHeadersVisible = true;
            EmailGridView.RowHeadersVisible = false;

            foreach (DataGridViewColumn column in EmailGridView.Columns)
            {
                column.Width = (EmailGridView.Width /2); // Set the desired width
            }
        }


    }
}
