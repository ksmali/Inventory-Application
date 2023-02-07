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
    public partial class Login : Form
    { 
       
        public Login()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        
            {
            checklogin();
        }
        private void checklogin()
        {
            
            int count = 0;
            try
            {
                OleDbConnection con = new OleDbConnection();
                OleDbCommand com = new OleDbCommand();
                con.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=IEDatabase.accdb";
                con.Open();
                com.Connection = con;
                string query = "select * from Login where ID='" +textBox1.Text + "' and pwd='" + textBox2.Text + "'";
                com.CommandText = query;
                OleDbDataReader reader = com.ExecuteReader();
                while (reader.Read())
                {
                    count++;
                }
                if (count == 1)
                {
                    MessageBox.Show("Login Successful", "Success");
                    main f = new main();
                    this.Show();
                  
                }
                else
                {
                    textBox2.SelectionStart = 0;
                   textBox2.SelectionLength =textBox2.Text.Length;
                    MessageBox.Show("Wrong ID/Password!", "Invalid Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
              
               
                reader.Close();
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

            }
        }
        


