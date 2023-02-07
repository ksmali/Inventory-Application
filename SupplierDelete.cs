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
    public partial class SupplierDelete : Form
    {
        private OleDbConnection con = new OleDbConnection();
        public SupplierDelete()
        {
            InitializeComponent();
            con.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\New folder\WindowsFormsApplication1\WindowsFormsApplication1\IEdatabase.accdb";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            if  (textBox1.Text != (""))
            {
                DialogResult rslt;
                rslt = MessageBox.Show("Are You sure want to Delete?", "Confirmation", MessageBoxButtons.YesNo);

                string str = "delete from supplier where sid=@sid";
                OleDbCommand cmd = new OleDbCommand(str, con);
                cmd.Parameters.AddWithValue("@sid", textBox1.Text);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Record Successfully Deleted");

                textBox1.Text = "";

            }
            else if (textBox1.Text.Equals(""))
            {
                MessageBox.Show("Fill Supplier ID");
            }
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void SupplierDelete_Load(object sender, EventArgs e)
        {

        }
    }
}
