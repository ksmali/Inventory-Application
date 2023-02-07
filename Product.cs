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
    public partial class product : Form
    {
        private OleDbConnection con = new OleDbConnection();
        private OleDbCommand com = new OleDbCommand();

        public product()
        {
            con.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\New folder\WindowsFormsApplication1\WindowsFormsApplication1\IEdatabase.accdb";
            InitializeComponent();
            this.Visible = true;
        }
        private void cmsid()
        {
            con.Open();
            com.Connection = con;
            com.CommandText = "select * from supplier";
            OleDbDataReader reader = com.ExecuteReader();
            while (reader.Read())
            {
                cbsid.Items.Add(reader["sid"].ToString());
            }
            reader.Close();
            con.Close();
        }
        private void loadtxt()
        {
            
            string a= cbsid.SelectedItem.ToString();
            try
            {
                con.Open();
                com.Connection = con;
                com.CommandText = "select * from supplier where sid ="+a;
                OleDbDataReader reader = com.ExecuteReader();
                while (reader.Read())
                {
                    string pname = reader["sproductname"].ToString();
                    string pprice = reader["sproductquantity"].ToString();
                    string pquantity = reader["siecode"].ToString();


                    pnametxt.Text = pname;
                    ppricetxt.Text = pprice;
                    pquantitytxt.Text = pquantity;
                }
                reader.Close();
                con.Close();
            }
            catch
            {
                con.Close();
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            if (pidtxt.Text != ("") && cbsid.Text != ("") && pnametxt.Text != ("") &&
                   ppricetxt.Text != ("") && pquantitytxt.Text != (""))
            
            try
            {
                con.Open();
                com.Connection = con;
                com.CommandText = "insert into product(pid,sid,pname,pprice,pquantity) values(" + pidtxt.Text + "," + cbsid.Text + ",'" + pnametxt.Text + "'," + ppricetxt.Text + "," + pquantitytxt.Text + ")";
                com.ExecuteNonQuery();

                MessageBox.Show("Product Details saved");
                pidtxt.Text = "";
                cbsid.Text = "";
                pnametxt.Text = "";
                ppricetxt.Text = "";
                pquantitytxt.Text = "";
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Product Details saved" + ex.Message);
                

            }
            finally
            {
                con.Close();
            }
        
        else if (pidtxt.Text.Equals(""))
            {
                MessageBox.Show("Fill Supplier ID");
            }
            else if (cbsid.Text.Equals(""))
            {
                MessageBox.Show("Fill Supplier Name");
            }
            else if (pnametxt.Text.Equals(""))
            {
                MessageBox.Show("Fill SupplierAddress");
            }
            else if (ppricetxt.Text.Equals(""))
            {
                MessageBox.Show("Fill Supplier Contact Number");
            }
            else if (pquantitytxt.Text.Equals(""))
            {
                MessageBox.Show("Fill Product Name ");
            }
           
}

        private void Product_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'iEdatabaseDataSet.product' table. You can move, or remove it, as needed.
            this.productTableAdapter.Fill(this.iEdatabaseDataSet.product);
            // TODO: This line of code loads data into the 'iEdatabaseDataSet1.supplier' table. You can move, or remove it, as needed.
            this.supplierTableAdapter1.Fill(this.iEdatabaseDataSet1.supplier);
            // TODO: This line of code loads data into the 'iEdatabaseDataSet.supplier' table. You can move, or remove it, as needed.
            this.supplierTableAdapter.Fill(this.iEdatabaseDataSet.supplier);
            cmsid();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadtxt();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            main m = new main();
            m.ShowDialog();
        }

        private void pidtxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void pquantity_Click(object sender, EventArgs e)
        {

        }
        private void sid_Click(object sender, EventArgs e)
        {

        }

        private void pprice_Click(object sender, EventArgs e)
        {

        }


    }
}
