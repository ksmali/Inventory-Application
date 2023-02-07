namespace WindowsFormsApplication1
{
    partial class importer
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
            this.cid = new System.Windows.Forms.Label();
            this.cname = new System.Windows.Forms.Label();
            this.ciecode = new System.Windows.Forms.Label();
            this.caddress = new System.Windows.Forms.Label();
            this.cportofdischarge = new System.Windows.Forms.Label();
            this.cidtxt = new System.Windows.Forms.TextBox();
            this.cnametxt = new System.Windows.Forms.TextBox();
            this.caddresstxt = new System.Windows.Forms.TextBox();
            this.ciecodetxt = new System.Windows.Forms.TextBox();
            this.cportofdischargetxt = new System.Windows.Forms.TextBox();
            this.Save = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // cid
            // 
            this.cid.AutoSize = true;
            this.cid.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cid.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.cid.Location = new System.Drawing.Point(32, 54);
            this.cid.Name = "cid";
            this.cid.Size = new System.Drawing.Size(87, 20);
            this.cid.TabIndex = 0;
            this.cid.Text = "Importer Id";
            this.cid.Click += new System.EventHandler(this.cid_Click);
            // 
            // cname
            // 
            this.cname.AutoSize = true;
            this.cname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cname.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.cname.Location = new System.Drawing.Point(32, 88);
            this.cname.Name = "cname";
            this.cname.Size = new System.Drawing.Size(115, 20);
            this.cname.TabIndex = 1;
            this.cname.Text = "Importer Name";
            // 
            // ciecode
            // 
            this.ciecode.AutoSize = true;
            this.ciecode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ciecode.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.ciecode.Location = new System.Drawing.Point(32, 160);
            this.ciecode.Name = "ciecode";
            this.ciecode.Size = new System.Drawing.Size(127, 20);
            this.ciecode.TabIndex = 2;
            this.ciecode.Text = "Importer IECode";
            // 
            // caddress
            // 
            this.caddress.AutoSize = true;
            this.caddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.caddress.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.caddress.Location = new System.Drawing.Point(32, 123);
            this.caddress.Name = "caddress";
            this.caddress.Size = new System.Drawing.Size(128, 20);
            this.caddress.TabIndex = 3;
            this.caddress.Text = "Importer Country";
            // 
            // cportofdischarge
            // 
            this.cportofdischarge.AutoSize = true;
            this.cportofdischarge.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cportofdischarge.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.cportofdischarge.Location = new System.Drawing.Point(32, 195);
            this.cportofdischarge.Name = "cportofdischarge";
            this.cportofdischarge.Size = new System.Drawing.Size(132, 20);
            this.cportofdischarge.TabIndex = 4;
            this.cportofdischarge.Text = "Port of Discharge";
            // 
            // cidtxt
            // 
            this.cidtxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cidtxt.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.cidtxt.Location = new System.Drawing.Point(189, 52);
            this.cidtxt.Name = "cidtxt";
            this.cidtxt.Size = new System.Drawing.Size(133, 22);
            this.cidtxt.TabIndex = 5;
            // 
            // cnametxt
            // 
            this.cnametxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cnametxt.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.cnametxt.Location = new System.Drawing.Point(189, 89);
            this.cnametxt.Name = "cnametxt";
            this.cnametxt.Size = new System.Drawing.Size(133, 22);
            this.cnametxt.TabIndex = 6;
            // 
            // caddresstxt
            // 
            this.caddresstxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.caddresstxt.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.caddresstxt.Location = new System.Drawing.Point(189, 124);
            this.caddresstxt.Name = "caddresstxt";
            this.caddresstxt.Size = new System.Drawing.Size(133, 22);
            this.caddresstxt.TabIndex = 7;
            // 
            // ciecodetxt
            // 
            this.ciecodetxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ciecodetxt.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.ciecodetxt.Location = new System.Drawing.Point(189, 158);
            this.ciecodetxt.Name = "ciecodetxt";
            this.ciecodetxt.Size = new System.Drawing.Size(133, 22);
            this.ciecodetxt.TabIndex = 8;
            // 
            // cportofdischargetxt
            // 
            this.cportofdischargetxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cportofdischargetxt.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.cportofdischargetxt.Location = new System.Drawing.Point(189, 196);
            this.cportofdischargetxt.Name = "cportofdischargetxt";
            this.cportofdischargetxt.Size = new System.Drawing.Size(133, 22);
            this.cportofdischargetxt.TabIndex = 9;
            // 
            // Save
            // 
            this.Save.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Save.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.Save.Location = new System.Drawing.Point(247, 249);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(75, 23);
            this.Save.TabIndex = 10;
            this.Save.Text = "Save";
            this.Save.UseVisualStyleBackColor = true;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cidtxt);
            this.groupBox1.Controls.Add(this.Save);
            this.groupBox1.Controls.Add(this.cid);
            this.groupBox1.Controls.Add(this.cportofdischargetxt);
            this.groupBox1.Controls.Add(this.cname);
            this.groupBox1.Controls.Add(this.ciecodetxt);
            this.groupBox1.Controls.Add(this.ciecode);
            this.groupBox1.Controls.Add(this.caddresstxt);
            this.groupBox1.Controls.Add(this.caddress);
            this.groupBox1.Controls.Add(this.cnametxt);
            this.groupBox1.Controls.Add(this.cportofdischarge);
            this.groupBox1.ForeColor = System.Drawing.Color.Navy;
            this.groupBox1.Location = new System.Drawing.Point(37, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(337, 334);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add Importer";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApplication1.Properties.Resources.Import;
            this.pictureBox1.Location = new System.Drawing.Point(452, 21);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(229, 252);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // importer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(778, 429);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox1);
            this.Name = "importer";
            this.Text = "Importer";
            this.Load += new System.EventHandler(this.importer_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label cid;
        private System.Windows.Forms.Label cname;
        private System.Windows.Forms.Label ciecode;
        private System.Windows.Forms.Label caddress;
        private System.Windows.Forms.Label cportofdischarge;
        private System.Windows.Forms.TextBox cidtxt;
        private System.Windows.Forms.TextBox cnametxt;
        private System.Windows.Forms.TextBox caddresstxt;
        private System.Windows.Forms.TextBox ciecodetxt;
        private System.Windows.Forms.TextBox cportofdischargetxt;
        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}