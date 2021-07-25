using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Data.SqlClient;

namespace UI_FeePayment
{
    public partial class AddStudent : Form
    {
        public AddStudent()
        {
            InitializeComponent();
        }

    private void AddStudent_Load(object sender, EventArgs e)
        {
            panel1.BackColor = Color.FromArgb(100, 255, 255, 255);
        }
        private void label4_Click(object sender, EventArgs e)
        {

        }
        

        private void AddStuSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con1 = new SqlConnection();
                con1.ConnectionString = "data source=MSI\\SQLEXPRESS; database=FeePayment; integrated security=True";
                SqlCommand cmd1 = new SqlCommand("select * from NewStudent where rollno = '" + txtRollNo.Text + "'", con1);
                SqlDataAdapter da = new SqlDataAdapter(cmd1);
                DataSet ds1 = new DataSet();
                da.Fill(ds1);
                int i = ds1.Tables[0].Rows.Count;
                if (i > 0)
                {

                    MessageBox.Show("Roll No already exists");
                    txtRollNo.Clear();
                    txtName.Clear();
                    Dept.ResetText();
                    Year.ResetText();
                    Sem.ResetText();
                    Div.ResetText();
                    txtYOA.Clear();
                    Sex.ResetText();
                    txtGuardian.Clear();
                    txtEmail.Clear();
                    txtMobile.Clear();
                    txtGmobile.Clear();
                    txtFee.Clear();
                    Paid.ResetText();
                    // Exist
                }
                else
                {
                    String rollno = txtRollNo.Text;
                    String name = txtName.Text;
                    String dept = Dept.Text;
                    String year = Year.Text;
                    String sem = Sem.Text;
                    String div = Div.Text;
                    String yoa = txtYOA.Text;
                    String sex = Sex.Text;
                    String guarname = txtGuardian.Text;
                    String email = txtEmail.Text;
                    Int64 mobileno = Int64.Parse(txtMobile.Text);
                    Int64 gmobile = Int64.Parse(txtGmobile.Text);
                    String feeamt = txtFee.Text;
                    String paid = Paid.Text;

                    SqlConnection con = new SqlConnection();
                    con.ConnectionString = "data source=MSI\\SQLEXPRESS; database=FeePayment; integrated security=True";
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = con;
                    cmd.CommandText = "insert into NewStudent (rollno, stuname ,dept ,yr,sem ,div ,yoa, sex, guarname ,email, mobileno ,gmobile, feeamt, paid) values ('" + rollno + "','" + name + "','" + dept + "','" + year + "','" + sem + "','" + div + "','" + yoa + "','" + sex + "','" + guarname + "','" + email + "'," + mobileno + "," + gmobile + ",'" + feeamt + "','" + paid + "')";
                    SqlDataAdapter DA = new SqlDataAdapter(cmd);
                    DataSet DS = new DataSet();
                    DA.Fill(DS);
                    con.Close();
                    MessageBox.Show("Your entry has been recorded", "Data", MessageBoxButtons.OK, MessageBoxIcon.Hand);

                    txtRollNo.Clear();
                    txtName.Clear();
                    Dept.ResetText();
                    Year.ResetText();
                    Sem.ResetText();
                    Div.ResetText();
                    txtYOA.Clear();
                    Sex.ResetText();
                    txtGuardian.Clear();
                    txtEmail.Clear();
                    txtMobile.Clear();
                    txtGmobile.Clear();
                    txtFee.Clear();
                    Paid.ResetText();

                    // Add 
                }
            
            }
            catch (Exception r)
            {
                MessageBox.Show(r.ToString());

            }
            
        }

        private void buttonreset_Click(object sender, EventArgs e)
        {
            txtRollNo.Clear();
            txtName.Clear();
            Dept.ResetText();
            Year.ResetText();
            Sem.ResetText();
            Div.ResetText();
            txtYOA.Clear();
            Sex.ResetText();
            txtGuardian.Clear();
            txtEmail.Clear();
            txtMobile.Clear();
            txtGuardian.Clear();
            txtFee.Clear();
            Paid.ResetText();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AdminDashboard ds = new AdminDashboard();
            ds.Show();
            this.Hide();

        }

    }
}
