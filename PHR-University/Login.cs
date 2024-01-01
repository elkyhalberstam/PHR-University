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
    public partial class Login : Form
    {
        SqlConnection sqlCon = null;

        public Login()
        {
            InitializeComponent();
            createDataBaseConnection();
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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            String pass = password.Text;
            String user = username.Text;

            SqlCommand sqlCmd = new SqlCommand("checkLogin", sqlCon);
            sqlCmd.CommandType = CommandType.StoredProcedure;
            sqlCmd.Parameters.Add("@email", System.Data.SqlDbType.VarChar).Value = user;
            sqlCmd.Parameters.Add("@password", System.Data.SqlDbType.VarChar).Value = pass;

            sqlCmd.ExecuteNonQuery();
            SqlDataAdapter da = new SqlDataAdapter(sqlCmd);
            DataSet dataset = new DataSet();
            da.Fill(dataset, "Login");

            if ((int)(dataset.Tables["Login"].Rows[0].ItemArray[0]) == 1)
            {
                int admin = 0;
                int teacher = 0;
                int student = 0;

                sqlCmd = new SqlCommand("checkPersonAdmin", sqlCon);
                sqlCmd.CommandType = CommandType.StoredProcedure;
                sqlCmd.Parameters.Add("@email", System.Data.SqlDbType.VarChar).Value = user;

                sqlCmd.ExecuteNonQuery();
                da = new SqlDataAdapter(sqlCmd);
                dataset = new DataSet();
                da.Fill(dataset, "Admin");

                if (dataset.Tables["Admin"].Rows.Count > 0)
                {
                    admin = (int)dataset.Tables["Admin"].Rows[0].ItemArray[0];
                }

                sqlCmd = new SqlCommand("checkPersonTeacher", sqlCon);
                sqlCmd.CommandType = CommandType.StoredProcedure;
                sqlCmd.Parameters.Add("@email", System.Data.SqlDbType.VarChar).Value = user;

                sqlCmd.ExecuteNonQuery();
                da = new SqlDataAdapter(sqlCmd);
                dataset = new DataSet();
                da.Fill(dataset, "Teacher");
                if (dataset.Tables["Teacher"].Rows.Count > 0)
                {
                    teacher = (int)dataset.Tables["Teacher"].Rows[0].ItemArray[0];
                }

                sqlCmd = new SqlCommand("checkPersonStudent", sqlCon);
                sqlCmd.CommandType = CommandType.StoredProcedure;
                sqlCmd.Parameters.Add("@email", System.Data.SqlDbType.VarChar).Value = user;

                sqlCmd.ExecuteNonQuery();
                da = new SqlDataAdapter(sqlCmd);
                dataset = new DataSet();
                da.Fill(dataset, "Student");

                if (dataset.Tables["Student"].Rows.Count > 0)
                {
                    student = (int)dataset.Tables["Student"].Rows[0].ItemArray[0];
                }

                if (admin >= 1)
                {
                    Form formAdmin = new AdminPage(admin);
                    formAdmin.Show();
                }
                else if (teacher >= 1)
                {
                    Form formTeacher = new ProfessorPage();
                    formTeacher.Show();
                }
                else if (student >= 1)
                {
                    Form formStudent = new StudentPage(student);
                    formStudent.Show();
                }
                else
                {
                    MessageBox.Show("You have no role in the system. Is this a hack?", "System Break in",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                Hide();
            }
            else
            {
                username.Clear();
                password.Clear();
            }


        }
    }
}

