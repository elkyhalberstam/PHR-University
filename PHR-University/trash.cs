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
    public partial class AdminPage : Form
    {
        SqlConnection sqlCon = null;
        public AdminPage(int admin)
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
                string strConnect = "Server=DESKTOP-231318\\SQLEXPRESS;Database=SchoolSystem;Trusted_Connection=True;";
                //ML-RefVm-231318\\SQLEXPRESS

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

        private void homeLabel_Click(object sender, EventArgs e)
        {

        }

        private void menuRegistratiom_Click(object sender, EventArgs e)
        {

        }

        private void AmenuHome_Click(object sender, EventArgs e)
        {

        }

        private void AemailButton_Click(object sender, EventArgs e)
        {

        }

        private void AAcademicScheduleButton_Click(object sender, EventArgs e)
        {

        }
    }
}
