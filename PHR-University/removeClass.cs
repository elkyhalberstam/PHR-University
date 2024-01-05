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
    public partial class removeClass : Form
    {
        SqlConnection sqlCon = null;
        int adminID;
        int[] classIdList;
        int addDrop;
        int classID;

        public removeClass(int adminID)
        {
            InitializeComponent();
            CreateDatabaseConnection();
            //this.adminID = adminID;
        }

        private Boolean CreateDatabaseConnection()
        {
            try
            {
                /* get database parameters from App.config file */
                string strServer = ConfigurationManager.AppSettings["server"];
                string strDatabase = ConfigurationManager.AppSettings["database"];

                /* open a connection to database */
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

        private void removeClass_Load(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void selectSemester_(object sender, EventArgs e)
        {
            if (semesterComboBox.SelectedItem.ToString() != null)
            {
                String name = semesterComboBox.SelectedItem.ToString();
                Console.WriteLine(name);
                SqlCommand sqlCmd = new SqlCommand("getSemesterClasses", sqlCon);
                sqlCmd.CommandType = CommandType.StoredProcedure;
                sqlCmd.Parameters.Add("@semester", System.Data.SqlDbType.VarChar).Value = name;
                sqlCmd.ExecuteNonQuery();
                SqlDataAdapter da = new SqlDataAdapter(sqlCmd);
                DataSet dataset = new DataSet();
                da.Fill(dataset, "Classes");
                dataGridView1.AutoGenerateColumns = true;
                dataGridView1.DataSource = dataset.Tables["Classes"];
                dataGridView1.ColumnHeadersVisible = true;
                dataGridView1.RowHeadersVisible = false;

                foreach (DataGridViewColumn column in dataGridView1.Columns)
                {
                    column.Width = (dataGridView1.Width / 7); // Set the desired width
                }
            }
        }
        
        private void submitButton_Click(object sender, EventArgs e)
        {
            //drop from database aka archive it
            //selectClass.Refresh();
            semesterComboBox.Refresh();
            dataGridView1.Refresh();
        }

        private void semesterBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
