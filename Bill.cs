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
    public partial class Bill : Form
    {
        private OleDbConnection con = new OleDbConnection();
        private OleDbCommand com = new OleDbCommand();
        private OleDbCommand com1 = new OleDbCommand();

        public Bill()
        {
            con.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\New folder\WindowsFormsApplication1\WindowsFormsApplication1\IEdatabase.accdb";
            InitializeComponent();
            this.Visible = true;
        }
        private void import()
        {
            con.Open();
            com.Connection = con;
            com.CommandText = "select * from customer";

            OleDbDataReader reader = com.ExecuteReader();
            while (reader.Read())
            {
                cbiid.Items.Add(reader["cid"].ToString());

            }
            reader.Close();
            con.Close();
        }

        private void loadcustomer()
        {

            string c = cbiid.SelectedItem.ToString();

            try
            {
                con.Open();
                com.Connection = con;
                com.CommandText = "select * from customer where cid="+c;
                OleDbDataReader reader = com.ExecuteReader();
                while (reader.Read())
                {
                    string cname = reader["cname"].ToString();
                    string ciecode = reader["ciecode"].ToString();
                    string cport = reader["cport"].ToString();

                    cnametxt.Text = cname;
                    ciecodetxt.Text = ciecode;
                    cportofdischargetxt.Text = cport;


                }

                reader.Close();
                con.Close();
            }
            catch
            {
                con.Close();
            }
        }



        private void product()
        {
            con.Open();
            com1.Connection = con;
            com1.CommandText = "select * from product";
            OleDbDataReader reader = com1.ExecuteReader();
            while (reader.Read())
            {
                cbpid.Items.Add(reader["pid"].ToString());
            }
            reader.Close();
            con.Close();
        }

        private void loadproduct()
        {

            string d = cbpid.SelectedItem.ToString();
            try
            {
                con.Open();
                com1.Connection = con;
                com1.CommandText = "select * from product where pid ="+d;
                OleDbDataReader reader = com1.ExecuteReader();
                while (reader.Read())
                {
                    string pname = reader["pname"].ToString();
                    string pprice = reader["pprice"].ToString();
                    string pquantity = reader["pquantity"].ToString();


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
            finally
            {
                con.Close();
            }
        }







        private void label1_Click(object sender, EventArgs e)
        {

        }




        private void grossweightkg_Click(object sender, EventArgs e)
        {

        }

        private void vesselnametxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void cportofdischargetxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void Save_Click(object sender, EventArgs e)
        {
            if (bidtxt.Text != ("") && dateTimePicker1.Text != ("") && cbiid.Text != ("") &&cnametxt.Text != ("")&&
        ciecodetxt.Text != ("") && cportofdischargetxt.Text != ("") && cbpid.Text != ("") && pnametxt.Text != ("")
              && ppricetxt.Text != ("") && pquantitytxt.Text != ("") && portofloadingtxt.Text != ("") && grossweightkgtxt.Text != ("") 
              && vesselnametxt.Text != ("") && totalchargetxt.Text != (""))
            try
            {
                con.Open();
                com.Connection = con;
                com.CommandText = "insert into bill(bid,bdate,cid,cname,ciecode,cport,pid,pname,pprice,pquantity,portofloading,grossweightkg,vesselname,totalcharge) values(" + bidtxt.Text +",'"+ dateTimePicker1 .Text+ "'," + cbiid.Text + ",'" + cnametxt.Text + "'," + ciecodetxt.Text + ",'" + cportofdischargetxt.Text + " ',  " + cbpid.Text + ",'" + pnametxt.Text + "'," + ppricetxt.Text + "," + pquantitytxt.Text + ",'" + portofloadingtxt.Text + "'," + grossweightkgtxt.Text + ",'" + vesselnametxt.Text + "'," + totalchargetxt.Text + ")";
                com.ExecuteNonQuery();

                MessageBox.Show("Data Saved");
                bidtxt.Text = "";
                dateTimePicker1.Text = "";
                cbiid.Text = "";
                cnametxt.Text = "";
                ciecodetxt.Text = "";
                cportofdischargetxt.Text = "";
                cbpid.Text = "";
                pnametxt.Text = "";
                ppricetxt.Text = "";
                pquantitytxt.Text = "";
                portofloadingtxt.Text = "";
                grossweightkgtxt.Text = "";
                vesselnametxt.Text = "";
                totalchargetxt.Text = "";

                

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);


            }
            finally
            {
                con.Close();
            }
        
            else if (bidtxt.Text.Equals(""))
            {
                MessageBox.Show("Fill Bill ID");
            }
            else if (dateTimePicker1.Text.Equals(""))
            {
                MessageBox.Show("Fill Date ");
            }
            else if (cbiid.Text.Equals(""))
            {
                MessageBox.Show("Fill Importer Id");
            }
            else if (cnametxt.Text.Equals(""))
            {
                MessageBox.Show("Fill Importer Name");
            }
            else if (ciecodetxt.Text.Equals(""))
            {
                MessageBox.Show("Fill IE Code  ");
            }
            else if (cportofdischargetxt.Text.Equals(""))
            {
                MessageBox.Show("Fill Port of Discharge");
            }

            else if (cbpid.Text.Equals(""))
            {
                MessageBox.Show("Fill Product Id");
            }
            else if (pnametxt.Text.Equals(""))
            {
                MessageBox.Show("Fill Product Name");
            }
            else if (ppricetxt.Text.Equals(""))
            {
                MessageBox.Show("Fill Product Price");
            }

            else if (pquantitytxt.Text.Equals(""))
            {
                MessageBox.Show("Fill Importer IE Code");
            }
            else if (portofloadingtxt.Text.Equals(""))
            {
                MessageBox.Show("FillPort of Loading   ");
            }
            else if (grossweightkgtxt.Text.Equals(""))
            {
                MessageBox.Show("Fill Gross Weight in Kg");
            }


            else if (vesselnametxt.Text.Equals(""))
            {
                MessageBox.Show("Fill Vessel Name");
            }
            else if (totalchargetxt.Text.Equals(""))
            {
                MessageBox.Show("Fill Total Charge");
            }
        }



        private void Bill_Load(object sender, EventArgs e)
        {
            import();
            product();
            
          //  DateTime dt = dateTimePicker1.Value.Date;
           // textBox1.Text = dt.Month + "/" + dt.Day + "/" + dt.Year;
            
        }
        

       

       

        private void bidtxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void ciecodetxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            //DateTime dt = dateTimePicker1.Value.Date;
            //textBox1.Text = dt.Month + "/" + dt.Day + "/" + dt.Year;


        }

        private void cbiid_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadcustomer();
        }

        private void cbpid_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadproduct();
        }

        private void pquantity_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

       

    }
}
