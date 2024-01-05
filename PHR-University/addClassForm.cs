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
    public partial class addClassForm : Form
    {
        SqlConnection sqlCon = null;
        int adminID;
        int[] classIdList;
        int addDrop;
        int classID;

        public addClassForm(int adminID)
        {
            InitializeComponent();
            CreateDatabaseConnection();
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
                string strConnect = "Server=ML-RefVm-231318\\SQLEXPRESS;Database=SchoolSystem;Trusted_Connection=True;";

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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //add class with the given vairables from the text boxes
            String name = className.Text;
            String department = departmentString.Text;
            String creditsString = CreditsApplied.Text;
            int credits = 0;
            Boolean success = int.TryParse(creditsString, out credits);
            if(success)
            {
                //call stored procedure addCourse
                SqlCommand sqlCmd = new SqlCommand("addCourse", sqlCon);
                sqlCmd.CommandType = CommandType.StoredProcedure;
                sqlCmd.Parameters.Add("@name", System.Data.SqlDbType.VarChar).Value = name;
                sqlCmd.Parameters.Add("@department", System.Data.SqlDbType.VarChar).Value = department;
                sqlCmd.Parameters.Add("@creditsApplied", System.Data.SqlDbType.Int).Value = credits;
                sqlCmd.ExecuteNonQuery();

                label1.Text = "Done!";
            }
            else
            {
                label1.Text = "did not work, try again";
            }
            
        }

        private void Department_TextChanged(object sender, EventArgs e)
        {

        }

        private void CreditsApplied_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
