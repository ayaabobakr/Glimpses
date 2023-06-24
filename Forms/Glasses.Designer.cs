
namespace Glimpses_Clinic.Forms
{
    partial class Glasses
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
            this.submitbtn = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.material = new System.Windows.Forms.Label();
            this.lenstype = new System.Windows.Forms.Label();
            this.coating = new System.Windows.Forms.Label();
            this.typecb = new System.Windows.Forms.ComboBox();
            this.materialcb = new System.Windows.Forms.ComboBox();
            this.coatcb = new System.Windows.Forms.ComboBox();
            this.glassescb = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // submitbtn
            // 
            this.submitbtn.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.submitbtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.submitbtn.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submitbtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.submitbtn.Location = new System.Drawing.Point(267, 377);
            this.submitbtn.Name = "submitbtn";
            this.submitbtn.Size = new System.Drawing.Size(182, 63);
            this.submitbtn.TabIndex = 98;
            this.submitbtn.Text = "Submit";
            this.submitbtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.submitbtn.UseVisualStyleBackColor = true;
            this.submitbtn.Click += new System.EventHandler(this.submitbtn_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(-100, 292);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(83, 31);
            this.label11.TabIndex = 91;
            this.label11.Text = "NEAR";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(-100, 174);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(70, 31);
            this.label10.TabIndex = 90;
            this.label10.Text = "DIST";
            // 
            // material
            // 
            this.material.AutoSize = true;
            this.material.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.material.Location = new System.Drawing.Point(50, 204);
            this.material.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.material.Name = "material";
            this.material.Size = new System.Drawing.Size(177, 31);
            this.material.TabIndex = 100;
            this.material.Text = "Lens Material";
            // 
            // lenstype
            // 
            this.lenstype.AutoSize = true;
            this.lenstype.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lenstype.Location = new System.Drawing.Point(50, 120);
            this.lenstype.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lenstype.Name = "lenstype";
            this.lenstype.Size = new System.Drawing.Size(135, 31);
            this.lenstype.TabIndex = 99;
            this.lenstype.Text = "Lens Type";
            // 
            // coating
            // 
            this.coating.AutoSize = true;
            this.coating.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.coating.Location = new System.Drawing.Point(50, 291);
            this.coating.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.coating.Name = "coating";
            this.coating.Size = new System.Drawing.Size(109, 31);
            this.coating.TabIndex = 103;
            this.coating.Text = "Coating";
            // 
            // typecb
            // 
            this.typecb.FormattingEnabled = true;
            this.typecb.Items.AddRange(new object[] {
            "Everyday Lens",
            "Sunglasses",
            "Blue Light Blocking Lenses"});
            this.typecb.Location = new System.Drawing.Point(267, 120);
            this.typecb.Name = "typecb";
            this.typecb.Size = new System.Drawing.Size(283, 24);
            this.typecb.TabIndex = 104;
            // 
            // materialcb
            // 
            this.materialcb.FormattingEnabled = true;
            this.materialcb.Items.AddRange(new object[] {
            "Polycarbonate",
            "Trivex",
            "Cr-39"});
            this.materialcb.Location = new System.Drawing.Point(267, 204);
            this.materialcb.Name = "materialcb";
            this.materialcb.Size = new System.Drawing.Size(283, 24);
            this.materialcb.TabIndex = 105;
            // 
            // coatcb
            // 
            this.coatcb.FormattingEnabled = true;
            this.coatcb.Items.AddRange(new object[] {
            "Standard",
            "Super Double-thick"});
            this.coatcb.Location = new System.Drawing.Point(267, 300);
            this.coatcb.Name = "coatcb";
            this.coatcb.Size = new System.Drawing.Size(283, 24);
            this.coatcb.TabIndex = 106;
            // 
            // glassescb
            // 
            this.glassescb.FormattingEnabled = true;
            this.glassescb.Items.AddRange(new object[] {
            "Cat Eye Women Glasses",
            "Aviator Sunglasses",
            "Rimless Round Sunglasses"});
            this.glassescb.Location = new System.Drawing.Point(267, 42);
            this.glassescb.Name = "glassescb";
            this.glassescb.Size = new System.Drawing.Size(283, 24);
            this.glassescb.TabIndex = 108;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(50, 42);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 31);
            this.label1.TabIndex = 107;
            this.label1.Text = "Glasses";
            // 
            // Glasses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(712, 461);
            this.Controls.Add(this.glassescb);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.coatcb);
            this.Controls.Add(this.materialcb);
            this.Controls.Add(this.typecb);
            this.Controls.Add(this.coating);
            this.Controls.Add(this.material);
            this.Controls.Add(this.lenstype);
            this.Controls.Add(this.submitbtn);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Glasses";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Glasses";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button submitbtn;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label material;
        private System.Windows.Forms.Label lenstype;
        private System.Windows.Forms.Label coating;
        private System.Windows.Forms.ComboBox typecb;
        private System.Windows.Forms.ComboBox materialcb;
        private System.Windows.Forms.ComboBox coatcb;
        private System.Windows.Forms.ComboBox glassescb;
        private System.Windows.Forms.Label label1;
    }
}