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
    public partial class importer : Form
    {
        private OleDbConnection con = new OleDbConnection();
        public importer()
        {
            InitializeComponent();
            this.Visible = true;
        }

        private void cid_Click(object sender, EventArgs e)
        {

        }

        private void Save_Click(object sender, EventArgs e)
        {
            if (cidtxt.Text != ("") && cnametxt.Text != ("") && caddresstxt.Text != ("") &&
               ciecodetxt.Text != ("") && cportofdischargetxt.Text != (""))
            {
                try
                {
              con.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\New folder\WindowsFormsApplication1\WindowsFormsApplication1\IEdatabase.accdb";
              con.Open();
                   string command = "insert into customer(cid,cname,caddress,ciecode,cport) values(" 
                        + cidtxt.Text + ",'" + cnametxt.Text + "','" + caddresstxt.Text + "'," + ciecodetxt.Text + ",'" + cportofdischargetxt.Text + "')";

                    OleDbCommand com = new OleDbCommand(command, con);

                    int i = com.ExecuteNonQuery();
                    if (i == 1)
                        MessageBox.Show("Importer Details saved" + i.ToString());

                    cidtxt.Text = "";
                    cnametxt.Text = "";
                    caddresstxt.Text = "";
                    ciecodetxt.Text = "";
                    cportofdischargetxt.Text = "";
                }
                catch (Exception exc)
                {
                    MessageBox.Show(exc.Message);
                }
                finally
                {
                    con.Close();
                }
            }
            else if (cidtxt.Text.Equals(""))
            {
                MessageBox.Show("Fill Importer ID");
            }
            else if (cnametxt.Text.Equals(""))
            {
                MessageBox.Show("Fill Importer Name");
            }
            else if (caddresstxt.Text.Equals(""))
            {
                MessageBox.Show("Fill Importer Address");
            }
            else if (ciecodetxt.Text.Equals(""))
            {
                MessageBox.Show("Fill Importer IE Code");
            }
            else if (cportofdischargetxt.Text.Equals(""))
            {
                MessageBox.Show("Fill Customer Port of Discharge ");
            }
        }
    
    

        private void importer_Load(object sender, EventArgs e)
        {

            
        }
    }
}
