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
    public partial class Importer_Details : Form
    {
        private OleDbConnection con = new OleDbConnection();
        public Importer_Details()
        {
            InitializeComponent();
            con.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\New folder\WindowsFormsApplication1\WindowsFormsApplication1\IEdatabase.accdb";
            this.Visible = true;
        }

        private void Importer_Details_Load(object sender, EventArgs e)
        {

        }

    
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            OleDbDataAdapter da = new OleDbDataAdapter("select * from customer", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Open();
            dataGridView1.DataSource = dt;
            con.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            importer f = new importer();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ImporterDelete f = new ImporterDelete();
            f.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OleDbDataAdapter da = new OleDbDataAdapter("select * from customer", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Open();
            dataGridView1.DataSource = dt;
            con.Close();
        }
    }
}
