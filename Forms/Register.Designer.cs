
namespace Glimpses_Clinic.Forms
{
    partial class Register
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Register));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.DOB = new System.Windows.Forms.DateTimePicker();
            this.registerbtn = new System.Windows.Forms.Button();
            this.photext = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.addresstext = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.gendercombo = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.idtext = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.nametext = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.emailtext = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.MRbtn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.passwordtext = new System.Windows.Forms.TextBox();
            this.password = new System.Windows.Forms.Label();
            this.usernametext = new System.Windows.Forms.TextBox();
            this.username = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.passwordtext);
            this.panel1.Controls.Add(this.password);
            this.panel1.Controls.Add(this.usernametext);
            this.panel1.Controls.Add(this.username);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.DOB);
            this.panel1.Controls.Add(this.registerbtn);
            this.panel1.Controls.Add(this.photext);
            this.panel1.Controls.Add(this.label15);
            this.panel1.Controls.Add(this.addresstext);
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.gendercombo);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.idtext);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.nametext);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.emailtext);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(668, 598);
            this.panel1.TabIndex = 21;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(375, 3);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(121, 26);
            this.label5.TabIndex = 53;
            this.label5.Text = "National ID";
            // 
            // DOB
            // 
            this.DOB.CalendarFont = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DOB.Location = new System.Drawing.Point(188, 308);
            this.DOB.MaxDate = new System.DateTime(2020, 12, 31, 0, 0, 0, 0);
            this.DOB.Name = "DOB";
            this.DOB.Size = new System.Drawing.Size(272, 22);
            this.DOB.TabIndex = 52;
            this.DOB.Value = new System.DateTime(2020, 12, 31, 0, 0, 0, 0);
            // 
            // registerbtn
            // 
            this.registerbtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.registerbtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.registerbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registerbtn.Location = new System.Drawing.Point(506, 527);
            this.registerbtn.Name = "registerbtn";
            this.registerbtn.Size = new System.Drawing.Size(139, 58);
            this.registerbtn.TabIndex = 61;
            this.registerbtn.Text = "Register";
            this.registerbtn.UseVisualStyleBackColor = true;
            this.registerbtn.Click += new System.EventHandler(this.registerbtn_Click);
            // 
            // photext
            // 
            this.photext.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.photext.Font = new System.Drawing.Font("Microsoft YaHei", 9F);
            this.photext.Location = new System.Drawing.Point(447, 419);
            this.photext.MaxLength = 12;
            this.photext.Name = "photext";
            this.photext.Size = new System.Drawing.Size(196, 27);
            this.photext.TabIndex = 47;
            // 
            // label15
            // 
            this.label15.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label15.Location = new System.Drawing.Point(339, 419);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(71, 26);
            this.label15.TabIndex = 46;
            this.label15.Text = "Phone";
            // 
            // addresstext
            // 
            this.addresstext.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.addresstext.Font = new System.Drawing.Font("Microsoft YaHei", 9F);
            this.addresstext.Location = new System.Drawing.Point(120, 419);
            this.addresstext.MaxLength = 100;
            this.addresstext.Multiline = true;
            this.addresstext.Name = "addresstext";
            this.addresstext.Size = new System.Drawing.Size(192, 33);
            this.addresstext.TabIndex = 45;
            // 
            // label14
            // 
            this.label14.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label14.Location = new System.Drawing.Point(11, 419);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(89, 26);
            this.label14.TabIndex = 44;
            this.label14.Text = "Address";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Location = new System.Drawing.Point(11, 307);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(140, 26);
            this.label6.TabIndex = 32;
            this.label6.Text = "Date Of Birth";
            // 
            // gendercombo
            // 
            this.gendercombo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gendercombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.gendercombo.Font = new System.Drawing.Font("Microsoft YaHei", 9F);
            this.gendercombo.FormattingEnabled = true;
            this.gendercombo.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.gendercombo.Location = new System.Drawing.Point(188, 230);
            this.gendercombo.Name = "gendercombo";
            this.gendercombo.Size = new System.Drawing.Size(152, 28);
            this.gendercombo.TabIndex = 25;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Location = new System.Drawing.Point(-13, 397);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(710, 2);
            this.label2.TabIndex = 21;
            // 
            // idtext
            // 
            this.idtext.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.idtext.Font = new System.Drawing.Font("Microsoft YaHei", 9F);
            this.idtext.Location = new System.Drawing.Point(380, 51);
            this.idtext.MaxLength = 25;
            this.idtext.Name = "idtext";
            this.idtext.Size = new System.Drawing.Size(265, 27);
            this.idtext.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(11, 229);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 26);
            this.label4.TabIndex = 24;
            this.label4.Text = "Gender";
            // 
            // nametext
            // 
            this.nametext.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.nametext.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nametext.Location = new System.Drawing.Point(16, 51);
            this.nametext.MaxLength = 25;
            this.nametext.Name = "nametext";
            this.nametext.Size = new System.Drawing.Size(254, 27);
            this.nametext.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(11, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 26);
            this.label1.TabIndex = 21;
            this.label1.Text = "Name";
            // 
            // emailtext
            // 
            this.emailtext.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.emailtext.Font = new System.Drawing.Font("Microsoft YaHei", 9F);
            this.emailtext.Location = new System.Drawing.Point(188, 140);
            this.emailtext.MaxLength = 50;
            this.emailtext.Name = "emailtext";
            this.emailtext.Size = new System.Drawing.Size(285, 27);
            this.emailtext.TabIndex = 23;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(11, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 26);
            this.label3.TabIndex = 22;
            this.label3.Text = "E-mail";
            // 
            // MRbtn
            // 
            this.MRbtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MRbtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.MRbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MRbtn.Location = new System.Drawing.Point(882, 495);
            this.MRbtn.Name = "MRbtn";
            this.MRbtn.Size = new System.Drawing.Size(182, 54);
            this.MRbtn.TabIndex = 62;
            this.MRbtn.Text = "Medical Record";
            this.MRbtn.UseVisualStyleBackColor = true;
            this.MRbtn.Click += new System.EventHandler(this.MRbtn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = global::Glimpses_Clinic.Properties.Resources.Screenshot__967_;
            this.pictureBox1.Location = new System.Drawing.Point(674, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(571, 425);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 63;
            this.pictureBox1.TabStop = false;
            // 
            // passwordtext
            // 
            this.passwordtext.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.passwordtext.Font = new System.Drawing.Font("Microsoft YaHei", 9F);
            this.passwordtext.Location = new System.Drawing.Point(447, 494);
            this.passwordtext.MaxLength = 12;
            this.passwordtext.Name = "passwordtext";
            this.passwordtext.Size = new System.Drawing.Size(196, 27);
            this.passwordtext.TabIndex = 65;
            // 
            // password
            // 
            this.password.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.password.AutoSize = true;
            this.password.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.password.Location = new System.Drawing.Point(339, 494);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(102, 26);
            this.password.TabIndex = 64;
            this.password.Text = "Password";
            // 
            // usernametext
            // 
            this.usernametext.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.usernametext.Font = new System.Drawing.Font("Microsoft YaHei", 9F);
            this.usernametext.Location = new System.Drawing.Point(125, 487);
            this.usernametext.MaxLength = 100;
            this.usernametext.Multiline = true;
            this.usernametext.Name = "usernametext";
            this.usernametext.Size = new System.Drawing.Size(192, 33);
            this.usernametext.TabIndex = 63;
            // 
            // username
            // 
            this.username.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.username.AutoSize = true;
            this.username.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.username.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.username.Location = new System.Drawing.Point(11, 494);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(108, 26);
            this.username.TabIndex = 62;
            this.username.Text = "Username";
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1257, 598);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.MRbtn);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Register";
            this.Text = "Register";
            this.Load += new System.EventHandler(this.Register_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox photext;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox addresstext;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox gendercombo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox nametext;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox emailtext;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button registerbtn;
        private System.Windows.Forms.DateTimePicker DOB;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox idtext;
        private System.Windows.Forms.Button MRbtn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox passwordtext;
        private System.Windows.Forms.Label password;
        private System.Windows.Forms.TextBox usernametext;
        private System.Windows.Forms.Label username;
    }
}