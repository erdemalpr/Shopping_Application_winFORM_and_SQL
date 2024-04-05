using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace form_deneme
{
    partial class ilanlarım
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ilanlarım));
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.exitbutton = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.urun_panel1 = new System.Windows.Forms.Panel();
            this.button7 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.baslik1 = new System.Windows.Forms.Label();
            this.fiyat = new System.Windows.Forms.Label();
            this.baslik = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.urun_panel2 = new System.Windows.Forms.Panel();
            this.button8 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.baslik2 = new System.Windows.Forms.Label();
            this.fiyat2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.urun_panel3 = new System.Windows.Forms.Panel();
            this.button9 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.richTextBox3 = new System.Windows.Forms.RichTextBox();
            this.baslik3 = new System.Windows.Forms.Label();
            this.fiyat3 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.alt_panel = new System.Windows.Forms.Panel();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.flowLayoutPanel1.SuspendLayout();
            this.urun_panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.urun_panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.urun_panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.alt_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label1.Location = new System.Drawing.Point(24, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "İlanlarım";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(113)))), ((int)(((byte)(255)))));
            this.panel2.Location = new System.Drawing.Point(31, 50);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(650, 1);
            this.panel2.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(113)))), ((int)(((byte)(255)))));
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(113)))), ((int)(((byte)(255)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.button1.Location = new System.Drawing.Point(168, 13);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(76, 31);
            this.button1.TabIndex = 3;
            this.button1.Text = "Düzenle";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
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
            this.exitbutton.Location = new System.Drawing.Point(768, -1);
            this.exitbutton.Name = "exitbutton";
            this.exitbutton.Size = new System.Drawing.Size(30, 30);
            this.exitbutton.TabIndex = 4;
            this.exitbutton.Text = "X";
            this.exitbutton.UseVisualStyleBackColor = true;
            this.exitbutton.Click += new System.EventHandler(this.exitbutton_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Controls.Add(this.urun_panel1);
            this.flowLayoutPanel1.Controls.Add(this.urun_panel2);
            this.flowLayoutPanel1.Controls.Add(this.urun_panel3);
            this.flowLayoutPanel1.Controls.Add(this.alt_panel);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(12, 70);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(786, 500);
            this.flowLayoutPanel1.TabIndex = 5;
            this.flowLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel1_Paint);
            // 
            // urun_panel1
            // 
            this.urun_panel1.BackColor = System.Drawing.SystemColors.MenuBar;
            this.urun_panel1.Controls.Add(this.button7);
            this.urun_panel1.Controls.Add(this.label2);
            this.urun_panel1.Controls.Add(this.richTextBox1);
            this.urun_panel1.Controls.Add(this.baslik1);
            this.urun_panel1.Controls.Add(this.fiyat);
            this.urun_panel1.Controls.Add(this.baslik);
            this.urun_panel1.Controls.Add(this.pictureBox1);
            this.urun_panel1.Location = new System.Drawing.Point(3, 3);
            this.urun_panel1.Name = "urun_panel1";
            this.urun_panel1.Size = new System.Drawing.Size(246, 393);
            this.urun_panel1.TabIndex = 2;
            this.urun_panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.MediumBlue;
            this.button7.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button7.Location = new System.Drawing.Point(46, 361);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(150, 32);
            this.button7.TabIndex = 8;
            this.button7.Text = "İlanı Sil";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.label2.Location = new System.Drawing.Point(139, 329);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 18);
            this.label2.TabIndex = 7;
            this.label2.Text = "TL";
            this.label2.Click += new System.EventHandler(this.label2_Click_1);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(46, 198);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(161, 109);
            this.richTextBox1.TabIndex = 6;
            this.richTextBox1.Text = "";
            // 
            // baslik1
            // 
            this.baslik1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.baslik1.Location = new System.Drawing.Point(83, 147);
            this.baslik1.Name = "baslik1";
            this.baslik1.Size = new System.Drawing.Size(174, 34);
            this.baslik1.TabIndex = 4;
            this.baslik1.Text = "Başlık";
            this.baslik1.Click += new System.EventHandler(this.label2_Click);
            // 
            // fiyat
            // 
            this.fiyat.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.fiyat.Location = new System.Drawing.Point(84, 329);
            this.fiyat.Name = "fiyat";
            this.fiyat.Size = new System.Drawing.Size(34, 18);
            this.fiyat.TabIndex = 2;
            this.fiyat.Text = "fiyat";
            // 
            // baslik
            // 
            this.baslik.AutoSize = true;
            this.baslik.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.baslik.Location = new System.Drawing.Point(3, 216);
            this.baslik.Name = "baslik";
            this.baslik.Size = new System.Drawing.Size(0, 15);
            this.baslik.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(6, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(233, 141);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // urun_panel2
            // 
            this.urun_panel2.BackColor = System.Drawing.SystemColors.MenuBar;
            this.urun_panel2.Controls.Add(this.button8);
            this.urun_panel2.Controls.Add(this.label3);
            this.urun_panel2.Controls.Add(this.richTextBox2);
            this.urun_panel2.Controls.Add(this.baslik2);
            this.urun_panel2.Controls.Add(this.fiyat2);
            this.urun_panel2.Controls.Add(this.label6);
            this.urun_panel2.Controls.Add(this.pictureBox2);
            this.urun_panel2.Location = new System.Drawing.Point(255, 3);
            this.urun_panel2.Name = "urun_panel2";
            this.urun_panel2.Size = new System.Drawing.Size(244, 393);
            this.urun_panel2.TabIndex = 3;
            this.urun_panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint_1);
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.MediumBlue;
            this.button8.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button8.Location = new System.Drawing.Point(46, 358);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(150, 32);
            this.button8.TabIndex = 9;
            this.button8.Text = "İlanı Sil";
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.label3.Location = new System.Drawing.Point(123, 337);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 18);
            this.label3.TabIndex = 7;
            this.label3.Text = "TL";
            // 
            // richTextBox2
            // 
            this.richTextBox2.Location = new System.Drawing.Point(46, 198);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(150, 109);
            this.richTextBox2.TabIndex = 6;
            this.richTextBox2.Text = "";
            // 
            // baslik2
            // 
            this.baslik2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.baslik2.Location = new System.Drawing.Point(82, 147);
            this.baslik2.Name = "baslik2";
            this.baslik2.Size = new System.Drawing.Size(166, 34);
            this.baslik2.TabIndex = 4;
            this.baslik2.Text = "Başlık";
            // 
            // fiyat2
            // 
            this.fiyat2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.fiyat2.Location = new System.Drawing.Point(83, 337);
            this.fiyat2.Name = "fiyat2";
            this.fiyat2.Size = new System.Drawing.Size(34, 18);
            this.fiyat2.TabIndex = 2;
            this.fiyat2.Text = "fiyat2";
            this.fiyat2.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label6.Location = new System.Drawing.Point(3, 216);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 15);
            this.label6.TabIndex = 1;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(6, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(236, 141);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // urun_panel3
            // 
            this.urun_panel3.BackColor = System.Drawing.SystemColors.MenuBar;
            this.urun_panel3.Controls.Add(this.button9);
            this.urun_panel3.Controls.Add(this.label4);
            this.urun_panel3.Controls.Add(this.richTextBox3);
            this.urun_panel3.Controls.Add(this.baslik3);
            this.urun_panel3.Controls.Add(this.fiyat3);
            this.urun_panel3.Controls.Add(this.label9);
            this.urun_panel3.Controls.Add(this.pictureBox3);
            this.urun_panel3.Location = new System.Drawing.Point(505, 3);
            this.urun_panel3.Name = "urun_panel3";
            this.urun_panel3.Size = new System.Drawing.Size(249, 393);
            this.urun_panel3.TabIndex = 4;
            this.urun_panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.urun_panel3_Paint);
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.Color.MediumBlue;
            this.button9.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button9.Location = new System.Drawing.Point(46, 358);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(150, 32);
            this.button9.TabIndex = 10;
            this.button9.Text = "İlanı Sil";
            this.button9.UseVisualStyleBackColor = false;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.label4.Location = new System.Drawing.Point(121, 337);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 18);
            this.label4.TabIndex = 7;
            this.label4.Text = "TL";
            // 
            // richTextBox3
            // 
            this.richTextBox3.Location = new System.Drawing.Point(46, 198);
            this.richTextBox3.Name = "richTextBox3";
            this.richTextBox3.Size = new System.Drawing.Size(150, 109);
            this.richTextBox3.TabIndex = 6;
            this.richTextBox3.Text = "";
            this.richTextBox3.TextChanged += new System.EventHandler(this.richTextBox3_TextChanged);
            // 
            // baslik3
            // 
            this.baslik3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.baslik3.Location = new System.Drawing.Point(70, 147);
            this.baslik3.Name = "baslik3";
            this.baslik3.Size = new System.Drawing.Size(172, 34);
            this.baslik3.TabIndex = 4;
            this.baslik3.Text = "Başlık";
            // 
            // fiyat3
            // 
            this.fiyat3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.fiyat3.Location = new System.Drawing.Point(81, 337);
            this.fiyat3.Name = "fiyat3";
            this.fiyat3.Size = new System.Drawing.Size(34, 18);
            this.fiyat3.TabIndex = 2;
            this.fiyat3.Text = "fiyat2";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label9.Location = new System.Drawing.Point(3, 216);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(0, 15);
            this.label9.TabIndex = 1;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(6, 3);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(236, 141);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 0;
            this.pictureBox3.TabStop = false;
            // 
            // alt_panel
            // 
            this.alt_panel.Controls.Add(this.button6);
            this.alt_panel.Controls.Add(this.button5);
            this.alt_panel.Location = new System.Drawing.Point(3, 402);
            this.alt_panel.Name = "alt_panel";
            this.alt_panel.Size = new System.Drawing.Size(762, 81);
            this.alt_panel.TabIndex = 5;
            this.alt_panel.Paint += new System.Windows.Forms.PaintEventHandler(this.alt_panel_Paint);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.MediumBlue;
            this.button6.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button6.Location = new System.Drawing.Point(369, 48);
            this.button6.Name = "button6";
            this.button6.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.button6.Size = new System.Drawing.Size(24, 22);
            this.button6.TabIndex = 7;
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.MediumBlue;
            this.button5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button5.Location = new System.Drawing.Point(325, 48);
            this.button5.Name = "button5";
            this.button5.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.button5.Size = new System.Drawing.Size(24, 22);
            this.button5.TabIndex = 6;
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // ilanlarım
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.ClientSize = new System.Drawing.Size(802, 582);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.exitbutton);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ilanlarım";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Profilim";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Profilim_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.urun_panel1.ResumeLayout(false);
            this.urun_panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.urun_panel2.ResumeLayout(false);
            this.urun_panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.urun_panel3.ResumeLayout(false);
            this.urun_panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.alt_panel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Panel panel2;
        private Button button1;
        private Button exitbutton;
        private FlowLayoutPanel flowLayoutPanel1;
        private Panel urun_panel1;
        private Label baslik1;
        private Label fiyat;
        private Label baslik;
        private PictureBox pictureBox1;
        private RichTextBox richTextBox1;
        private Label label2;
        private Panel urun_panel2;
        private Label label3;
        private RichTextBox richTextBox2;
        private Label baslik2;
        private Label fiyat2;
        private Label label6;
        private PictureBox pictureBox2;
        private Panel urun_panel3;
        private Label label4;
        private RichTextBox richTextBox3;
        private Label baslik3;
        private Label fiyat3;
        private Label label9;
        private PictureBox pictureBox3;
        private Panel alt_panel;
        private Button button6;
        private Button button5;
        private Button button7;
        private Button button8;
        private Button button9;
    }
}