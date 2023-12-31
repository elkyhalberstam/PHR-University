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
        public ProfessorPage()
        {
            InitializeComponent();
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
           // HomePanel.Visible = true;
            ProfessorGradesPanel.Hide();
           // ProfessorRosterPanel.Hide();
            ProfessorAssignmentsPanel.Hide();
           
        }

        private void MenuGradesButton_Click(object sender, EventArgs e)
        {
            HomePanel.Hide();
            ProfessorAssignmentsPanel.Hide();
           // ProfessorRosterPanel.Hide();
            ProfessorGradesPanel.Show();

        }

        private void MenuRosterButton_Click(object sender, EventArgs e)
        {
            HomePanel.Hide();
            ProfessorGradesPanel.Hide();
            ProfessorAssignmentsPanel.Hide();
            //ProfessorRosterPanel.Show();

        }

        private void MenuAssignmentsButton_Click(object sender, EventArgs e)
        {
            //ProfessorRosterPanel.Hide();
            HomePanel.Hide();
            ProfessorGradesPanel.Hide();
            ProfessorAssignmentsPanel.Show();
        }
        private void ViewGradesButton_Click(object sender, EventArgs e)
        {

        }

        //private void MenuRosterButtonNEW_Click(object sender, EventArgs e)
        //{
        //    ProfessorRosterPanel.Show();
        //    HomePanel.Hide();
        //    ProfessorGradesPanel.Hide();
        //    ProfessorAssignmentsPanel.Hide();
        //}

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
