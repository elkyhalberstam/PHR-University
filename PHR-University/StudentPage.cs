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

        private void button1_Click_1(object sender, EventArgs e)
        {
            studnetHomePannel.Show();
            studentRegisratinPanel.Hide();
            studentAcademicPanel.Hide();
        }

        private void stdRegistrationMenue_click(object sender, EventArgs e)
        {
            
            studentRegisratinPanel.Show();
            studnetHomePannel.Hide();
            studentAcademicPanel.Hide();
            
        }

        private void stdAcademicsMenu_click(object sender, EventArgs e)
        {
            studentAcademicPanel.Show();
            studentRegisratinPanel.Hide();
            studnetHomePannel.Hide();
        }

        private void stdCourseSchedlue_click(object sender, EventArgs e)
        {
            Form courseSchedule = new stdCourseSchedue(studentID);
            courseSchedule.Show();
        }

        private void stdMinorMajor_click(object sender, EventArgs e)
        {
            Form majorMinorSchedule= new stdMajorMinorStatus(studentID);
            majorMinorSchedule.Show();
        }

        private void stdTranscript_Click(object sender, EventArgs e)
        {
            Form transcript = new stdTranscript(studentID);
            transcript.Show();
        }

        private void stdGraduationStatus_click(object sender, EventArgs e)
        {
            Form graduationStat= new stdGraduationStatus(studentID);
            graduationStat.Show();
        }

        private void stdLookUPclasses_Click(object sender, EventArgs e)
        {
            Form lookUp = new stdLookUpclasses();
            lookUp.Show();
        }

        private void stdAddDropButton_Click(object sender, EventArgs e)
        {
            Form addDrop = new stdAddDropForm(studentID);
            addDrop.Show();
        }

        private void StudentPage_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form courseSchedule = new stdCourseSchedue(studentID);
            courseSchedule.Show();
        }

        private void stdHomeMenu_Click(object sender, EventArgs e)
        {
            studentAcademicPanel.Hide();
            studentRegisratinPanel.Hide();
            studnetHomePannel.Show();
        }
    }
}
