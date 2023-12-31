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
    public partial class ProfessorPage : Form
    {
        int TeacherID; 
        public ProfessorPage(int teacherID)
        {
            InitializeComponent();
            TeacherID = teacherID;
        }

        private void ProfessorPage_Load(object sender, EventArgs e) { }

        private void HomeTextLabel_Click(object sender, EventArgs e)
        {

        }

        private void EmailButton_Click(object sender, EventArgs e)
        {

        }

        private void CurrentSchedButton_Click(object sender, EventArgs e)
        {
            //current classes professor is supposed to teach 
        }

        private void AcademicSchedButton_Click(object sender, EventArgs e)
        {

        }

        private void MenuHomeButton_Click(object sender, EventArgs e)
        {
            HomePanel.Show();
            ProfessorGradesPanel.Hide();
            ProfessorAssignmentsPanel.Hide();
           
        }

        private void MenuGradesButton_Click(object sender, EventArgs e)
        {
            HomePanel.Hide();
            ProfessorAssignmentsPanel.Hide();
            ProfessorGradesPanel.Show();

        }

        private void MenuRosterButton_Click(object sender, EventArgs e)
        {
            HomePanel.Hide();
            ProfessorGradesPanel.Hide();
            ProfessorAssignmentsPanel.Hide();

        }

        private void MenuAssignmentsButton_Click(object sender, EventArgs e)
        {
            HomePanel.Hide();
            ProfessorGradesPanel.Hide();
            ProfessorAssignmentsPanel.Show();
        }
        private void ViewGradesButton_Click(object sender, EventArgs e)
        {

        }
        private void HomePanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ProfessorGradesPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ProfessorGradesLabel_Click(object sender, EventArgs e)
        {

        }

        private void ProfessorPage_FormClosing(object sender, FormClosingEventArgs e)
        {
           Application.Exit();
        }
    }
}
