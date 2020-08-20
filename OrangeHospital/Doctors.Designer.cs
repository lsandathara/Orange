namespace OrangeHospital
{
    partial class Doctors
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Doctors));
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.doctorname = new System.Windows.Forms.TextBox();
            this.docrefid = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.specialization = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.docgender = new System.Windows.Forms.ComboBox();
            this.addpatient = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label13 = new System.Windows.Forms.Label();
            this.listdoctors = new System.Windows.Forms.DataGridView();
            this.docemail = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.doccontactnum = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listdoctors)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(387, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 25);
            this.label1.TabIndex = 19;
            this.label1.Text = "Orange Hospital";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(314, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(67, 64);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(292, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 17);
            this.label2.TabIndex = 20;
            this.label2.Text = "Add Doctor";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(180, 157);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 17);
            this.label3.TabIndex = 21;
            this.label3.Text = "Doctor Name";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // doctorname
            // 
            this.doctorname.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.doctorname.Location = new System.Drawing.Point(314, 154);
            this.doctorname.Name = "doctorname";
            this.doctorname.Size = new System.Drawing.Size(178, 23);
            this.doctorname.TabIndex = 22;
            this.doctorname.TextChanged += new System.EventHandler(this.doctorname_TextChanged);
            // 
            // docrefid
            // 
            this.docrefid.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.docrefid.Location = new System.Drawing.Point(314, 191);
            this.docrefid.Name = "docrefid";
            this.docrefid.Size = new System.Drawing.Size(178, 23);
            this.docrefid.TabIndex = 24;
            this.docrefid.TextChanged += new System.EventHandler(this.docrefid_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(180, 191);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 17);
            this.label4.TabIndex = 23;
            this.label4.Text = "Reference ID";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(180, 266);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 17);
            this.label5.TabIndex = 25;
            this.label5.Text = "Gender";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // specialization
            // 
            this.specialization.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.specialization.Location = new System.Drawing.Point(314, 222);
            this.specialization.Name = "specialization";
            this.specialization.Size = new System.Drawing.Size(178, 23);
            this.specialization.TabIndex = 28;
            this.specialization.TextChanged += new System.EventHandler(this.specialization_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(180, 228);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 17);
            this.label6.TabIndex = 27;
            this.label6.Text = "Specialization";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // docgender
            // 
            this.docgender.FormattingEnabled = true;
            this.docgender.Items.AddRange(new object[] {
            "Female",
            "Male",
            "Other"});
            this.docgender.Location = new System.Drawing.Point(314, 262);
            this.docgender.Name = "docgender";
            this.docgender.Size = new System.Drawing.Size(178, 21);
            this.docgender.TabIndex = 29;
            this.docgender.SelectedIndexChanged += new System.EventHandler(this.docgender_SelectedIndexChanged);
            // 
            // addpatient
            // 
            this.addpatient.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.addpatient.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addpatient.Location = new System.Drawing.Point(265, 410);
            this.addpatient.Name = "addpatient";
            this.addpatient.Size = new System.Drawing.Size(116, 44);
            this.addpatient.TabIndex = 42;
            this.addpatient.Text = "Add Doctor";
            this.addpatient.UseVisualStyleBackColor = false;
            this.addpatient.Click += new System.EventHandler(this.addpatient_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(249, 89);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(37, 34);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 43;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(691, 89);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(102, 17);
            this.label13.TabIndex = 46;
            this.label13.Text = "View Doctors";
            this.label13.Click += new System.EventHandler(this.label13_Click);
            // 
            // listdoctors
            // 
            this.listdoctors.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listdoctors.Location = new System.Drawing.Point(555, 121);
            this.listdoctors.Name = "listdoctors";
            this.listdoctors.Size = new System.Drawing.Size(448, 404);
            this.listdoctors.TabIndex = 45;
            this.listdoctors.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.listdoctors_CellContentClick);
            // 
            // docemail
            // 
            this.docemail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.docemail.Location = new System.Drawing.Point(314, 301);
            this.docemail.Name = "docemail";
            this.docemail.Size = new System.Drawing.Size(178, 23);
            this.docemail.TabIndex = 48;
            this.docemail.TextChanged += new System.EventHandler(this.docemail_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(180, 301);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 17);
            this.label7.TabIndex = 47;
            this.label7.Text = "Email";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // doccontactnum
            // 
            this.doccontactnum.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.doccontactnum.Location = new System.Drawing.Point(314, 338);
            this.doccontactnum.Name = "doccontactnum";
            this.doccontactnum.Size = new System.Drawing.Size(178, 23);
            this.doccontactnum.TabIndex = 50;
            this.doccontactnum.TextChanged += new System.EventHandler(this.doccontactnum_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(180, 341);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(110, 17);
            this.label8.TabIndex = 49;
            this.label8.Text = "Contact Number";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // Doctors
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1033, 552);
            this.Controls.Add(this.doccontactnum);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.docemail);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.listdoctors);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.addpatient);
            this.Controls.Add(this.docgender);
            this.Controls.Add(this.specialization);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.docrefid);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.doctorname);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Doctors";
            this.Text = "Doctors";
            this.Load += new System.EventHandler(this.Doctors_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listdoctors)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox doctorname;
        private System.Windows.Forms.TextBox docrefid;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox specialization;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox docgender;
        private System.Windows.Forms.Button addpatient;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DataGridView listdoctors;
        private System.Windows.Forms.TextBox docemail;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox doccontactnum;
        private System.Windows.Forms.Label label8;
    }
}