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
using System.Xml.Linq;

namespace PHR_University
{
    public partial class PViewClassListForm : Form
    {
        SqlConnection sqlCon = null;
        int TeacherID;
        int ClassID;
        int[] classIDs;
        public PViewClassListForm(int teacherID)
        {
            InitializeComponent();
            TeacherID = teacherID;
            CreateDatabaseConnection();
            PopulateClassComboBox();
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
        private void PopulateClassComboBox()
        {
            SqlCommand sqlCmd = new SqlCommand("getCurrentClasses", sqlCon);
            sqlCmd.CommandType = CommandType.StoredProcedure;
            sqlCmd.Parameters.Add("@teacherID", System.Data.SqlDbType.Int).Value = TeacherID;
            sqlCmd.ExecuteNonQuery();
            SqlDataAdapter da = new SqlDataAdapter(sqlCmd);
            DataSet dataset = new DataSet();
            da.Fill(dataset, "Classes");
            sqlCmd.ExecuteNonQuery();

            classIDs = new int[dataset.Tables[0].Rows.Count];
            for (int i = 0; i < dataset.Tables[0].Rows.Count; i++)
            {
                SelectClassComboBox.Items.Add(dataset.Tables[0].Rows[i].ItemArray[0]);
                classIDs[i] = (int)dataset.Tables[0].Rows[i].ItemArray[1];
            }
        }

        private void SelectClassComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = (int)SelectClassComboBox.SelectedIndex;
            ClassID = classIDs[index];
            SqlCommand sqlCmd = new SqlCommand("getClassList", sqlCon);
            sqlCmd.CommandType = CommandType.StoredProcedure;
            sqlCmd.Parameters.Add("@classID", System.Data.SqlDbType.Int).Value = ClassID;
            sqlCmd.ExecuteNonQuery();
            SqlDataAdapter da = new SqlDataAdapter(sqlCmd);
            DataSet dataset = new DataSet();
            da.Fill(dataset, "Classes");
            ClassListGridView.AutoGenerateColumns = true;
            ClassListGridView.DataSource = dataset.Tables["Classes"];
            ClassListGridView.ColumnHeadersVisible = true;
            ClassListGridView.RowHeadersVisible = false;

            foreach (DataGridViewColumn column in ClassListGridView.Columns)
            {
                column.Width = (ClassListGridView.Width / 4); // Set the desired width
            }
        }
     
    }
}
