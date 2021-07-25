using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace UI_FeePayment
{
    public partial class AdminDashboard : Form
    {
        public AdminDashboard()
        {
            InitializeComponent();
        }
        private void AdminDashboard_Load(object sender, EventArgs e)
        {
            AdDB.BackColor = Color.FromArgb(100, 0, 0, 0);
        }
        private void btnClass_Click(object sender, EventArgs e)
        {
            btnClass1hide.Hide();
            btnClass2hide.Hide();
            btnStc4ClassHide.Hide();
        }

        private void btnStudent_Click(object sender, EventArgs e)
        {
            btnStudent1hide.Hide();
            btnStudent2hide.Hide();
            btnStudent3hide.Hide();
        }

        private void ExitApp1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Logout_Click(object sender, EventArgs e)
        {
            Login ds = new Login();
            ds.Show();
            this.Hide();
        }


        private void btnStudent1Add_MouseClick(object sender, MouseEventArgs e)
        {
            AddStudent ds = new AddStudent();
            ds.Show();
            this.Hide();
        }

        private void btnStudent3_MouseClick(object sender, MouseEventArgs e)
        {
            DeleteStudent ds = new DeleteStudent();
            ds.Show();
            this.Hide();
        }

        private void btnClass1_MouseClick(object sender, MouseEventArgs e)
        {
            View_Details ds = new View_Details();
            ds.Show();
            this.Hide();
        }

        private void btnClass2_MouseClick(object sender, MouseEventArgs e)
        {
            ViewCollegeDetails ds = new ViewCollegeDetails();
            ds.Show();
            this.Hide();
        }

        private void btnStudent4Class_MouseClick(object sender, MouseEventArgs e)
        {
            ViewClassDetails ds = new ViewClassDetails();
            ds.Show();
            this.Hide();
        }

        private void btnStudent2_MouseClick(object sender, MouseEventArgs e)
        {
            EditStudent ds = new EditStudent();
            ds.Show();
            this.Hide();
        }

    }
}
