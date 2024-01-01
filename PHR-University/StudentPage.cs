using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PHR_University
{
    public partial class StudentPage : Form
    {
        int studentID;
        public StudentPage(int studentID)
        {
            InitializeComponent();
            this.studentID = studentID;
        }

        private void StudentPage_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            HomePannel.Show();
            
            HomePannel.Visible = true;
            regisratinPanel.Hide();
            academicPanel.Hide();
           
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void menuRegistratiom_Click(object sender, EventArgs e)
        {
            
            regisratinPanel.Show();
            HomePannel.Hide();
            academicPanel.Hide();
            
        }

        private void menueAcademics_Click(object sender, EventArgs e)
        {
            academicPanel.Show();
            regisratinPanel.Hide();
            HomePannel.Hide();




        }

        private void courseButton_Click(object sender, EventArgs e)
        {
            //Form courseSchedule = new courseSchedue();
            //courseSchedule.Show();
        }

        private void courseButton_Click_1(object sender, EventArgs e)
        {
            Form courseSchedule = new courseSchedue(studentID);
            courseSchedule.Show();
        }

        private void minorMajor_click(object sender, EventArgs e)
        {
            Form majorMinorSchedule= new majorMinorSchedule(studentID);
            majorMinorSchedule.Show();
        }

        private void transcript_Click(object sender, EventArgs e)
        {
            Form transcript = new transcript(studentID);
            transcript.Show();
        }

        private void graduationStatus_click(object sender, EventArgs e)
        {
            Form graduationStat= new graduationStatus(studentID);
            graduationStat.Show();
        }

        private void lookUPclasses_Click(object sender, EventArgs e)
        {
            //look up classes
            Form lookUp = new lookUpclasses();
            lookUp.Show();
        }

        private void addDropButton_Click(object sender, EventArgs e)
        {
            //add/drop button
            Form addDrop = new addDropForm(studentID);
            addDrop.Show();
        }

        private void StudentPage_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form courseSchedule = new courseSchedue(studentID);
            courseSchedule.Show();
        }

        private void HomeMenu_Click(object sender, EventArgs e)
        {
            academicPanel.Hide();
            regisratinPanel.Hide();
            HomePannel.Show();
        }

        private void HomePannel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
