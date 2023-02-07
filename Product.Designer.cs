namespace WindowsFormsApplication1
{
    partial class product
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.pid = new System.Windows.Forms.Label();
            this.sid = new System.Windows.Forms.Label();
            this.pname = new System.Windows.Forms.Label();
            this.pprice = new System.Windows.Forms.Label();
            this.pquantity = new System.Windows.Forms.Label();
            this.pidtxt = new System.Windows.Forms.TextBox();
            this.pnametxt = new System.Windows.Forms.TextBox();
            this.ppricetxt = new System.Windows.Forms.TextBox();
            this.pquantitytxt = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.cbsid = new System.Windows.Forms.ComboBox();
            this.iEdatabaseDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.iEdatabaseDataSet = new WindowsFormsApplication1.IEdatabaseDataSet();
            this.supplierBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.supplierTableAdapter = new WindowsFormsApplication1.IEdatabaseDataSetTableAdapters.supplierTableAdapter();
            this.iEdatabaseDataSet1 = new WindowsFormsApplication1.IEdatabaseDataSet1();
            this.supplierBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.supplierTableAdapter1 = new WindowsFormsApplication1.IEdatabaseDataSet1TableAdapters.supplierTableAdapter();
            this.productTableAdapter = new WindowsFormsApplication1.IEdatabaseDataSetTableAdapters.productTableAdapter();
            this.supplierBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.supplierproductBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.supplierproductBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.iEdatabaseDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iEdatabaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.supplierBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iEdatabaseDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.supplierBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.supplierBindingSource2)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.supplierproductBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.supplierproductBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // pid
            // 
            this.pid.AutoSize = true;
            this.pid.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pid.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.pid.Location = new System.Drawing.Point(66, 52);
            this.pid.Name = "pid";
            this.pid.Size = new System.Drawing.Size(82, 20);
            this.pid.TabIndex = 0;
            this.pid.Text = "Product Id";
            // 
            // sid
            // 
            this.sid.AutoSize = true;
            this.sid.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sid.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.sid.Location = new System.Drawing.Point(66, 85);
            this.sid.Name = "sid";
            this.sid.Size = new System.Drawing.Size(85, 20);
            this.sid.TabIndex = 1;
            this.sid.Text = "Supplier Id";
            this.sid.Click += new System.EventHandler(this.sid_Click);
            // 
            // pname
            // 
            this.pname.AutoSize = true;
            this.pname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pname.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.pname.Location = new System.Drawing.Point(66, 116);
            this.pname.Name = "pname";
            this.pname.Size = new System.Drawing.Size(110, 20);
            this.pname.TabIndex = 2;
            this.pname.Text = "Product Name";
            // 
            // pprice
            // 
            this.pprice.AutoSize = true;
            this.pprice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pprice.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.pprice.Location = new System.Drawing.Point(66, 149);
            this.pprice.Name = "pprice";
            this.pprice.Size = new System.Drawing.Size(103, 20);
            this.pprice.TabIndex = 3;
            this.pprice.Text = "Product Price";
            this.pprice.Click += new System.EventHandler(this.pprice_Click);
            // 
            // pquantity
            // 
            this.pquantity.AutoSize = true;
            this.pquantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pquantity.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.pquantity.Location = new System.Drawing.Point(66, 183);
            this.pquantity.Name = "pquantity";
            this.pquantity.Size = new System.Drawing.Size(127, 20);
            this.pquantity.TabIndex = 4;
            this.pquantity.Text = "Product Quantity";
            this.pquantity.Click += new System.EventHandler(this.pquantity_Click);
            // 
            // pidtxt
            // 
            this.pidtxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pidtxt.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.pidtxt.Location = new System.Drawing.Point(228, 50);
            this.pidtxt.Name = "pidtxt";
            this.pidtxt.Size = new System.Drawing.Size(139, 22);
            this.pidtxt.TabIndex = 5;
            this.pidtxt.TextChanged += new System.EventHandler(this.pidtxt_TextChanged);
            // 
            // pnametxt
            // 
            this.pnametxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnametxt.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.pnametxt.Location = new System.Drawing.Point(228, 117);
            this.pnametxt.Name = "pnametxt";
            this.pnametxt.Size = new System.Drawing.Size(139, 22);
            this.pnametxt.TabIndex = 6;
            // 
            // ppricetxt
            // 
            this.ppricetxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ppricetxt.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.ppricetxt.Location = new System.Drawing.Point(228, 150);
            this.ppricetxt.Name = "ppricetxt";
            this.ppricetxt.Size = new System.Drawing.Size(139, 22);
            this.ppricetxt.TabIndex = 7;
            // 
            // pquantitytxt
            // 
            this.pquantitytxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pquantitytxt.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.pquantitytxt.Location = new System.Drawing.Point(228, 184);
            this.pquantitytxt.Name = "pquantitytxt";
            this.pquantitytxt.Size = new System.Drawing.Size(139, 22);
            this.pquantitytxt.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.button1.Location = new System.Drawing.Point(292, 240);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cbsid
            // 
            this.cbsid.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbsid.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.cbsid.FormattingEnabled = true;
            this.cbsid.Location = new System.Drawing.Point(228, 84);
            this.cbsid.Name = "cbsid";
            this.cbsid.Size = new System.Drawing.Size(143, 24);
            this.cbsid.TabIndex = 11;
            this.cbsid.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // iEdatabaseDataSetBindingSource
            // 
            this.iEdatabaseDataSetBindingSource.DataSource = this.iEdatabaseDataSet;
            this.iEdatabaseDataSetBindingSource.Position = 0;
            // 
            // iEdatabaseDataSet
            // 
            this.iEdatabaseDataSet.DataSetName = "IEdatabaseDataSet";
            this.iEdatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // supplierBindingSource
            // 
            this.supplierBindingSource.DataMember = "supplier";
            this.supplierBindingSource.DataSource = this.iEdatabaseDataSet;
            // 
            // supplierTableAdapter
            // 
            this.supplierTableAdapter.ClearBeforeFill = true;
            // 
            // iEdatabaseDataSet1
            // 
            this.iEdatabaseDataSet1.DataSetName = "IEdatabaseDataSet1";
            this.iEdatabaseDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // supplierBindingSource1
            // 
            this.supplierBindingSource1.DataMember = "supplier";
            this.supplierBindingSource1.DataSource = this.iEdatabaseDataSet1;
            // 
            // supplierTableAdapter1
            // 
            this.supplierTableAdapter1.ClearBeforeFill = true;
            // 
            // productTableAdapter
            // 
            this.productTableAdapter.ClearBeforeFill = true;
            // 
            // supplierBindingSource2
            // 
            this.supplierBindingSource2.DataMember = "supplier";
            this.supplierBindingSource2.DataSource = this.iEdatabaseDataSetBindingSource;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pidtxt);
            this.groupBox1.Controls.Add(this.cbsid);
            this.groupBox1.Controls.Add(this.pid);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.sid);
            this.groupBox1.Controls.Add(this.pquantitytxt);
            this.groupBox1.Controls.Add(this.pname);
            this.groupBox1.Controls.Add(this.ppricetxt);
            this.groupBox1.Controls.Add(this.pprice);
            this.groupBox1.Controls.Add(this.pnametxt);
            this.groupBox1.Controls.Add(this.pquantity);
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.groupBox1.Location = new System.Drawing.Point(12, 23);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(397, 332);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add Product ";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApplication1.Properties.Resources.Product;
            this.pictureBox1.Location = new System.Drawing.Point(431, 38);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(463, 276);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // supplierproductBindingSource
            // 
            this.supplierproductBindingSource.DataMember = "supplierproduct";
            this.supplierproductBindingSource.DataSource = this.supplierBindingSource;
            // 
            // supplierproductBindingSource1
            // 
            this.supplierproductBindingSource1.DataMember = "supplierproduct";
            this.supplierproductBindingSource1.DataSource = this.supplierBindingSource2;
            // 
            // product
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 482);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox1);
            this.Name = "product";
            this.Text = "Product";
            this.Load += new System.EventHandler(this.Product_Load);
            ((System.ComponentModel.ISupportInitialize)(this.iEdatabaseDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iEdatabaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.supplierBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iEdatabaseDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.supplierBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.supplierBindingSource2)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.supplierproductBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.supplierproductBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label pid;
        private System.Windows.Forms.Label sid;
        private System.Windows.Forms.Label pname;
        private System.Windows.Forms.Label pprice;
        private System.Windows.Forms.Label pquantity;
        private System.Windows.Forms.TextBox pidtxt;
        private System.Windows.Forms.TextBox pnametxt;
        private System.Windows.Forms.TextBox ppricetxt;
        private System.Windows.Forms.TextBox pquantitytxt;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cbsid;
        private IEdatabaseDataSet iEdatabaseDataSet;
        private System.Windows.Forms.BindingSource iEdatabaseDataSetBindingSource;
        private System.Windows.Forms.BindingSource supplierBindingSource;
        private IEdatabaseDataSetTableAdapters.supplierTableAdapter supplierTableAdapter;
        private IEdatabaseDataSet1 iEdatabaseDataSet1;
        private System.Windows.Forms.BindingSource supplierBindingSource1;
        private IEdatabaseDataSet1TableAdapters.supplierTableAdapter supplierTableAdapter1;
        private System.Windows.Forms.BindingSource supplierproductBindingSource;
        private IEdatabaseDataSetTableAdapters.productTableAdapter productTableAdapter;
        private System.Windows.Forms.BindingSource supplierproductBindingSource1;
        private System.Windows.Forms.BindingSource supplierBindingSource2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}