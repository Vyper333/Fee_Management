using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;

namespace UI_FeePayment
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            AdminLogin.BackColor = Color.FromArgb(150, 255, 255, 255);
            StudentLogin.BackColor = Color.FromArgb(150, 255, 255, 255);
            AdLog.BackColor = Color.FromArgb(200, 0, 0, 0);
            StudLog.BackColor = Color.FromArgb(200, 0, 0, 0);
            AdLog.Hide();
            StudLog.Hide();
            StdPw.UseSystemPasswordChar = true;
            AdPw.UseSystemPasswordChar = true;
        }

        private void AdminLogin_MouseClick(object sender, MouseEventArgs e)
        {
            AdLog.Show();
            StudentLogin.Hide();
        }

        private void StudentLogin_MouseClick(object sender, MouseEventArgs e)
        {
            StudLog.Show();
            AdminLogin.Hide();
        }

        private void StdLogBtn_Click(object sender, EventArgs e)
        {
            if (StdTxt.Text == "Student" && StdPw.Text == "1234")
            {
                StudentDashboard ds = new StudentDashboard();
                ds.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid Credentials");
            }
        }
        private void StdLogBtn_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && (StdTxt.Text == "Student" && StdPw.Text == "1234"))
            {
                StudentDashboard ds = new StudentDashboard();
                ds.Show();
                this.Hide();
            }
            else if (e.KeyCode == Keys.Enter && !(StdTxt.Text == "Student" && StdPw.Text == "1234"))
            {
                MessageBox.Show("Invalid Credentials");
            }
        }

        private void AdLogBtn_Click(object sender, EventArgs e)
        {
            if (AdTxt.Text == "Admin" && AdPw.Text == "1234")
            {
                AdminDashboard ds = new AdminDashboard();
                ds.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid Credentials");
            }
        }
        private void AdLogBtn_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && (StdTxt.Text == "Admin" && StdPw.Text == "1234"))
            {

                AdminDashboard ds = new AdminDashboard();
                ds.Show();
                this.Hide();
            }
            else if (e.KeyCode == Keys.Enter && !(StdTxt.Text == "Admin" && StdPw.Text == "1234"))
            {
                MessageBox.Show("Invalid Credentials");
            }
        }

        private void BackStudLog_Click(object sender, EventArgs e)
        {
            StudLog.Hide();
            AdminLogin.Show();
        }

        private void BackAdLog_Click(object sender, EventArgs e)
        {
            AdLog.Hide();
            StudentLogin.Show();
        }

        private void ExitApp1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

         

private void ShowStdPw_CheckedChanged(object sender, EventArgs e)
        {
            if (ShowStdPw.Checked == true)
            {
                StdPw.UseSystemPasswordChar = false;
            }
            else
            {
                StdPw.UseSystemPasswordChar = true;
            }
        }

        private void ShowAdPw_CheckedChanged(object sender, EventArgs e)
        {
            if (ShowAdPw.Checked == true)
            {
                AdPw.UseSystemPasswordChar = false;
            }
            else
            {
                AdPw.UseSystemPasswordChar = true;
            }
        }

        private void Website_MouseClick(object sender, MouseEventArgs e)
        {
            Process.Start(new ProcessStartInfo("http://www.dbcegoa.ac.in") { UseShellExecute = true });
        }

        private void LinkedIn_MouseClick(object sender, MouseEventArgs e)
        {
            Process.Start(new ProcessStartInfo("https://www.linkedin.com/school/don-bosco-college-of-engineering-fatorda-goa") { UseShellExecute = true });
        }

        private void Fb_MouseClick(object sender, MouseEventArgs e)
        {
            Process.Start(new ProcessStartInfo("https://www.facebook.com/profile.php?id=100064220854358") { UseShellExecute = true });
        }
    }
}
