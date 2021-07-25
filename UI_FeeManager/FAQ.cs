using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace UI_FeePayment
{
    public partial class FAQ : Form
    {
        public FAQ()
        {
            InitializeComponent();
        }
        private void FAQ_Load(object sender, EventArgs e)
        {
            FAQPanel.BackColor = Color.FromArgb(100, 255, 255, 255);
        }
        private void button2_Click(object sender, EventArgs e)
        {
            StudentDashboard ds = new StudentDashboard();
            ds.Show();
            this.Hide();
        }

      
    }
}
