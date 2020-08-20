namespace OrangeHospital
{
    partial class Patients
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Patients));
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.refid = new System.Windows.Forms.TextBox();
            this.fname = new System.Windows.Forms.TextBox();
            this.labelfname = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.email = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dob = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.address = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.contactnum = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.emergcontact = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.relationship = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.contactemg = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.gender = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.addpatient = new System.Windows.Forms.Button();
            this.listpatient = new System.Windows.Forms.DataGridView();
            this.label13 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listpatient)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(487, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 25);
            this.label1.TabIndex = 17;
            this.label1.Text = "Orange Hospital";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(414, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(67, 64);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(201, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 17);
            this.label2.TabIndex = 18;
            this.label2.Text = "Add Patient";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(84, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "Reference ID";
            // 
            // refid
            // 
            this.refid.Location = new System.Drawing.Point(204, 121);
            this.refid.Name = "refid";
            this.refid.Size = new System.Drawing.Size(204, 20);
            this.refid.TabIndex = 20;
            // 
            // fname
            // 
            this.fname.Location = new System.Drawing.Point(204, 154);
            this.fname.Name = "fname";
            this.fname.Size = new System.Drawing.Size(204, 20);
            this.fname.TabIndex = 22;
            // 
            // labelfname
            // 
            this.labelfname.AutoSize = true;
            this.labelfname.Location = new System.Drawing.Point(84, 157);
            this.labelfname.Name = "labelfname";
            this.labelfname.Size = new System.Drawing.Size(54, 13);
            this.labelfname.TabIndex = 21;
            this.labelfname.Text = "Full Name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(84, 184);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 13);
            this.label5.TabIndex = 23;
            this.label5.Text = "Gender";
            // 
            // email
            // 
            this.email.Location = new System.Drawing.Point(204, 211);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(204, 20);
            this.email.TabIndex = 26;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(84, 240);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 13);
            this.label6.TabIndex = 25;
            this.label6.Text = "Email";
            // 
            // dob
            // 
            this.dob.Location = new System.Drawing.Point(204, 240);
            this.dob.Name = "dob";
            this.dob.Size = new System.Drawing.Size(204, 20);
            this.dob.TabIndex = 28;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(84, 211);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 13);
            this.label7.TabIndex = 27;
            this.label7.Text = "Date of Birth";
            // 
            // address
            // 
            this.address.Location = new System.Drawing.Point(204, 302);
            this.address.Name = "address";
            this.address.Size = new System.Drawing.Size(204, 20);
            this.address.TabIndex = 30;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(84, 302);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(45, 13);
            this.label8.TabIndex = 29;
            this.label8.Text = "Address";
            // 
            // contactnum
            // 
            this.contactnum.Location = new System.Drawing.Point(204, 269);
            this.contactnum.Name = "contactnum";
            this.contactnum.Size = new System.Drawing.Size(204, 20);
            this.contactnum.TabIndex = 32;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(84, 272);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(84, 13);
            this.label9.TabIndex = 31;
            this.label9.Text = "Contact Number";
            // 
            // emergcontact
            // 
            this.emergcontact.Location = new System.Drawing.Point(204, 381);
            this.emergcontact.Name = "emergcontact";
            this.emergcontact.Size = new System.Drawing.Size(204, 20);
            this.emergcontact.TabIndex = 34;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(84, 381);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(100, 13);
            this.label10.TabIndex = 33;
            this.label10.Text = "Emergency Contact";
            // 
            // relationship
            // 
            this.relationship.Location = new System.Drawing.Point(204, 412);
            this.relationship.Name = "relationship";
            this.relationship.Size = new System.Drawing.Size(204, 20);
            this.relationship.TabIndex = 36;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(85, 412);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(65, 13);
            this.label11.TabIndex = 35;
            this.label11.Text = "Relationship";
            // 
            // contactemg
            // 
            this.contactemg.Location = new System.Drawing.Point(204, 447);
            this.contactemg.Name = "contactemg";
            this.contactemg.Size = new System.Drawing.Size(204, 20);
            this.contactemg.TabIndex = 38;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(85, 450);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(84, 13);
            this.label12.TabIndex = 37;
            this.label12.Text = "Contact Number";
            // 
            // gender
            // 
            this.gender.FormattingEnabled = true;
            this.gender.Items.AddRange(new object[] {
            "Female",
            "Male",
            "Other"});
            this.gender.Location = new System.Drawing.Point(204, 181);
            this.gender.Name = "gender";
            this.gender.Size = new System.Drawing.Size(204, 21);
            this.gender.TabIndex = 39;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(84, 345);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(144, 15);
            this.label4.TabIndex = 40;
            this.label4.Text = "In case of Emergency";
            // 
            // addpatient
            // 
            this.addpatient.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.addpatient.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addpatient.Location = new System.Drawing.Point(175, 509);
            this.addpatient.Name = "addpatient";
            this.addpatient.Size = new System.Drawing.Size(146, 41);
            this.addpatient.TabIndex = 41;
            this.addpatient.Text = "Add Patient";
            this.addpatient.UseVisualStyleBackColor = false;
            this.addpatient.Click += new System.EventHandler(this.addpatient_Click);
            // 
            // listpatient
            // 
            this.listpatient.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listpatient.Location = new System.Drawing.Point(509, 121);
            this.listpatient.Name = "listpatient";
            this.listpatient.Size = new System.Drawing.Size(595, 418);
            this.listpatient.TabIndex = 43;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(730, 85);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(105, 17);
            this.label13.TabIndex = 44;
            this.label13.Text = "View Patients";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(155, 61);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(40, 32);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 45;
            this.pictureBox2.TabStop = false;
            // 
            // Patients
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1116, 581);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.listpatient);
            this.Controls.Add(this.addpatient);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.gender);
            this.Controls.Add(this.contactemg);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.relationship);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.emergcontact);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.contactnum);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.address);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dob);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.email);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.fname);
            this.Controls.Add(this.labelfname);
            this.Controls.Add(this.refid);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Patients";
            this.Text = "Patients";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listpatient)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox refid;
        private System.Windows.Forms.TextBox fname;
        private System.Windows.Forms.Label labelfname;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox email;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox dob;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox address;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox contactnum;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox emergcontact;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox relationship;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox contactemg;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox gender;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button addpatient;
        private System.Windows.Forms.DataGridView listpatient;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}