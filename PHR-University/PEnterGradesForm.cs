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
    public partial class PEnterGradesForm : Form
    {
        SqlConnection sqlCon = null;
        int TeacherID;
        int ClassID;
        int StudentID;
        String Grade;
        int[] studentIDs;
        public PEnterGradesForm(int teacherID)
        {
            TeacherID = teacherID;
            InitializeComponent();
            CreateDatabaseConnection();
            PopulateClassesComboBox();
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
        private void PopulateClassesComboBox()
        {
            SqlCommand sqlCmd = new SqlCommand("getCurrentClasses", sqlCon);
            sqlCmd.CommandType = CommandType.StoredProcedure;
            sqlCmd.Parameters.Add("@teacherID", System.Data.SqlDbType.Int).Value = TeacherID;
            sqlCmd.ExecuteNonQuery();
            SqlDataAdapter da = new SqlDataAdapter(sqlCmd);
            DataSet dataset = new DataSet();
            da.Fill(dataset, "Classes");
            sqlCmd.ExecuteNonQuery();

            int[] classIDs = new int[dataset.Tables[0].Rows.Count];
            for (int i = 0; i < dataset.Tables[0].Rows.Count; i++)
            {
                SelectClassComboBox.Items.Add(dataset.Tables[0].Rows[i].ItemArray[0]);
                classIDs[i] = (int)dataset.Tables[0].Rows[i].ItemArray[1];
            }

        }

        private void SelectClassComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ClassID = (int)SelectClassComboBox.SelectedIndex;
            SqlCommand sqlCmd = new SqlCommand("getStudentList", sqlCon);
            sqlCmd.CommandType = CommandType.StoredProcedure;
            sqlCmd.Parameters.Add("@classID", System.Data.SqlDbType.Int).Value = ClassID;
            sqlCmd.ExecuteNonQuery();
            SqlDataAdapter da = new SqlDataAdapter(sqlCmd);
            DataSet dataset = new DataSet();
            da.Fill(dataset, "Students");
            sqlCmd.ExecuteNonQuery();

            studentIDs = new int[dataset.Tables[0].Rows.Count];
            for (int i = 0; i < dataset.Tables[0].Rows.Count; i++)
            {
                SelectStudentComboBox.Items.Add(dataset.Tables[0].Rows[i].ItemArray[1]);
                studentIDs[i] = (int)dataset.Tables[0].Rows[i].ItemArray[0];
            }
        }
        private void SelectStudentComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = (int)SelectStudentComboBox.SelectedIndex;
            StudentID = studentIDs[index];
        }
        private void GradesComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Grade = GradesComboBox.SelectedItem.ToString();
         
        }
        private void SubmitButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;

            SqlCommand sqlCmd = new SqlCommand("inputGrade", sqlCon);
            sqlCmd.CommandType = CommandType.StoredProcedure;
            sqlCmd.Parameters.Add("@studentID", System.Data.SqlDbType.Int).Value = StudentID;
            sqlCmd.Parameters.Add("@classID", System.Data.SqlDbType.Int).Value = ClassID;
            sqlCmd.Parameters.Add("@grade", System.Data.SqlDbType.VarChar).Value = Grade;
            sqlCmd.ExecuteNonQuery();
            SubmitButton.Text = "SUBMITTED";
        }
    }
}
