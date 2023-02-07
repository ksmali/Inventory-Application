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
    public partial class Payment : Form
    {
        private OleDbConnection con = new OleDbConnection();

        private OleDbCommand com = new OleDbCommand();

        public Payment()
        {
            con.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\New folder\WindowsFormsApplication1\WindowsFormsApplication1\IEdatabase.accdb";
            InitializeComponent();
            this.Visible = true;
        }
        private void cmbill()
        {
            con.Open();
            com.Connection = con;
            com.CommandText = "select * from bill";
            OleDbDataReader reader = com.ExecuteReader();
            while (reader.Read())
            {
                cbbid.Items.Add(reader["bid"].ToString());
            }
            reader.Close();
            con.Close();
        }
        private void loadbil()
        {

            string a = cbbid.SelectedItem.ToString();
            try
            {
                con.Open();
                com.Connection = con;
                com.CommandText = "select * from bill where bid ="+a;
                OleDbDataReader reader = com.ExecuteReader();
                while (reader.Read())
                {
                    string payamount = reader["totalcharge"].ToString();

                    payamounttxt.Text = payamount;
                    
                }
                reader.Close();
                con.Close();
            }
            catch
            {
                con.Close();
            }
        }

        private void Payment_Load(object sender, EventArgs e)
        {
            cmbill();
        }

        private void paytype_Click(object sender, EventArgs e)
        {

        }

      
        private void Save_Click(object sender, EventArgs e)
        {
            if (payidtxt.Text != ("") && dateTimePicker1.Text != ("") && cbbid.Text != ("") &&
                   payamounttxt.Text != ("") && cbpaytypetxt.Text != (""))
              try
            {
                con.Open();
                
                OleDbCommand cmd = new OleDbCommand();
                cmd.CommandText = "insert into payment (payid,paydate,bid,payamount,paytype) values (" + payidtxt.Text + ",'" + dateTimePicker1.Text + "'," + cbbid.Text + "," + payamounttxt.Text + ",'" + cbpaytypetxt.SelectedValue + "')";
                cmd.Connection = con;
              
                cmd.ExecuteNonQuery();
                MessageBox.Show("Data Saved");

                payidtxt.Text = "";
                dateTimePicker1.Text = "";
                cbbid.Text = "";
                payamounttxt.Text = "";
                cbpaytypetxt.Text = "";

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);


            }
            finally
            {
                con.Close();
            }
            else if (payidtxt.Text.Equals(""))
            {
                MessageBox.Show("Fill Payment ID");
            }
            else if (dateTimePicker1.Text.Equals(""))
            {
                MessageBox.Show("Fill Date");
            }
            else if (cbbid.Text.Equals(""))
            {
                MessageBox.Show("Fill Bill Id");
            }
            else if (payamounttxt.Text.Equals(""))
            {
                MessageBox.Show("Fill PayAmount");
            }
            else if (cbpaytypetxt.Text.Equals(""))
            {
                MessageBox.Show("Fill Payment Type ");

            }
                    
        }
        private void cbbid_SelectedIndexChanged(object sender, EventArgs e)
        {

            loadbil();
        }

        private void cbpaytypetxt_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        }
    }

