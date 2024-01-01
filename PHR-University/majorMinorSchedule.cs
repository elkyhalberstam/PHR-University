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
    public partial class majorMinorSchedule : Form
    {
        SqlConnection sqlCon = null;
        int studentID;
        int majorID = 0;
        int minorID = 0;

        int[] majorIDList;
        int[] minorIDList;
        int chooseMaj;
        int chooseMin;

        public majorMinorSchedule(int studentID)
        {
            InitializeComponent();
            createDataBaseConnection();
            this.studentID = studentID;
            fillInfo();
            fillDropDowns();
        }
        //courseID, [name], department, creditsApplied, classID --returnd in from dataset 

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

        private Boolean fillInfo()
        {

            SqlCommand sqlCmd = new SqlCommand("getStudentMajorMinorID", sqlCon);
            sqlCmd.CommandType = CommandType.StoredProcedure;
            sqlCmd.Parameters.Add("@studentID", System.Data.SqlDbType.VarChar).Value = studentID;
            sqlCmd.ExecuteNonQuery();
            SqlDataAdapter da = new SqlDataAdapter(sqlCmd);
            DataSet dataset = new DataSet();
            da.Fill(dataset, "MajorMinor");
            sqlCmd.ExecuteNonQuery();

            majorID = (int)dataset.Tables["MajorMinor"].Rows[0].ItemArray[0];
            if (dataset.Tables["MajorMinor"].Rows[0].ItemArray[1].GetType().Equals(dataset.Tables["MajorMinor"].Rows[0].ItemArray[1].GetType()))
            { 
                   minorID = (int)dataset.Tables["MajorMinor"].Rows[0].ItemArray[1];
            }

            String majorName;
            String minorName;
            int majorCred;
            int minorCred;
            int majorComp = 0;
            int minorComp = 0;

            sqlCmd = new SqlCommand("getMajorInfo", sqlCon);
            sqlCmd.CommandType = CommandType.StoredProcedure;
            sqlCmd.Parameters.Add("@majorID", System.Data.SqlDbType.VarChar).Value = majorID;
            sqlCmd.ExecuteNonQuery();
            da = new SqlDataAdapter(sqlCmd);
            dataset = new DataSet();
            da.Fill(dataset, "Major");
            sqlCmd.ExecuteNonQuery();


            majorName = (String)dataset.Tables["Major"].Rows[0].ItemArray[0];
            majorCred = (int)dataset.Tables["Major"].Rows[0].ItemArray[1];

            sqlCmd = new SqlCommand("getStudentClassesFromMajor", sqlCon);
            sqlCmd.CommandType = CommandType.StoredProcedure;
            sqlCmd.Parameters.Add("@studentID", System.Data.SqlDbType.VarChar).Value = studentID;
            sqlCmd.Parameters.Add("@major", System.Data.SqlDbType.VarChar).Value = majorName;
            sqlCmd.ExecuteNonQuery();
            da = new SqlDataAdapter(sqlCmd);
            dataset = new DataSet();
            da.Fill(dataset, "MajorCred");
            sqlCmd.ExecuteNonQuery();

            for (int i = 0; i < dataset.Tables[0].Rows.Count; i++)
            {
               majorComp += (int)dataset.Tables[0].Rows[i].ItemArray[0];
            }


            major.Text= majorName;
            majorCreditTarget.Text = "required credits: " + majorCred;
            majorTotalCredits.Text = "completed credits: " + majorComp;

            if (minorID > 0)
            {
                sqlCmd = new SqlCommand("getMinorInfo", sqlCon);
                sqlCmd.CommandType = CommandType.StoredProcedure;
                sqlCmd.Parameters.Add("@minorID", System.Data.SqlDbType.VarChar).Value = minorID;
                sqlCmd.ExecuteNonQuery();
                da = new SqlDataAdapter(sqlCmd);
                dataset = new DataSet();
                da.Fill(dataset, "Minor");
                sqlCmd.ExecuteNonQuery();

                minorName = (String)dataset.Tables["Minor"].Rows[0].ItemArray[0];
                minorCred = (int)dataset.Tables["Minor"].Rows[0].ItemArray[1];

                sqlCmd = new SqlCommand("getStudentClassesFromMinor", sqlCon);
                sqlCmd.CommandType = CommandType.StoredProcedure;
                sqlCmd.Parameters.Add("@studentID", System.Data.SqlDbType.VarChar).Value = studentID;
                sqlCmd.Parameters.Add("@minor", System.Data.SqlDbType.VarChar).Value = minorName;
                sqlCmd.ExecuteNonQuery();
                da = new SqlDataAdapter(sqlCmd);
                dataset = new DataSet();
                da.Fill(dataset, "MinorCred");
                sqlCmd.ExecuteNonQuery();

                for (int i = 0; i < dataset.Tables[0].Rows.Count; i++)
                {
                    minorComp += (int)dataset.Tables[0].Rows[i].ItemArray[0];
                }


                minor.Text= minorName;
                minorCreditTarget.Text = "required credits: " +minorCred; 
                minorTotalCredits.Text = "completed credits: " + minorComp;
            }


            return false;
        }

        private Boolean fillDropDowns()
        {
            SqlCommand sqlCmd = new SqlCommand("getAllMajors", sqlCon);
            sqlCmd.CommandType = CommandType.StoredProcedure;
            sqlCmd.ExecuteNonQuery();
            SqlDataAdapter da = new SqlDataAdapter(sqlCmd);
            DataSet dataset = new DataSet();
            da.Fill(dataset, "Majors");
            sqlCmd.ExecuteNonQuery();

            int[] majorIDs = new int[dataset.Tables[0].Rows.Count];

            for (int i = 0; i < dataset.Tables[0].Rows.Count; i++)
            {
                chooseMajor.Items.Add(dataset.Tables[0].Rows[i].ItemArray[0]);
                majorIDs[i] = (int)dataset.Tables[0].Rows[i].ItemArray[1];
            }
            majorIDList = majorIDs;
            
            sqlCmd = new SqlCommand("getAllMinors", sqlCon);
            sqlCmd.CommandType = CommandType.StoredProcedure;
            sqlCmd.ExecuteNonQuery();
            da = new SqlDataAdapter(sqlCmd);
            dataset = new DataSet();
            da.Fill(dataset, "Minors");
            sqlCmd.ExecuteNonQuery();


            int[] minorIDs = new int[dataset.Tables[0].Rows.Count];

            for (int i = 0; i < dataset.Tables[0].Rows.Count; i++)
            {
                chooseMinor.Items.Add(dataset.Tables[0].Rows[i].ItemArray[0]);
                minorIDs[i] = (int)dataset.Tables[0].Rows[i].ItemArray[1];
            }
            minorIDList = minorIDs;

            return false;
        }

        private void switchMajor_Click(object sender, EventArgs e)
        {
            SqlCommand sqlCmd = new SqlCommand("switchMajor", sqlCon);
            sqlCmd.CommandType = CommandType.StoredProcedure;
            sqlCmd.Parameters.Add("@studentID", System.Data.SqlDbType.VarChar).Value = studentID;
            sqlCmd.Parameters.Add("@majorID", System.Data.SqlDbType.VarChar).Value = chooseMaj;
            sqlCmd.ExecuteNonQuery();
            SqlDataAdapter da = new SqlDataAdapter(sqlCmd);
            DataSet dataset = new DataSet();
            da.Fill(dataset, "Major");
            sqlCmd.ExecuteNonQuery();

            fillInfo();
        }

        private void chooseMajor_SelectedIndexChanged(object sender, EventArgs e)
        {
            chooseMaj= majorIDList[chooseMajor.SelectedIndex];
        }

        private void chooseMinor_SelectedIndexChanged(object sender, EventArgs e)
        {
            chooseMin = minorIDList[chooseMinor.SelectedIndex];
        }

        private void switchMinor_Click(object sender, EventArgs e)
        {
            SqlCommand sqlCmd = new SqlCommand("switchMinor", sqlCon);
            sqlCmd.CommandType = CommandType.StoredProcedure;
            sqlCmd.Parameters.Add("@studentID", System.Data.SqlDbType.VarChar).Value = studentID;
            sqlCmd.Parameters.Add("@minorID", System.Data.SqlDbType.VarChar).Value = chooseMin;
            sqlCmd.ExecuteNonQuery();
            SqlDataAdapter da = new SqlDataAdapter(sqlCmd);
            DataSet dataset = new DataSet();
            da.Fill(dataset, "Minor");
            sqlCmd.ExecuteNonQuery();

            fillInfo();
        }
    }
}
