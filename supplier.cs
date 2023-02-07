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
    public partial class supplier : Form
    {
        private OleDbConnection con = new OleDbConnection();
    
        public supplier()
        {
            InitializeComponent();
            this.Visible = true;
        }

       

        private void button1_Click(object sender, EventArgs e)
        {
            if (sidtxt.Text != ("") && snametxt.Text != ("") && saddresstxt.Text != ("") &&
                scontactnotxt.Text != ("") && sproductnametxt.Text != ("") && sproductquantitytxt.Text != ("")
                && siecodetxt.Text != (""))
            {
                try
                {
                    con.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\New folder\WindowsFormsApplication1\WindowsFormsApplication1\IEdatabase.accdb";
                    con.Open();
                  
                   
                    string command = "insert into supplier(sid,sname,saddress,scontactno,sproductname,sproductquantity,siecode) values("
                     + sidtxt.Text + ",'" + snametxt.Text + "','" + saddresstxt.Text + "','" + scontactnotxt.Text + "','" + sproductnametxt.Text + "','"
                     + sproductquantitytxt.Text + "','" + siecodetxt.Text + "')";
                    
                    OleDbCommand com = new OleDbCommand(command, con);
                    int i = com.ExecuteNonQuery();
                    if (i == 1)
                        MessageBox.Show("Supplier Details saved" + i.ToString());

                    sidtxt.Text = "";
                    snametxt.Text = "";
                    saddresstxt.Text = "";
                    scontactnotxt.Text = "";
                    sproductnametxt.Text = "";
                    sproductquantitytxt.Text = "";
                    siecodetxt.Text = "";
                }
                catch(Exception exc) {
                    MessageBox.Show("Supplier Details saved" + exc.Message);
                }
                finally
                {
                    con.Close();
                }
            }

            else if (sidtxt.Text.Equals(""))
            {
                MessageBox.Show("Fill Supplier ID");
            }
            else if (snametxt.Text.Equals(""))
            {
                MessageBox.Show("Fill Supplier Name");
            }
            else if (saddresstxt.Text.Equals(""))
            {
                MessageBox.Show("Fill SupplierAddress");
            }
            else if (scontactnotxt.Text.Equals(""))
            {
                MessageBox.Show("Fill Supplier Contact Number");
            }
            else if (sproductname.Text.Equals(""))
            {
                MessageBox.Show("Fill Product Name ");
            }
            else if (sproductquantitytxt.Text.Equals(""))
            {
                MessageBox.Show("Fill Product Quantity");
            }
            else if (siecodetxt.Text.Equals(""))
            {
                MessageBox.Show("Fill SupplierProduct Price");
            }
        }
             private void button3_Click(object sender, EventArgs e)
        {
            main m = new main();
            m.ShowDialog();
        }

             private void snametxt_TextChanged(object sender, EventArgs e)
             {

             }

             private void sproductnametxt_TextChanged(object sender, EventArgs e)
             {

             }

             private void suppid_TextChanged(object sender, EventArgs e)
             {

             }

             private void groupBox1_Enter(object sender, EventArgs e)
             {

             }
             private void sid_Click(object sender, EventArgs e)
             {

             }

             private void supplier_Load(object sender, EventArgs e)
             {

             }

             private void scontactno_Click(object sender, EventArgs e)
             {

             }

             private void sproductname_Click(object sender, EventArgs e)
             {

             }

             private void sproductquantity_Click(object sender, EventArgs e)
             {

             }

             private void siecode_Click(object sender, EventArgs e)
             {

             }

             private void textBox7_TextChanged(object sender, EventArgs e)
             {

             }

             private void sidtxt_TextChanged(object sender, EventArgs e)
             {

             }
             

    }
}
