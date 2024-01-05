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
    public partial class ARegistration : Form
    {
        int adminID;
        int semesterID;
        public ARegistration(int admin)
        {
            InitializeComponent();
            adminID = admin;
        }

        private void ARegistration_Load(object sender, EventArgs e)
        {
            InitializeComponent();
        }

        private void homeLabel_Click(object sender, EventArgs e)
        {

        }

        private void AMenuHome_Click(object sender, EventArgs e)
        {
            ARegistartionPanel.Hide();
            AdminHomePanel.Show();
        }

        private void ACourseSchedule_Click(object sender, EventArgs e)
        {
            //show the entire list of courses including dates, times, location and professor
            Form courseList = new courseList();
            courseList.Show();
        }

        private void AdminAddDropButton_Click(object sender, EventArgs e)
        {
            //open add/drop form
            //need to be able to add drop people and classes
            //get classID, either remove or add
            Form addClass = new addClassForm(adminID);
            addClass.Show();
            //Form classForm = new removeClass(adminID);
            //classForm.Show();

        }

        private void ARegistartionAssignClassesButton_Click(object sender, EventArgs e)
        {
            //assign class and room
        }

        private void AMenuRegistration_Click(object sender, EventArgs e)
        {
            ARegistartionPanel.Show();
            AdminHomePanel.Hide();
        }

        private void AEmailButton_Click_1(object sender, EventArgs e)
        {
            //open new email form
            Form showEmail = new AEmailForm();
            showEmail.Show();
        }

        private void AAcademicButton_Click(object sender, EventArgs e)
        {
            //show the academic form (any info?)
            Form showAcademicForm = new AAcademicSchedule();
            showAcademicForm.Show();
        }

        private void ARegistartionPannel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void AdminHomePanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dropButton_Click(object sender, EventArgs e)
        {
            Form removeClassForm = new removeClass(adminID);
            removeClassForm.Show();
        }
    }
}
