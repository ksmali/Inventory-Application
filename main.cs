using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class main : Form
    {
        public main()
        {
           InitializeComponent();
          this.Visible = true;
        }

        private void main_Load(object sender, EventArgs e)
        {

        }

        private void addProductToolStripMenuItem_Click(object sender, EventArgs e)
        {
            product f = new product();
           
        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            supplier f = new supplier();
            
            
        }

       private void toolStripComboBox1_Click(object sender, EventArgs e)
       {

        }

       private void billDetailToolStripMenuItem_Click(object sender, EventArgs e)
       {
           Bill_Details f = new Bill_Details();
       }

       private void addCustomerToolStripMenuItem_Click(object sender, EventArgs e)
       {
           importer f = new importer();
       }

       private void makeBillToolStripMenuItem_Click(object sender, EventArgs e)
       {
           Bill f = new Bill();
       }

       private void makePaymentToolStripMenuItem_Click(object sender, EventArgs e)
       {
           Payment f = new Payment();
       }

       private void sellerDetailsToolStripMenuItem_Click(object sender, EventArgs e)
       {
           
       }

       private void removeSupplierToolStripMenuItem_Click(object sender, EventArgs e)
       {
           SupplierDetails f = new SupplierDetails();
       }

       private void removeProductToolStripMenuItem_Click(object sender, EventArgs e)
       {
           Product_Details f = new Product_Details();
       }

       private void removeCustomerToolStripMenuItem_Click(object sender, EventArgs e)
       {
           Importer_Details f = new Importer_Details();
       
       }

       private void paymentDetailsToolStripMenuItem_Click(object sender, EventArgs e)
       {
           Payment_Details f = new Payment_Details();
       }

       private void viewReportToolStripMenuItem_Click(object sender, EventArgs e)
       {
           ViewReport vr = new ViewReport();
       }

       private void reportToolStripMenuItem1_Click(object sender, EventArgs e)
       {
           Report r = new Report();
       }

       private void dToolStripMenuItem1_Click(object sender, EventArgs e)
       {
           DocumentRequired dr = new DocumentRequired();
       }

       private void aToolStripMenuItem_Click(object sender, EventArgs e)
       {
           AboutBox1 ab = new AboutBox1();
       }

       private void productWeExportToolStripMenuItem_Click(object sender, EventArgs e)
       {
           Fruits f = new Fruits();
       }

       private void pictureBox1_Click(object sender, EventArgs e)
       {

       }



    }
}
