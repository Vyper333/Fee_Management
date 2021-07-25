
namespace UI_FeePayment
{
    partial class DeleteStudent
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DeleteStudent));
            this.buttondel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxrno = new System.Windows.Forms.TextBox();
            this.dataGridViewdel = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewdel)).BeginInit();
            this.SuspendLayout();
            // 
            // buttondel
            // 
            this.buttondel.BackColor = System.Drawing.Color.Gold;
            this.buttondel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttondel.FlatAppearance.BorderSize = 0;
            this.buttondel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttondel.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttondel.Location = new System.Drawing.Point(570, 103);
            this.buttondel.Name = "buttondel";
            this.buttondel.Size = new System.Drawing.Size(101, 35);
            this.buttondel.TabIndex = 0;
            this.buttondel.Text = "Delete";
            this.buttondel.UseVisualStyleBackColor = false;
            this.buttondel.Click += new System.EventHandler(this.buttondel_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(176, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Enter Student Roll No.\r\n";
            // 
            // textBoxrno
            // 
            this.textBoxrno.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxrno.Location = new System.Drawing.Point(351, 106);
            this.textBoxrno.Name = "textBoxrno";
            this.textBoxrno.Size = new System.Drawing.Size(123, 26);
            this.textBoxrno.TabIndex = 4;
            // 
            // dataGridViewdel
            // 
            this.dataGridViewdel.BackgroundColor = System.Drawing.Color.LightGray;
            this.dataGridViewdel.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewdel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewdel.Location = new System.Drawing.Point(12, 174);
            this.dataGridViewdel.Name = "dataGridViewdel";
            this.dataGridViewdel.RowTemplate.Height = 25;
            this.dataGridViewdel.Size = new System.Drawing.Size(899, 217);
            this.dataGridViewdel.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Trebuchet MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(12, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(182, 29);
            this.label2.TabIndex = 6;
            this.label2.Text = "Delete Student";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Trebuchet MS", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(873, 10);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(38, 42);
            this.button1.TabIndex = 35;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // DeleteStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(923, 403);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridViewdel);
            this.Controls.Add(this.textBoxrno);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttondel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DeleteStudent";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DeleteStudent";
            this.Load += new System.EventHandler(this.DeleteStudent_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewdel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttondel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxrno;
        private System.Windows.Forms.DataGridView dataGridViewdel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
    }
}