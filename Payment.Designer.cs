namespace WindowsFormsApplication1
{
    partial class Payment
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
            this.paydate = new System.Windows.Forms.Label();
            this.payid = new System.Windows.Forms.Label();
            this.bid = new System.Windows.Forms.Label();
            this.payamount = new System.Windows.Forms.Label();
            this.paytype = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.payamounttxt = new System.Windows.Forms.TextBox();
            this.payidtxt = new System.Windows.Forms.TextBox();
            this.Save = new System.Windows.Forms.Button();
            this.cbpaytypetxt = new System.Windows.Forms.ComboBox();
            this.cbbid = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // paydate
            // 
            this.paydate.AutoSize = true;
            this.paydate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.paydate.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.paydate.Location = new System.Drawing.Point(25, 85);
            this.paydate.Name = "paydate";
            this.paydate.Size = new System.Drawing.Size(93, 16);
            this.paydate.TabIndex = 0;
            this.paydate.Text = "Payment Date";
            // 
            // payid
            // 
            this.payid.AutoSize = true;
            this.payid.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.payid.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.payid.Location = new System.Drawing.Point(25, 48);
            this.payid.Name = "payid";
            this.payid.Size = new System.Drawing.Size(75, 16);
            this.payid.TabIndex = 1;
            this.payid.Text = "Payment Id";
            // 
            // bid
            // 
            this.bid.AutoSize = true;
            this.bid.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bid.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.bid.Location = new System.Drawing.Point(25, 124);
            this.bid.Name = "bid";
            this.bid.Size = new System.Drawing.Size(40, 16);
            this.bid.TabIndex = 2;
            this.bid.Text = "Bill Id";
            // 
            // payamount
            // 
            this.payamount.AutoSize = true;
            this.payamount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.payamount.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.payamount.Location = new System.Drawing.Point(25, 158);
            this.payamount.Name = "payamount";
            this.payamount.Size = new System.Drawing.Size(109, 16);
            this.payamount.TabIndex = 3;
            this.payamount.Text = "Payment Amount";
            // 
            // paytype
            // 
            this.paytype.AutoSize = true;
            this.paytype.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.paytype.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.paytype.Location = new System.Drawing.Point(25, 194);
            this.paytype.Name = "paytype";
            this.paytype.Size = new System.Drawing.Size(96, 16);
            this.paytype.TabIndex = 4;
            this.paytype.Text = "Payment Type";
            this.paytype.Click += new System.EventHandler(this.paytype_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "dd-MM-yyyy";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(172, 80);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(141, 20);
            this.dateTimePicker1.TabIndex = 5;
            // 
            // payamounttxt
            // 
            this.payamounttxt.Location = new System.Drawing.Point(172, 158);
            this.payamounttxt.Name = "payamounttxt";
            this.payamounttxt.Size = new System.Drawing.Size(141, 20);
            this.payamounttxt.TabIndex = 6;
            // 
            // payidtxt
            // 
            this.payidtxt.Location = new System.Drawing.Point(172, 44);
            this.payidtxt.Name = "payidtxt";
            this.payidtxt.Size = new System.Drawing.Size(141, 20);
            this.payidtxt.TabIndex = 9;
            // 
            // Save
            // 
            this.Save.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Save.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.Save.Location = new System.Drawing.Point(238, 250);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(75, 23);
            this.Save.TabIndex = 11;
            this.Save.Text = "Save";
            this.Save.UseVisualStyleBackColor = true;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // cbpaytypetxt
            // 
            this.cbpaytypetxt.FormattingEnabled = true;
            this.cbpaytypetxt.Items.AddRange(new object[] {
            "CASH",
            "LETTER OF CREDIT (LOC)"});
            this.cbpaytypetxt.Location = new System.Drawing.Point(172, 197);
            this.cbpaytypetxt.Name = "cbpaytypetxt";
            this.cbpaytypetxt.Size = new System.Drawing.Size(141, 21);
            this.cbpaytypetxt.TabIndex = 12;
            this.cbpaytypetxt.SelectedIndexChanged += new System.EventHandler(this.cbpaytypetxt_SelectedIndexChanged);
            // 
            // cbbid
            // 
            this.cbbid.FormattingEnabled = true;
            this.cbbid.Location = new System.Drawing.Point(172, 118);
            this.cbbid.Name = "cbbid";
            this.cbbid.Size = new System.Drawing.Size(141, 21);
            this.cbbid.TabIndex = 13;
            this.cbbid.SelectedIndexChanged += new System.EventHandler(this.cbbid_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.payidtxt);
            this.groupBox1.Controls.Add(this.cbbid);
            this.groupBox1.Controls.Add(this.paydate);
            this.groupBox1.Controls.Add(this.cbpaytypetxt);
            this.groupBox1.Controls.Add(this.payid);
            this.groupBox1.Controls.Add(this.Save);
            this.groupBox1.Controls.Add(this.bid);
            this.groupBox1.Controls.Add(this.payamount);
            this.groupBox1.Controls.Add(this.payamounttxt);
            this.groupBox1.Controls.Add(this.paytype);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.ForeColor = System.Drawing.Color.Navy;
            this.groupBox1.Location = new System.Drawing.Point(34, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(328, 310);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Make Payment";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApplication1.Properties.Resources.images_1485976880550;
            this.pictureBox1.Location = new System.Drawing.Point(387, 23);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(429, 249);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // Payment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(870, 378);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Payment";
            this.Text = "Payment";
            this.Load += new System.EventHandler(this.Payment_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label paydate;
        private System.Windows.Forms.Label payid;
        private System.Windows.Forms.Label bid;
        private System.Windows.Forms.Label payamount;
        private System.Windows.Forms.Label paytype;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox payamounttxt;
        private System.Windows.Forms.TextBox payidtxt;
        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.ComboBox cbpaytypetxt;
        private System.Windows.Forms.ComboBox cbbid;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}