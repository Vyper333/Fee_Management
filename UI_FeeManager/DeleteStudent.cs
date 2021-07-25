using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Data.SqlClient;

namespace UI_FeePayment
{
    public partial class DeleteStudent : Form
    {
        SqlConnection con1 = new SqlConnection("data source=MSI\\SQLEXPRESS; database=FeePayment; integrated security=True");
        SqlDataAdapter adpt1;
        DataTable dt1;

        public DeleteStudent()
        {
            InitializeComponent();
            displayData();
        }

        private void DeleteStudent_Load(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "data source=MSI\\SQLEXPRESS; database=FeePayment; integrated security=True";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "select * from NewStudent";
                SqlDataAdapter DA = new SqlDataAdapter(cmd);
                DataSet DS = new DataSet();
                DA.Fill(DS);
                dataGridViewdel.DataSource = DS.Tables[0];
                con.Close();

            }
            catch (Exception r)
            {
                MessageBox.Show(r.ToString());

            }
        }

        private void buttondel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete the record?", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "data source=MSI\\SQLEXPRESS; database=FeePayment; integrated security=True";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "delete from NewStudent where rollno =" + textBoxrno.Text + "";
                SqlDataAdapter DA = new SqlDataAdapter(cmd);
                DataSet DS = new DataSet();
                DA.Fill(DS);
                //dataGridViewdel.DataSource = DS.Tables[0];
                con.Close();
                displayData();
                textBoxrno.Text = "";

                MessageBox.Show("Student Record Deleted", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {

            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminDashboard ds = new AdminDashboard();
            ds.Show();
        }
        public void displayData()
        {
            con1.Open();
            adpt1 = new SqlDataAdapter("select * from NewStudent", con1);
            dt1 = new DataTable();
            adpt1.Fill(dt1);
            dataGridViewdel.DataSource = dt1;
            con1.Close();

        }
    }
}