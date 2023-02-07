namespace WindowsFormsApplication1
{
    partial class Bill
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
            this.bdate = new System.Windows.Forms.Label();
            this.bid = new System.Windows.Forms.Label();
            this.cid = new System.Windows.Forms.Label();
            this.cname = new System.Windows.Forms.Label();
            this.ciecode = new System.Windows.Forms.Label();
            this.pname = new System.Windows.Forms.Label();
            this.pprice = new System.Windows.Forms.Label();
            this.pquantity = new System.Windows.Forms.Label();
            this.portofloading = new System.Windows.Forms.Label();
            this.grossweightkg = new System.Windows.Forms.Label();
            this.vesselname = new System.Windows.Forms.Label();
            this.totalcharge = new System.Windows.Forms.Label();
            this.Save = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.bidtxt = new System.Windows.Forms.TextBox();
            this.ciecodetxt = new System.Windows.Forms.TextBox();
            this.ppricetxt = new System.Windows.Forms.TextBox();
            this.pquantitytxt = new System.Windows.Forms.TextBox();
            this.portofloadingtxt = new System.Windows.Forms.TextBox();
            this.grossweightkgtxt = new System.Windows.Forms.TextBox();
            this.vesselnametxt = new System.Windows.Forms.TextBox();
            this.totalchargetxt = new System.Windows.Forms.TextBox();
            this.cportofdischarge = new System.Windows.Forms.Label();
            this.cportofdischargetxt = new System.Windows.Forms.TextBox();
            this.pid = new System.Windows.Forms.Label();
            this.cbiid = new System.Windows.Forms.ComboBox();
            this.cnametxt = new System.Windows.Forms.TextBox();
            this.cbpid = new System.Windows.Forms.ComboBox();
            this.pnametxt = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bdate
            // 
            this.bdate.AutoSize = true;
            this.bdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bdate.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.bdate.Location = new System.Drawing.Point(61, 68);
            this.bdate.Name = "bdate";
            this.bdate.Size = new System.Drawing.Size(58, 16);
            this.bdate.TabIndex = 0;
            this.bdate.Text = "Bill Date";
            this.bdate.Click += new System.EventHandler(this.label1_Click);
            // 
            // bid
            // 
            this.bid.AutoSize = true;
            this.bid.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bid.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.bid.Location = new System.Drawing.Point(62, 34);
            this.bid.Name = "bid";
            this.bid.Size = new System.Drawing.Size(40, 16);
            this.bid.TabIndex = 1;
            this.bid.Text = "Bill Id";
            // 
            // cid
            // 
            this.cid.AutoSize = true;
            this.cid.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cid.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.cid.Location = new System.Drawing.Point(60, 101);
            this.cid.Name = "cid";
            this.cid.Size = new System.Drawing.Size(71, 16);
            this.cid.TabIndex = 2;
            this.cid.Text = "Importer Id";
            // 
            // cname
            // 
            this.cname.AutoSize = true;
            this.cname.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cname.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.cname.Location = new System.Drawing.Point(62, 135);
            this.cname.Name = "cname";
            this.cname.Size = new System.Drawing.Size(97, 16);
            this.cname.TabIndex = 3;
            this.cname.Text = "Importer Name";
            // 
            // ciecode
            // 
            this.ciecode.AutoSize = true;
            this.ciecode.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ciecode.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.ciecode.Location = new System.Drawing.Point(64, 169);
            this.ciecode.Name = "ciecode";
            this.ciecode.Size = new System.Drawing.Size(105, 16);
            this.ciecode.TabIndex = 4;
            this.ciecode.Text = "Importer IECode";
            // 
            // pname
            // 
            this.pname.AutoSize = true;
            this.pname.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pname.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.pname.Location = new System.Drawing.Point(64, 264);
            this.pname.Name = "pname";
            this.pname.Size = new System.Drawing.Size(94, 16);
            this.pname.TabIndex = 6;
            this.pname.Text = "Product Name";
            // 
            // pprice
            // 
            this.pprice.AutoSize = true;
            this.pprice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pprice.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.pprice.Location = new System.Drawing.Point(61, 296);
            this.pprice.Name = "pprice";
            this.pprice.Size = new System.Drawing.Size(88, 16);
            this.pprice.TabIndex = 7;
            this.pprice.Text = "Product Price";
            // 
            // pquantity
            // 
            this.pquantity.AutoSize = true;
            this.pquantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pquantity.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.pquantity.Location = new System.Drawing.Point(63, 328);
            this.pquantity.Name = "pquantity";
            this.pquantity.Size = new System.Drawing.Size(105, 16);
            this.pquantity.TabIndex = 8;
            this.pquantity.Text = "Product Quantity";
            this.pquantity.Click += new System.EventHandler(this.pquantity_Click);
            // 
            // portofloading
            // 
            this.portofloading.AutoSize = true;
            this.portofloading.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.portofloading.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.portofloading.Location = new System.Drawing.Point(63, 365);
            this.portofloading.Name = "portofloading";
            this.portofloading.Size = new System.Drawing.Size(100, 16);
            this.portofloading.TabIndex = 9;
            this.portofloading.Text = "Port Of Loading";
            // 
            // grossweightkg
            // 
            this.grossweightkg.AutoSize = true;
            this.grossweightkg.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grossweightkg.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.grossweightkg.Location = new System.Drawing.Point(60, 402);
            this.grossweightkg.Name = "grossweightkg";
            this.grossweightkg.Size = new System.Drawing.Size(108, 16);
            this.grossweightkg.TabIndex = 10;
            this.grossweightkg.Text = "Gross Weight Kg";
            this.grossweightkg.Click += new System.EventHandler(this.grossweightkg_Click);
            // 
            // vesselname
            // 
            this.vesselname.AutoSize = true;
            this.vesselname.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vesselname.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.vesselname.Location = new System.Drawing.Point(61, 441);
            this.vesselname.Name = "vesselname";
            this.vesselname.Size = new System.Drawing.Size(90, 16);
            this.vesselname.TabIndex = 11;
            this.vesselname.Text = "Vessel Name";
            // 
            // totalcharge
            // 
            this.totalcharge.AutoSize = true;
            this.totalcharge.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalcharge.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.totalcharge.Location = new System.Drawing.Point(63, 481);
            this.totalcharge.Name = "totalcharge";
            this.totalcharge.Size = new System.Drawing.Size(86, 16);
            this.totalcharge.TabIndex = 12;
            this.totalcharge.Text = "Total Charge";
            // 
            // Save
            // 
            this.Save.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Save.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.Save.Location = new System.Drawing.Point(308, 532);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(75, 23);
            this.Save.TabIndex = 13;
            this.Save.Text = "Save";
            this.Save.UseVisualStyleBackColor = true;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "dd-MM-yyyy";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(232, 64);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(150, 20);
            this.dateTimePicker1.TabIndex = 14;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // bidtxt
            // 
            this.bidtxt.Location = new System.Drawing.Point(232, 30);
            this.bidtxt.Name = "bidtxt";
            this.bidtxt.Size = new System.Drawing.Size(151, 20);
            this.bidtxt.TabIndex = 15;
            this.bidtxt.TextChanged += new System.EventHandler(this.bidtxt_TextChanged);
            // 
            // ciecodetxt
            // 
            this.ciecodetxt.Location = new System.Drawing.Point(231, 165);
            this.ciecodetxt.Name = "ciecodetxt";
            this.ciecodetxt.Size = new System.Drawing.Size(151, 20);
            this.ciecodetxt.TabIndex = 18;
            this.ciecodetxt.TextChanged += new System.EventHandler(this.ciecodetxt_TextChanged);
            // 
            // ppricetxt
            // 
            this.ppricetxt.Location = new System.Drawing.Point(231, 292);
            this.ppricetxt.Name = "ppricetxt";
            this.ppricetxt.Size = new System.Drawing.Size(151, 20);
            this.ppricetxt.TabIndex = 21;
            // 
            // pquantitytxt
            // 
            this.pquantitytxt.Location = new System.Drawing.Point(231, 324);
            this.pquantitytxt.Name = "pquantitytxt";
            this.pquantitytxt.Size = new System.Drawing.Size(151, 20);
            this.pquantitytxt.TabIndex = 22;
            // 
            // portofloadingtxt
            // 
            this.portofloadingtxt.Location = new System.Drawing.Point(231, 361);
            this.portofloadingtxt.Name = "portofloadingtxt";
            this.portofloadingtxt.Size = new System.Drawing.Size(151, 20);
            this.portofloadingtxt.TabIndex = 23;
            // 
            // grossweightkgtxt
            // 
            this.grossweightkgtxt.Location = new System.Drawing.Point(232, 402);
            this.grossweightkgtxt.Name = "grossweightkgtxt";
            this.grossweightkgtxt.Size = new System.Drawing.Size(151, 20);
            this.grossweightkgtxt.TabIndex = 24;
            // 
            // vesselnametxt
            // 
            this.vesselnametxt.Location = new System.Drawing.Point(231, 437);
            this.vesselnametxt.Name = "vesselnametxt";
            this.vesselnametxt.Size = new System.Drawing.Size(151, 20);
            this.vesselnametxt.TabIndex = 25;
            this.vesselnametxt.TextChanged += new System.EventHandler(this.vesselnametxt_TextChanged);
            // 
            // totalchargetxt
            // 
            this.totalchargetxt.Location = new System.Drawing.Point(232, 477);
            this.totalchargetxt.Name = "totalchargetxt";
            this.totalchargetxt.Size = new System.Drawing.Size(151, 20);
            this.totalchargetxt.TabIndex = 26;
            // 
            // cportofdischarge
            // 
            this.cportofdischarge.AutoSize = true;
            this.cportofdischarge.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cportofdischarge.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.cportofdischarge.Location = new System.Drawing.Point(63, 203);
            this.cportofdischarge.Name = "cportofdischarge";
            this.cportofdischarge.Size = new System.Drawing.Size(111, 16);
            this.cportofdischarge.TabIndex = 27;
            this.cportofdischarge.Text = "Port of Discharge";
            // 
            // cportofdischargetxt
            // 
            this.cportofdischargetxt.Location = new System.Drawing.Point(231, 199);
            this.cportofdischargetxt.Name = "cportofdischargetxt";
            this.cportofdischargetxt.Size = new System.Drawing.Size(151, 20);
            this.cportofdischargetxt.TabIndex = 28;
            this.cportofdischargetxt.TextChanged += new System.EventHandler(this.cportofdischargetxt_TextChanged);
            // 
            // pid
            // 
            this.pid.AutoSize = true;
            this.pid.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pid.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.pid.Location = new System.Drawing.Point(63, 233);
            this.pid.Name = "pid";
            this.pid.Size = new System.Drawing.Size(68, 16);
            this.pid.TabIndex = 31;
            this.pid.Text = "Product Id";
            // 
            // cbiid
            // 
            this.cbiid.FormattingEnabled = true;
            this.cbiid.Location = new System.Drawing.Point(232, 96);
            this.cbiid.Name = "cbiid";
            this.cbiid.Size = new System.Drawing.Size(151, 21);
            this.cbiid.TabIndex = 37;
            this.cbiid.SelectedIndexChanged += new System.EventHandler(this.cbiid_SelectedIndexChanged);
            // 
            // cnametxt
            // 
            this.cnametxt.Location = new System.Drawing.Point(232, 131);
            this.cnametxt.Name = "cnametxt";
            this.cnametxt.Size = new System.Drawing.Size(151, 20);
            this.cnametxt.TabIndex = 38;
            // 
            // cbpid
            // 
            this.cbpid.FormattingEnabled = true;
            this.cbpid.Location = new System.Drawing.Point(231, 228);
            this.cbpid.Name = "cbpid";
            this.cbpid.Size = new System.Drawing.Size(151, 21);
            this.cbpid.TabIndex = 39;
            this.cbpid.SelectedIndexChanged += new System.EventHandler(this.cbpid_SelectedIndexChanged);
            // 
            // pnametxt
            // 
            this.pnametxt.Location = new System.Drawing.Point(232, 260);
            this.pnametxt.Name = "pnametxt";
            this.pnametxt.Size = new System.Drawing.Size(151, 20);
            this.pnametxt.TabIndex = 40;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.bidtxt);
            this.groupBox1.Controls.Add(this.pnametxt);
            this.groupBox1.Controls.Add(this.bdate);
            this.groupBox1.Controls.Add(this.cbpid);
            this.groupBox1.Controls.Add(this.bid);
            this.groupBox1.Controls.Add(this.cnametxt);
            this.groupBox1.Controls.Add(this.cid);
            this.groupBox1.Controls.Add(this.cbiid);
            this.groupBox1.Controls.Add(this.cname);
            this.groupBox1.Controls.Add(this.pid);
            this.groupBox1.Controls.Add(this.ciecode);
            this.groupBox1.Controls.Add(this.cportofdischargetxt);
            this.groupBox1.Controls.Add(this.pname);
            this.groupBox1.Controls.Add(this.cportofdischarge);
            this.groupBox1.Controls.Add(this.pprice);
            this.groupBox1.Controls.Add(this.totalchargetxt);
            this.groupBox1.Controls.Add(this.pquantity);
            this.groupBox1.Controls.Add(this.vesselnametxt);
            this.groupBox1.Controls.Add(this.portofloading);
            this.groupBox1.Controls.Add(this.grossweightkgtxt);
            this.groupBox1.Controls.Add(this.grossweightkg);
            this.groupBox1.Controls.Add(this.portofloadingtxt);
            this.groupBox1.Controls.Add(this.vesselname);
            this.groupBox1.Controls.Add(this.pquantitytxt);
            this.groupBox1.Controls.Add(this.totalcharge);
            this.groupBox1.Controls.Add(this.ppricetxt);
            this.groupBox1.Controls.Add(this.Save);
            this.groupBox1.Controls.Add(this.ciecodetxt);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.groupBox1.Location = new System.Drawing.Point(23, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(480, 574);
            this.groupBox1.TabIndex = 41;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Make Bill";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // Bill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(856, 601);
            this.Controls.Add(this.groupBox1);
            this.Name = "Bill";
            this.Text = "Bill";
            this.Load += new System.EventHandler(this.Bill_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label bdate;
        private System.Windows.Forms.Label bid;
        private System.Windows.Forms.Label cid;
        private System.Windows.Forms.Label cname;
        private System.Windows.Forms.Label ciecode;
        private System.Windows.Forms.Label pname;
        private System.Windows.Forms.Label pprice;
        private System.Windows.Forms.Label pquantity;
        private System.Windows.Forms.Label portofloading;
        private System.Windows.Forms.Label grossweightkg;
        private System.Windows.Forms.Label vesselname;
        private System.Windows.Forms.Label totalcharge;
        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox bidtxt;
        private System.Windows.Forms.TextBox ciecodetxt;
        private System.Windows.Forms.TextBox ppricetxt;
        private System.Windows.Forms.TextBox pquantitytxt;
        private System.Windows.Forms.TextBox portofloadingtxt;
        private System.Windows.Forms.TextBox grossweightkgtxt;
        private System.Windows.Forms.TextBox vesselnametxt;
        private System.Windows.Forms.TextBox totalchargetxt;
        private System.Windows.Forms.Label cportofdischarge;
        private System.Windows.Forms.TextBox cportofdischargetxt;
        private System.Windows.Forms.Label pid;
        private System.Windows.Forms.ComboBox cbiid;
        private System.Windows.Forms.TextBox cnametxt;
        private System.Windows.Forms.ComboBox cbpid;
        private System.Windows.Forms.TextBox pnametxt;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}