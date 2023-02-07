using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Globalization;

namespace WindowsFormsApplication1
{
    public partial class Report : Form
    {
        private OleDbConnection con = new OleDbConnection();
        private OleDbCommand com = new OleDbCommand();

        public Report()
        {
            InitializeComponent();
            this.Visible = true;
            con.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\New folder\WindowsFormsApplication1\WindowsFormsApplication1\IEdatabase.accdb";
            
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            con.Open();
            com.Connection = con;

            com.CommandText = "select * from bill where date between( '" + dateTimePicker1.Text + "' and'" + dateTimePicker2.Text + "'";
          com.ExecuteNonQuery();
                MessageBox.Show("hiii");

            dataGridView1.DataSource = con;
            con.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            OleDbDataAdapter da = new OleDbDataAdapter("select * from bill where date between '" + dateTimePicker1.Text + "' to '" + dateTimePicker2.Text + "'", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Open();
            dataGridView1.DataSource = dt;
            con.Close();
        }

        private void Report_Load(object sender, EventArgs e)
        {

            
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
