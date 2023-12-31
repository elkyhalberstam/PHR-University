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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PHR_University
{
    public partial class PCurrScheduleForm : Form
    {
        SqlConnection sqlCon = null;
        int TeacherID;
        public PCurrScheduleForm(int teacherID)
        {
            TeacherID = teacherID;
            InitializeComponent();
            CreateDatabaseConnection();
            PopulateSemesterComboBox();
            PopulateTeacherID();
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
        private void PopulateSemesterComboBox()
        {
            SqlCommand sqlCmd = new SqlCommand("getSemestersTeaching", sqlCon);
            sqlCmd.CommandType = CommandType.StoredProcedure;
            sqlCmd.Parameters.Add("@teacherID", System.Data.SqlDbType.Int).Value = TeacherID;
            sqlCmd.ExecuteNonQuery();
            SqlDataAdapter da = new SqlDataAdapter(sqlCmd);
            DataSet dataset = new DataSet();
            da.Fill(dataset, "Semester");
            sqlCmd.ExecuteNonQuery();


            for (int i = 0; i < dataset.Tables[0].Rows.Count; i++)
            {
                SemesterComboBox.Items.Add(dataset.Tables[0].Rows[i].ItemArray[0]);
            }
        }
        private void PopulateTeacherID()
        { 
            IDTextLabel.Text = TeacherID.ToString();
        }    

        private void SemesterComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (SemesterComboBox.SelectedItem.ToString() != null)
            {
                String name = SemesterComboBox.SelectedItem.ToString();
                Console.WriteLine(name);
                SqlCommand sqlCmd = new SqlCommand("getTeacherSchedule", sqlCon);
                sqlCmd.CommandType = CommandType.StoredProcedure;
                sqlCmd.Parameters.Add("@semester", System.Data.SqlDbType.VarChar).Value = name;
                sqlCmd.Parameters.Add("@teacherID", System.Data.SqlDbType.Int).Value = TeacherID;
                sqlCmd.ExecuteNonQuery();
                SqlDataAdapter da = new SqlDataAdapter(sqlCmd);
                DataSet dataset = new DataSet();
                da.Fill(dataset, "Classes");
                ScheduleGridView.AutoGenerateColumns = true;
                ScheduleGridView.DataSource = dataset.Tables["Classes"];
                ScheduleGridView.ColumnHeadersVisible = true;
                ScheduleGridView.RowHeadersVisible = false;

                foreach (DataGridViewColumn column in ScheduleGridView.Columns)
                {
                    column.Width = (ScheduleGridView.Width / 4); // Set the desired width
                }
            }
        }
    }
}
