using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PHR_University
{
    public partial class stdGraduationStatus : Form
    {
        SqlConnection sqlCon = null;
        int studentID;
        public stdGraduationStatus(int studentID)
        {
            InitializeComponent();
            createDataBaseConnection();
            this.studentID = studentID;
            calculateGPA();
            loadInfo();
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

        private Boolean calculateGPA()
        {
            double GPA = 4.0;
            int totalGrade = 0;
            int totalGradeCounter = 0;
            int totalCred = 0;


            SqlCommand sqlCmd = new SqlCommand("getAllStudentClasses", sqlCon);
            sqlCmd.CommandType = CommandType.StoredProcedure;
            sqlCmd.Parameters.Add("@studentID", System.Data.SqlDbType.VarChar).Value = studentID;
            sqlCmd.ExecuteNonQuery();
            SqlDataAdapter da = new SqlDataAdapter(sqlCmd);
            DataSet dataset = new DataSet();
            da.Fill(dataset, "Classes");
            sqlCmd.ExecuteNonQuery();

            for (int i = 0; i < dataset.Tables[0].Rows.Count; i++)
            {
                totalCred += (int)dataset.Tables[0].Rows[i].ItemArray[4];
                String grade = (String)dataset.Tables[0].Rows[i].ItemArray[2];
                switch (grade)
                {
                    case "A+":
                        totalGrade += 100;
                        totalGradeCounter++;
                        break;
                    case "A":
                        totalGrade += 95;
                        totalGradeCounter++;
                        break;
                    case "A-":
                        totalGrade += 92;
                        totalGradeCounter++;
                        break;
                    case "B+":
                        totalGrade += 87;
                        totalGradeCounter++;
                        break;
                    case "B":
                        totalGrade += 85;
                        totalGradeCounter++;
                        break;
                    case "B-":
                        totalGrade += 82;
                        totalGradeCounter++;
                        break;
                    case "C+":
                        totalGrade += 77;
                        totalGradeCounter++;
                        break;
                    case "C":
                        totalGrade += 75;
                        totalGradeCounter++;
                        break;
                    case "C-":
                        totalGrade += 72;
                        totalGradeCounter++;
                        break;
                    case "D+":
                        totalGrade += 67;
                        totalGradeCounter++;
                        break;
                    case "D":
                        totalGrade += 65;
                        totalGradeCounter++;
                        break;
                    case "D-":
                        totalGrade += 62;
                        totalGradeCounter++;
                        break;
                    case "F":
                        totalGrade += 50;
                        totalGradeCounter++;
                        break;
                    Default:
                        totalGrade += 0;
                        //totalGradeCounter += 0;
                }
            }
            if (totalGradeCounter != 0) { 
                GPA = totalGrade / totalGradeCounter;
             }

            String batchStatus;
            if (totalCred < 30)
            {
                batchStatus = "Freshmen";
            }
            else if (totalCred < 60)
            {
                batchStatus = "Sophmore";
            }
            else if (totalCred < 90)
            {
                batchStatus = "Junior";
            }
            else
            {
                batchStatus = "Senior";
            }

            SqlCommand sqlCmd1 = new SqlCommand("updateTotalCreditsCompleted", sqlCon);
            sqlCmd1.CommandType = CommandType.StoredProcedure;
            sqlCmd1.Parameters.Add("@studentID", System.Data.SqlDbType.VarChar).Value = studentID;
            sqlCmd1.Parameters.Add("@credits", System.Data.SqlDbType.VarChar).Value = totalCred;
            sqlCmd1.ExecuteNonQuery();
            SqlDataAdapter da1 = new SqlDataAdapter(sqlCmd1);
            DataSet dataset1 = new DataSet();
            da1.Fill(dataset1, "update");
            sqlCmd1.ExecuteNonQuery();

            sqlCmd1 = new SqlCommand("updateGPA", sqlCon);
            sqlCmd1.CommandType = CommandType.StoredProcedure;
            sqlCmd1.Parameters.Add("@studentID", System.Data.SqlDbType.VarChar).Value = studentID;
            sqlCmd1.Parameters.Add("@gpa", System.Data.SqlDbType.VarChar).Value = GPA;
            sqlCmd1.ExecuteNonQuery();
            da1 = new SqlDataAdapter(sqlCmd1);
            dataset1 = new DataSet();
            da1.Fill(dataset1, "update1");
            sqlCmd1.ExecuteNonQuery();

            sqlCmd1 = new SqlCommand("updateBatchStatus", sqlCon);
            sqlCmd1.CommandType = CommandType.StoredProcedure;
            sqlCmd1.Parameters.Add("@studentID", System.Data.SqlDbType.VarChar).Value = studentID;
            sqlCmd1.Parameters.Add("@batchStatus", System.Data.SqlDbType.VarChar).Value = batchStatus;
            sqlCmd1.ExecuteNonQuery();
            da1 = new SqlDataAdapter(sqlCmd1);
            dataset1 = new DataSet();
            da1.Fill(dataset1, "update1");
            sqlCmd1.ExecuteNonQuery();


            return false;
        }

        private Boolean loadInfo()
        {
            SqlCommand sqlCmd = new SqlCommand("getGraduationStatisInfo", sqlCon);
            sqlCmd.CommandType = CommandType.StoredProcedure;
            sqlCmd.Parameters.Add("@studentID", System.Data.SqlDbType.VarChar).Value = studentID;
            sqlCmd.ExecuteNonQuery();
            SqlDataAdapter da = new SqlDataAdapter(sqlCmd);
            DataSet dataset = new DataSet();
            da.Fill(dataset, "Info");
            sqlCmd.ExecuteNonQuery();

            batchStatus.Text = (String)dataset.Tables[0].Rows[0].ItemArray[0];
            gpaBox.Text = "" +(double)dataset.Tables[0].Rows[0].ItemArray[1];
            major.Text = (String)dataset.Tables[0].Rows[0].ItemArray[2];
            minor.Text = (String)dataset.Tables[0].Rows[0].ItemArray[3];



            return false;
        }


    }
}
