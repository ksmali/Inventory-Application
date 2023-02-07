namespace WindowsFormsApplication1
{
    partial class supplier
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
            this.sid = new System.Windows.Forms.Label();
            this.sname = new System.Windows.Forms.Label();
            this.saddress = new System.Windows.Forms.Label();
            this.scontactno = new System.Windows.Forms.Label();
            this.sproductname = new System.Windows.Forms.Label();
            this.sproductquantity = new System.Windows.Forms.Label();
            this.siecode = new System.Windows.Forms.Label();
            this.sidtxt = new System.Windows.Forms.TextBox();
            this.snametxt = new System.Windows.Forms.TextBox();
            this.saddresstxt = new System.Windows.Forms.TextBox();
            this.scontactnotxt = new System.Windows.Forms.TextBox();
            this.sproductnametxt = new System.Windows.Forms.TextBox();
            this.sproductquantitytxt = new System.Windows.Forms.TextBox();
            this.siecodetxt = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // sid
            // 
            this.sid.AutoSize = true;
            this.sid.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sid.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.sid.Location = new System.Drawing.Point(8, 53);
            this.sid.Name = "sid";
            this.sid.Size = new System.Drawing.Size(85, 20);
            this.sid.TabIndex = 0;
            this.sid.Text = "Supplier Id";
            this.sid.Click += new System.EventHandler(this.sid_Click);
            // 
            // sname
            // 
            this.sname.AutoSize = true;
            this.sname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sname.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.sname.Location = new System.Drawing.Point(8, 86);
            this.sname.Name = "sname";
            this.sname.Size = new System.Drawing.Size(113, 20);
            this.sname.TabIndex = 1;
            this.sname.Text = "Supplier Name";
            // 
            // saddress
            // 
            this.saddress.AutoSize = true;
            this.saddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saddress.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.saddress.Location = new System.Drawing.Point(8, 122);
            this.saddress.Name = "saddress";
            this.saddress.Size = new System.Drawing.Size(94, 20);
            this.saddress.TabIndex = 2;
            this.saddress.Text = "Supplier city";
            // 
            // scontactno
            // 
            this.scontactno.AutoSize = true;
            this.scontactno.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scontactno.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.scontactno.Location = new System.Drawing.Point(8, 155);
            this.scontactno.Name = "scontactno";
            this.scontactno.Size = new System.Drawing.Size(187, 20);
            this.scontactno.TabIndex = 3;
            this.scontactno.Text = "Supplier Contact Number";
            this.scontactno.Click += new System.EventHandler(this.scontactno_Click);
            // 
            // sproductname
            // 
            this.sproductname.AutoSize = true;
            this.sproductname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sproductname.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.sproductname.Location = new System.Drawing.Point(8, 189);
            this.sproductname.Name = "sproductname";
            this.sproductname.Size = new System.Drawing.Size(172, 20);
            this.sproductname.TabIndex = 4;
            this.sproductname.Text = "Supplier Product Name";
            this.sproductname.Click += new System.EventHandler(this.sproductname_Click);
            // 
            // sproductquantity
            // 
            this.sproductquantity.AutoSize = true;
            this.sproductquantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sproductquantity.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.sproductquantity.Location = new System.Drawing.Point(8, 226);
            this.sproductquantity.Name = "sproductquantity";
            this.sproductquantity.Size = new System.Drawing.Size(189, 20);
            this.sproductquantity.TabIndex = 5;
            this.sproductquantity.Text = "Supplier Product Quantity";
            this.sproductquantity.Click += new System.EventHandler(this.sproductquantity_Click);
            // 
            // siecode
            // 
            this.siecode.AutoSize = true;
            this.siecode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.siecode.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.siecode.Location = new System.Drawing.Point(8, 259);
            this.siecode.Name = "siecode";
            this.siecode.Size = new System.Drawing.Size(165, 20);
            this.siecode.TabIndex = 6;
            this.siecode.Text = "Supplier Product Price";
            this.siecode.Click += new System.EventHandler(this.siecode_Click);
            // 
            // sidtxt
            // 
            this.sidtxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sidtxt.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.sidtxt.Location = new System.Drawing.Point(221, 40);
            this.sidtxt.Name = "sidtxt";
            this.sidtxt.Size = new System.Drawing.Size(157, 26);
            this.sidtxt.TabIndex = 7;
            this.sidtxt.TextChanged += new System.EventHandler(this.sidtxt_TextChanged);
            // 
            // snametxt
            // 
            this.snametxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.snametxt.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.snametxt.Location = new System.Drawing.Point(221, 73);
            this.snametxt.Name = "snametxt";
            this.snametxt.Size = new System.Drawing.Size(157, 26);
            this.snametxt.TabIndex = 8;
            this.snametxt.TextChanged += new System.EventHandler(this.snametxt_TextChanged);
            // 
            // saddresstxt
            // 
            this.saddresstxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saddresstxt.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.saddresstxt.Location = new System.Drawing.Point(221, 109);
            this.saddresstxt.Name = "saddresstxt";
            this.saddresstxt.Size = new System.Drawing.Size(157, 26);
            this.saddresstxt.TabIndex = 9;
            // 
            // scontactnotxt
            // 
            this.scontactnotxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scontactnotxt.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.scontactnotxt.Location = new System.Drawing.Point(221, 143);
            this.scontactnotxt.Name = "scontactnotxt";
            this.scontactnotxt.Size = new System.Drawing.Size(157, 26);
            this.scontactnotxt.TabIndex = 10;
            // 
            // sproductnametxt
            // 
            this.sproductnametxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sproductnametxt.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.sproductnametxt.Location = new System.Drawing.Point(221, 183);
            this.sproductnametxt.Name = "sproductnametxt";
            this.sproductnametxt.Size = new System.Drawing.Size(157, 26);
            this.sproductnametxt.TabIndex = 11;
            this.sproductnametxt.TextChanged += new System.EventHandler(this.sproductnametxt_TextChanged);
            // 
            // sproductquantitytxt
            // 
            this.sproductquantitytxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sproductquantitytxt.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.sproductquantitytxt.Location = new System.Drawing.Point(221, 217);
            this.sproductquantitytxt.Name = "sproductquantitytxt";
            this.sproductquantitytxt.Size = new System.Drawing.Size(157, 26);
            this.sproductquantitytxt.TabIndex = 12;
            // 
            // siecodetxt
            // 
            this.siecodetxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.siecodetxt.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.siecodetxt.Location = new System.Drawing.Point(221, 253);
            this.siecodetxt.Name = "siecodetxt";
            this.siecodetxt.Size = new System.Drawing.Size(157, 26);
            this.siecodetxt.TabIndex = 13;
            this.siecodetxt.TextChanged += new System.EventHandler(this.textBox7_TextChanged);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.button1.Location = new System.Drawing.Point(303, 306);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 29);
            this.button1.TabIndex = 14;
            this.button1.Text = "Save";
            this.button1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.sidtxt);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.sid);
            this.groupBox1.Controls.Add(this.siecodetxt);
            this.groupBox1.Controls.Add(this.sname);
            this.groupBox1.Controls.Add(this.sproductquantitytxt);
            this.groupBox1.Controls.Add(this.saddress);
            this.groupBox1.Controls.Add(this.sproductnametxt);
            this.groupBox1.Controls.Add(this.scontactno);
            this.groupBox1.Controls.Add(this.scontactnotxt);
            this.groupBox1.Controls.Add(this.sproductname);
            this.groupBox1.Controls.Add(this.saddresstxt);
            this.groupBox1.Controls.Add(this.sproductquantity);
            this.groupBox1.Controls.Add(this.snametxt);
            this.groupBox1.Controls.Add(this.siecode);
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(384, 394);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add Supplier";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApplication1.Properties.Resources.supplier;
            this.pictureBox1.Location = new System.Drawing.Point(462, 28);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(297, 305);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // supplier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(791, 418);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.Name = "supplier";
            this.Text = "Add supplier";
            this.Load += new System.EventHandler(this.supplier_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label sid;
        private System.Windows.Forms.Label sname;
        private System.Windows.Forms.Label saddress;
        private System.Windows.Forms.Label scontactno;
        private System.Windows.Forms.Label sproductname;
        private System.Windows.Forms.Label sproductquantity;
        private System.Windows.Forms.Label siecode;
        private System.Windows.Forms.TextBox sidtxt;
        private System.Windows.Forms.TextBox snametxt;
        private System.Windows.Forms.TextBox saddresstxt;
        private System.Windows.Forms.TextBox scontactnotxt;
        private System.Windows.Forms.TextBox sproductnametxt;
        private System.Windows.Forms.TextBox sproductquantitytxt;
        private System.Windows.Forms.TextBox siecodetxt;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}