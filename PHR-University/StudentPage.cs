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
        public StudentPage()
        {
            InitializeComponent();
            
        }

        private void helloToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void scheduleToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void StudentPage_Load(object sender, EventArgs e)
        {

        }

        private void academicToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void homeLabel_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Panel home = HomePannel;
            home.Show();
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
            Form courseSchedule = new courseSchedue();
            courseSchedule.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //trancript
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            //current grades
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            //graduation status
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
            Form addDrop = new addDropForm();
            addDrop.Show();
        }
    }
}
