using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace UI_FeePayment
{
    public partial class EditStudent : Form
    {
        SqlConnection con = new SqlConnection("data source=MSI\\SQLEXPRESS; database=FeePayment; integrated security=True");
        SqlCommand cmd;
        SqlDataAdapter adpt;
        DataTable dt;
        int Stud;

        public EditStudent()
        {
            InitializeComponent();
            displayData();

        }

        private void EditStudent_Load(object sender, EventArgs e)
        {
        }

        private void dataGridViewedit_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Stud = Convert.ToInt32(dataGridViewedit.Rows[e.RowIndex].Cells[0].Value.ToString());
            txtRollNoE.Text = dataGridViewedit.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtNameE.Text = dataGridViewedit.Rows[e.RowIndex].Cells[2].Value.ToString();
            DeptE.Text = dataGridViewedit.Rows[e.RowIndex].Cells[3].Value.ToString();
            YearE.Text = dataGridViewedit.Rows[e.RowIndex].Cells[4].Value.ToString();
            SemE.Text = dataGridViewedit.Rows[e.RowIndex].Cells[5].Value.ToString();
            DivE.Text = dataGridViewedit.Rows[e.RowIndex].Cells[6].Value.ToString();
            txtYOAE.Text = dataGridViewedit.Rows[e.RowIndex].Cells[7].Value.ToString();
            SexE.Text = dataGridViewedit.Rows[e.RowIndex].Cells[8].Value.ToString();
            txtGuardianE.Text = dataGridViewedit.Rows[e.RowIndex].Cells[9].Value.ToString();
            txtEmailE.Text = dataGridViewedit.Rows[e.RowIndex].Cells[10].Value.ToString();
            txtMobileE.Text = dataGridViewedit.Rows[e.RowIndex].Cells[11].Value.ToString();
            txtGmobileE.Text = dataGridViewedit.Rows[e.RowIndex].Cells[12].Value.ToString();
            txtFeeE.Text = dataGridViewedit.Rows[e.RowIndex].Cells[13].Value.ToString();
            PaidE.Text = dataGridViewedit.Rows[e.RowIndex].Cells[14].Value.ToString();

        }

        private void dataGridViewedit_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridViewedit_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void StudentEditSave_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                cmd = new SqlCommand("update NewStudent set rollno='" + txtRollNoE.Text + "', stuname ='" + txtNameE.Text + "',dept='" + DeptE.Text + "' ,yr='" + YearE.Text + "',sem='" + SemE.Text + "' ,div ='" + DivE.Text + "',yoa='" + txtYOAE.Text + "', sex='" + SexE.Text + "', guarname ='" + txtGuardianE.Text + "',email='" + txtEmailE.Text + "', mobileno=" + txtMobileE.Text + " ,gmobile=" + txtGmobileE.Text + ", feeamt='" + txtFeeE.Text + "', paid='" + PaidE.Text + "' where  NAID=" + Stud + "", con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Your entry has been updated", "Data", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                con.Close();
                displayData();

            }
            catch (Exception r)
            {
                MessageBox.Show(r.ToString());
            }

        }
        public void displayData()
        {
            con.Open();
            adpt = new SqlDataAdapter("select * from NewStudent", con);
            dt = new DataTable();
            adpt.Fill(dt);
            dataGridViewedit.DataSource = dt;
            con.Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            AdminDashboard ds = new AdminDashboard();
            ds.Show();
            this.Hide();
        }
    }
}