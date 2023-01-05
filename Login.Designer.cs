
namespace Glimpses_Clinic
{
    partial class Login
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
            this.pwtext = new System.Windows.Forms.TextBox();
            this.usertext = new System.Windows.Forms.TextBox();
            this.loginbtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.loginlabel = new System.Windows.Forms.Label();
            this.rolebox = new System.Windows.Forms.ComboBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pwtext
            // 
            this.pwtext.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.pwtext.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pwtext.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(84)))), ((int)(((byte)(110)))));
            this.pwtext.Location = new System.Drawing.Point(78, 372);
            this.pwtext.Name = "pwtext";
            this.pwtext.Size = new System.Drawing.Size(364, 24);
            this.pwtext.TabIndex = 101;
            this.pwtext.UseSystemPasswordChar = true;
            // 
            // usertext
            // 
            this.usertext.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.usertext.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usertext.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(84)))), ((int)(((byte)(110)))));
            this.usertext.Location = new System.Drawing.Point(78, 260);
            this.usertext.Name = "usertext";
            this.usertext.Size = new System.Drawing.Size(364, 24);
            this.usertext.TabIndex = 100;
            // 
            // loginbtn
            // 
            this.loginbtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.loginbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(84)))), ((int)(((byte)(110)))));
            this.loginbtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.loginbtn.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginbtn.ForeColor = System.Drawing.Color.White;
            this.loginbtn.Location = new System.Drawing.Point(42, 508);
            this.loginbtn.Name = "loginbtn";
            this.loginbtn.Size = new System.Drawing.Size(400, 52);
            this.loginbtn.TabIndex = 98;
            this.loginbtn.Text = "LOG IN";
            this.loginbtn.UseVisualStyleBackColor = false;
            this.loginbtn.Click += new System.EventHandler(this.loginbtn_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(84)))), ((int)(((byte)(110)))));
            this.label1.Location = new System.Drawing.Point(42, 405);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(400, 2);
            this.label1.TabIndex = 97;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(84)))), ((int)(((byte)(110)))));
            this.label2.Location = new System.Drawing.Point(42, 293);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(400, 2);
            this.label2.TabIndex = 96;
            // 
            // loginlabel
            // 
            this.loginlabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.loginlabel.AutoSize = true;
            this.loginlabel.Font = new System.Drawing.Font("Microsoft Tai Le", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginlabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(84)))), ((int)(((byte)(110)))));
            this.loginlabel.Location = new System.Drawing.Point(136, 181);
            this.loginlabel.Name = "loginlabel";
            this.loginlabel.Size = new System.Drawing.Size(210, 31);
            this.loginlabel.TabIndex = 93;
            this.loginlabel.Text = "ACCOUNT LOGIN";
            // 
            // rolebox
            // 
            this.rolebox.BackColor = System.Drawing.Color.White;
            this.rolebox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.rolebox.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rolebox.FormattingEnabled = true;
            this.rolebox.Items.AddRange(new object[] {
            "Doctor",
            "Receptionist"});
            this.rolebox.Location = new System.Drawing.Point(154, 439);
            this.rolebox.Name = "rolebox";
            this.rolebox.Size = new System.Drawing.Size(177, 31);
            this.rolebox.TabIndex = 102;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox2.Image = global::Glimpses_Clinic.Properties.Resources.icons8_lock_30;
            this.pictureBox2.Location = new System.Drawing.Point(42, 372);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(30, 30);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 95;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Image = global::Glimpses_Clinic.Properties.Resources.icons8_customer_301;
            this.pictureBox1.Location = new System.Drawing.Point(42, 260);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(30, 30);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 94;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Image = global::Glimpses_Clinic.Properties.Resources.icons8_uchiha_eyes_96;
            this.button1.Location = new System.Drawing.Point(154, 58);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(177, 102);
            this.button1.TabIndex = 92;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(485, 628);
            this.Controls.Add(this.rolebox);
            this.Controls.Add(this.pwtext);
            this.Controls.Add(this.usertext);
            this.Controls.Add(this.loginbtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.loginlabel);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Log In";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox pwtext;
        private System.Windows.Forms.TextBox usertext;
        private System.Windows.Forms.Button loginbtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label loginlabel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox rolebox;
    }
}