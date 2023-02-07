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
    public partial class ViewReport : Form
    {
        private OleDbConnection con = new OleDbConnection();

        public ViewReport()
        {
            InitializeComponent();
            this.Visible = true;
        }

        private void ViewReport_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DataSet1.bill' table. You can move, or remove it, as needed.
           // this.billTableAdapter.Fill(this.DataSet1.bill);

            //this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
        }
       
        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           // this.billTableAdapter.Fill(this.DataSet1.bill,dateTimePicker1.Value.ToShortDateString(),dateTimePicker2.Value.ToShortDateString());

         //   this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load_1(object sender, EventArgs e)
        {

        }
    }
}
