
namespace Glimpses_Clinic.Forms
{
    partial class OCR
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.checkbtn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(705, 88);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(453, 372);
            this.textBox1.TabIndex = 5;
            // 
            // checkbtn
            // 
            this.checkbtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.checkbtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.checkbtn.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkbtn.Location = new System.Drawing.Point(259, 441);
            this.checkbtn.Name = "checkbtn";
            this.checkbtn.Size = new System.Drawing.Size(143, 67);
            this.checkbtn.TabIndex = 4;
            this.checkbtn.Text = "Convert";
            this.checkbtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.checkbtn.UseVisualStyleBackColor = true;
            this.checkbtn.Click += new System.EventHandler(this.checkbtn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(49, 179);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(592, 204);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // OCR
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1244, 590);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.checkbtn);
            this.Controls.Add(this.pictureBox1);
            this.Name = "OCR";
            this.Text = "OCR";
            this.Load += new System.EventHandler(this.OCR_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button checkbtn;
        private System.Windows.Forms.TextBox textBox1;
    }
}