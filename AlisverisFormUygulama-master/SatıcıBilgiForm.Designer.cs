namespace form_deneme
{
    partial class SatıcıBilgiForm
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.isim_soyisim = new System.Windows.Forms.Label();
            this.tel_label = new System.Windows.Forms.Label();
            this.telefon_num = new System.Windows.Forms.Label();
            this.exitbutton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(35, 32);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(164, 159);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // isim_soyisim
            // 
            this.isim_soyisim.AutoSize = true;
            this.isim_soyisim.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.isim_soyisim.ForeColor = System.Drawing.Color.White;
            this.isim_soyisim.Location = new System.Drawing.Point(61, 216);
            this.isim_soyisim.Name = "isim_soyisim";
            this.isim_soyisim.Size = new System.Drawing.Size(96, 20);
            this.isim_soyisim.TabIndex = 1;
            this.isim_soyisim.Text = "İsim Soyisim";
            // 
            // tel_label
            // 
            this.tel_label.AutoSize = true;
            this.tel_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tel_label.ForeColor = System.Drawing.Color.White;
            this.tel_label.Location = new System.Drawing.Point(12, 314);
            this.tel_label.Name = "tel_label";
            this.tel_label.Size = new System.Drawing.Size(34, 20);
            this.tel_label.TabIndex = 4;
            this.tel_label.Text = "Tel:";
            // 
            // telefon_num
            // 
            this.telefon_num.AutoSize = true;
            this.telefon_num.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.telefon_num.ForeColor = System.Drawing.Color.White;
            this.telefon_num.Location = new System.Drawing.Point(52, 314);
            this.telefon_num.Name = "telefon_num";
            this.telefon_num.Size = new System.Drawing.Size(59, 20);
            this.telefon_num.TabIndex = 5;
            this.telefon_num.Text = "----------";
            // 
            // exitbutton
            // 
            this.exitbutton.BackColor = System.Drawing.Color.Transparent;
            this.exitbutton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exitbutton.FlatAppearance.BorderSize = 0;
            this.exitbutton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(113)))), ((int)(((byte)(255)))));
            this.exitbutton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(113)))), ((int)(((byte)(255)))));
            this.exitbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitbutton.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold);
            this.exitbutton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.exitbutton.Location = new System.Drawing.Point(205, -4);
            this.exitbutton.Name = "exitbutton";
            this.exitbutton.Size = new System.Drawing.Size(33, 36);
            this.exitbutton.TabIndex = 23;
            this.exitbutton.Text = "X";
            this.exitbutton.UseVisualStyleBackColor = true;
            this.exitbutton.Click += new System.EventHandler(this.exitbutton_Click);
            // 
            // SatıcıBilgiForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.ClientSize = new System.Drawing.Size(235, 418);
            this.Controls.Add(this.exitbutton);
            this.Controls.Add(this.telefon_num);
            this.Controls.Add(this.tel_label);
            this.Controls.Add(this.isim_soyisim);
            this.Controls.Add(this.pictureBox1);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SatıcıBilgiForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SatıcıBilgiForm";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.SatıcıBilgiForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label isim_soyisim;
        private System.Windows.Forms.Label tel_label;
        private System.Windows.Forms.Label telefon_num;
        private System.Windows.Forms.Button exitbutton;
    }
}