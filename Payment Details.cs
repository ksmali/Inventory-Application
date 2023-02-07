using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;

namespace WindowsFormsApplication1
{
    public partial class Payment_Details : Form
    {
        private OleDbConnection con = new OleDbConnection();
        public Payment_Details()
        {
            InitializeComponent();
            con.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\New folder\WindowsFormsApplication1\WindowsFormsApplication1\IEdatabase.accdb";
            this.Visible = true;
            
        }

        private void Payment_Details_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Payment p = new Payment();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            OleDbDataAdapter da = new OleDbDataAdapter("select * from payment", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Open();
            dataGridView1.DataSource = dt;
            con.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            PaymentDelete pd = new PaymentDelete();
            pd.ShowDialog();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            OleDbDataAdapter da = new OleDbDataAdapter("select * from payment", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Open();
            dataGridView1.DataSource = dt;
            con.Close();
        }
    }
}
