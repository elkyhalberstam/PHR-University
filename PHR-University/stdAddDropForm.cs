using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace PHR_University
{
    public partial class stdAddDropForm : Form
    {
        SqlConnection sqlCon = null;
        int studentID;
        int[] classIdList;
        int addDrop;
        int classID;
        public stdAddDropForm(int studentID)
        {
            InitializeComponent();
            createDataBaseConnection();
            this.studentID = studentID;
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

        private void addSelectChange(object sender, EventArgs e)
        {
            semesterSelect.Items.Clear();
            SqlCommand sqlCmd = new SqlCommand("getSemesterList", sqlCon);
            sqlCmd.CommandType = CommandType.StoredProcedure;
            sqlCmd.ExecuteNonQuery();
            SqlDataAdapter da = new SqlDataAdapter(sqlCmd);
            DataSet dataset = new DataSet();
            da.Fill(dataset, "Semester");
            sqlCmd.ExecuteNonQuery();


            for (int i = 0; i < dataset.Tables[0].Rows.Count; i++)
            {
                semesterSelect.Items.Add(dataset.Tables[0].Rows[i].ItemArray[0]);
            }
            addDrop = 1;
        }

        private void dropSelectChange(object sender, EventArgs e)
        {
            semesterSelect.Items.Clear();
            SqlCommand sqlCmd = new SqlCommand("getCurrentSemester", sqlCon);
            sqlCmd.CommandType = CommandType.StoredProcedure;
            sqlCmd.Parameters.Add("@studentID", System.Data.SqlDbType.VarChar).Value = studentID;
            sqlCmd.ExecuteNonQuery();
            SqlDataAdapter da = new SqlDataAdapter(sqlCmd);
            DataSet dataset = new DataSet();
            da.Fill(dataset, "Semester");
            sqlCmd.ExecuteNonQuery();


            for (int i = 0; i < dataset.Tables[0].Rows.Count; i++)
            {
                semesterSelect.Items.Add(dataset.Tables[0].Rows[i].ItemArray[0]);
            }

            addDrop = 0;
        }


        private void classSelectChange(object sender, EventArgs e)
        {
            classID = classIdList[classSelect.SelectedIndex];
        }

        private void semesterSelectChange(object sender, EventArgs e)
        {
            classSelect.Items.Clear();
            dataGridView1.Refresh();
            String semester = semesterSelect.SelectedItem.ToString();


            if (addSelect.Checked)
            {
                SqlCommand sqlCmd = new SqlCommand("getAllClassesInSemester", sqlCon);
                sqlCmd.CommandType = CommandType.StoredProcedure;
                sqlCmd.Parameters.Add("@semester", System.Data.SqlDbType.VarChar).Value = semester;
                sqlCmd.ExecuteNonQuery();
                SqlDataAdapter da = new SqlDataAdapter(sqlCmd);
                DataSet dataset = new DataSet();
                da.Fill(dataset, "Semester");
                sqlCmd.ExecuteNonQuery();

                int[] classIDs = new int[dataset.Tables[0].Rows.Count];

                for (int i = 0; i < dataset.Tables[0].Rows.Count; i++)
                {
                    classSelect.Items.Add(dataset.Tables[0].Rows[i].ItemArray[1]);
                    classIDs[i] = (int)dataset.Tables[0].Rows[i].ItemArray[0];
                }
                classIdList = classIDs;
            }
            else {
                SqlCommand sqlCmd = new SqlCommand("getStudentSchedule", sqlCon);
                sqlCmd.CommandType = CommandType.StoredProcedure;
                sqlCmd.Parameters.Add("@studentID", System.Data.SqlDbType.VarChar).Value = studentID;
                sqlCmd.Parameters.Add("@semester", System.Data.SqlDbType.VarChar).Value = semester;
                sqlCmd.ExecuteNonQuery();
                SqlDataAdapter da = new SqlDataAdapter(sqlCmd);
                DataSet dataset = new DataSet();
                da.Fill(dataset, "Semester");
                sqlCmd.ExecuteNonQuery();

                if (dataset.Tables[0].Rows.Count>0) { 
                int[] classIDs = new int[dataset.Tables[0].Rows.Count];

                for (int i = 0; i < dataset.Tables[0].Rows.Count; i++)
                {
                    classSelect.Items.Add(dataset.Tables[0].Rows[i].ItemArray[1]);
                    classIDs[i] = (int)dataset.Tables[0].Rows[i].ItemArray[0];
                }
                classIdList = classIDs;
                }
            }


            SqlCommand sqlCmd1 = new SqlCommand("getStudentSchedule", sqlCon);
            sqlCmd1.CommandType = CommandType.StoredProcedure;
            sqlCmd1.Parameters.Add("@studentID", System.Data.SqlDbType.VarChar).Value = studentID;
            sqlCmd1.Parameters.Add("@semester", System.Data.SqlDbType.VarChar).Value = semester;
            sqlCmd1.ExecuteNonQuery();
            SqlDataAdapter da1 = new SqlDataAdapter(sqlCmd1);
            DataSet dataset1 = new DataSet();
            da1.Fill(dataset1, "Classes");
            dataGridView1.AutoGenerateColumns = true;
            dataGridView1.DataSource = dataset1.Tables["Classes"];
            dataGridView1.ColumnHeadersVisible = true;
            dataGridView1.RowHeadersVisible = false;

            foreach (DataGridViewColumn column in dataGridView1.Columns)
            {
                column.Width = (dataGridView1.Width / 7); // Set the desired width
            }
        }

        private void submit_Click(object sender, EventArgs e)
        {
            if (classID != null && addDrop != null)
            {
                SqlCommand sqlCmd = new SqlCommand("addDropClassUpdate", sqlCon);
                sqlCmd.CommandType = CommandType.StoredProcedure;
                sqlCmd.Parameters.Add("@classID", System.Data.SqlDbType.VarChar).Value = classID;
                sqlCmd.Parameters.Add("@studentID", System.Data.SqlDbType.VarChar).Value = studentID;
                sqlCmd.ExecuteNonQuery();
                SqlDataAdapter da = new SqlDataAdapter(sqlCmd);
                DataSet dataset = new DataSet();
                da.Fill(dataset, "Semester");
                sqlCmd.ExecuteNonQuery();

                sqlCmd = new SqlCommand("addDropClassProcedure", sqlCon);
                sqlCmd.CommandType = CommandType.StoredProcedure;
                sqlCmd.Parameters.Add("@classID", System.Data.SqlDbType.VarChar).Value = classID;
                sqlCmd.Parameters.Add("@studentID", System.Data.SqlDbType.VarChar).Value = studentID;
                sqlCmd.Parameters.Add("@addDrop", System.Data.SqlDbType.VarChar).Value = addDrop;
                sqlCmd.ExecuteNonQuery();
                da = new SqlDataAdapter(sqlCmd);
                dataset = new DataSet();
                da.Fill(dataset, "Semester");
                sqlCmd.ExecuteNonQuery();
            }
            classSelect.Refresh();
            semesterSelect.Refresh();
            dataGridView1.Refresh();
        }
    }
}
