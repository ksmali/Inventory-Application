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
    public partial class PaymentDelete : Form
    {
        private OleDbConnection con = new OleDbConnection();
        public PaymentDelete()
        {
            InitializeComponent();
            con.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\New folder\WindowsFormsApplication1\WindowsFormsApplication1\IEdatabase.accdb";
       
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            if (textBox1.Text != (""))
            {
                DialogResult rslt;
                rslt = MessageBox.Show("Are You sure want to Delete?", "Confirmation", MessageBoxButtons.YesNo);

                string str = "delete from payment where payid=@payid";
                OleDbCommand cmd = new OleDbCommand(str, con);
                cmd.Parameters.AddWithValue("@payid", textBox1.Text);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Record Successfully Deleted");

                textBox1.Text = "";

            }
            else if (textBox1.Text.Equals(""))
            {
                MessageBox.Show("Fill Payment ID");
            }
            this.Close();
        }

        private void PaymentDelete_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter_1(object sender, EventArgs e)
        {

        }
        }

       
    }

