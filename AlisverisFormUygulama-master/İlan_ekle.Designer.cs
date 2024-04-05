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
    partial class İlan_ekle
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.fiyat_ilan = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.kategori_ilan = new System.Windows.Forms.ComboBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.ozellik_ilan = new System.Windows.Forms.RichTextBox();
            this.button5 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.exitbutton = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.resim2_ilan = new System.Windows.Forms.PictureBox();
            this.resim1_ilan = new System.Windows.Forms.PictureBox();
            this.onemli = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.telefon_box = new System.Windows.Forms.MaskedTextBox();
            this.baslik_ilan = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.resim2_ilan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.resim1_ilan)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(73, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 18);
            this.label2.TabIndex = 7;
            this.label2.Text = "Kategori:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(73, 137);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 18);
            this.label1.TabIndex = 9;
            this.label1.Text = "Başlık";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(73, 187);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 18);
            this.label3.TabIndex = 11;
            this.label3.Text = "Fiyat:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(73, 284);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 18);
            this.label4.TabIndex = 13;
            this.label4.Text = "Genel Özellikler:";
            // 
            // fiyat_ilan
            // 
            this.fiyat_ilan.Location = new System.Drawing.Point(158, 187);
            this.fiyat_ilan.Name = "fiyat_ilan";
            this.fiyat_ilan.Size = new System.Drawing.Size(121, 20);
            this.fiyat_ilan.TabIndex = 16;
            this.fiyat_ilan.TextChanged += new System.EventHandler(this.fiyat_ilan_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 24.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(65, 19);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(186, 38);
            this.label6.TabIndex = 8;
            this.label6.Text = "İlan Ekleme";
            // 
            // kategori_ilan
            // 
            this.kategori_ilan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.kategori_ilan.FormattingEnabled = true;
            this.kategori_ilan.Items.AddRange(new object[] {
            "Elektronik",
            "Ev&Bahçe Eşyası",
            "Kıyafet",
            "Hobi",
            "Kitap",
            "Parti&Etkinlik",
            "Diğer"});
            this.kategori_ilan.Location = new System.Drawing.Point(158, 94);
            this.kategori_ilan.Name = "kategori_ilan";
            this.kategori_ilan.Size = new System.Drawing.Size(121, 21);
            this.kategori_ilan.TabIndex = 9;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // ozellik_ilan
            // 
            this.ozellik_ilan.BackColor = System.Drawing.Color.Snow;
            this.ozellik_ilan.Location = new System.Drawing.Point(76, 314);
            this.ozellik_ilan.Name = "ozellik_ilan";
            this.ozellik_ilan.Size = new System.Drawing.Size(298, 133);
            this.ozellik_ilan.TabIndex = 17;
            this.ozellik_ilan.Text = "";
            this.ozellik_ilan.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(113)))), ((int)(((byte)(255)))));
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.button5.ForeColor = System.Drawing.Color.White;
            this.button5.Location = new System.Drawing.Point(264, 520);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(274, 39);
            this.button5.TabIndex = 18;
            this.button5.Text = "İlanı Kaydet";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(113)))), ((int)(((byte)(255)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(554, 243);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(133, 26);
            this.button2.TabIndex = 19;
            this.button2.Text = "Kapak Resimin Seç";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(113)))), ((int)(((byte)(255)))));
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(554, 453);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(133, 26);
            this.button3.TabIndex = 20;
            this.button3.Text = "2. Resmi Seç";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
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
            this.exitbutton.Location = new System.Drawing.Point(766, 0);
            this.exitbutton.Name = "exitbutton";
            this.exitbutton.Size = new System.Drawing.Size(33, 36);
            this.exitbutton.TabIndex = 21;
            this.exitbutton.Text = "X";
            this.exitbutton.UseVisualStyleBackColor = true;
            this.exitbutton.Click += new System.EventHandler(this.exitbutton_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(113)))), ((int)(((byte)(255)))));
            this.panel2.Location = new System.Drawing.Point(61, 60);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(650, 1);
            this.panel2.TabIndex = 22;
            // 
            // resim2_ilan
            // 
            this.resim2_ilan.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.resim2_ilan.Location = new System.Drawing.Point(495, 297);
            this.resim2_ilan.Name = "resim2_ilan";
            this.resim2_ilan.Size = new System.Drawing.Size(254, 150);
            this.resim2_ilan.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.resim2_ilan.TabIndex = 6;
            this.resim2_ilan.TabStop = false;
            // 
            // resim1_ilan
            // 
            this.resim1_ilan.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.resim1_ilan.Location = new System.Drawing.Point(495, 83);
            this.resim1_ilan.Name = "resim1_ilan";
            this.resim1_ilan.Size = new System.Drawing.Size(254, 154);
            this.resim1_ilan.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.resim1_ilan.TabIndex = 4;
            this.resim1_ilan.TabStop = false;
            // 
            // onemli
            // 
            this.onemli.AutoSize = true;
            this.onemli.Location = new System.Drawing.Point(733, 560);
            this.onemli.Name = "onemli";
            this.onemli.Size = new System.Drawing.Size(0, 13);
            this.onemli.TabIndex = 23;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(73, 245);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(28, 18);
            this.label5.TabIndex = 24;
            this.label5.Text = "Tel";
            // 
            // telefon_box
            // 
            this.telefon_box.Location = new System.Drawing.Point(158, 248);
            this.telefon_box.Mask = "(999) 000-0000";
            this.telefon_box.Name = "telefon_box";
            this.telefon_box.Size = new System.Drawing.Size(121, 20);
            this.telefon_box.TabIndex = 25;
            // 
            // baslik_ilan
            // 
            this.baslik_ilan.Location = new System.Drawing.Point(158, 135);
            this.baslik_ilan.Name = "baslik_ilan";
            this.baslik_ilan.Size = new System.Drawing.Size(121, 20);
            this.baslik_ilan.TabIndex = 10;
            // 
            // İlan_ekle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.ClientSize = new System.Drawing.Size(800, 582);
            this.Controls.Add(this.telefon_box);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.onemli);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.exitbutton);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.ozellik_ilan);
            this.Controls.Add(this.resim2_ilan);
            this.Controls.Add(this.kategori_ilan);
            this.Controls.Add(this.resim1_ilan);
            this.Controls.Add(this.fiyat_ilan);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.baslik_ilan);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "İlan_ekle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.İlan_ekle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.resim2_ilan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.resim1_ilan)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox resim1_ilan;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox resim2_ilan;
        private System.Windows.Forms.TextBox fiyat_ilan;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox kategori_ilan;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.RichTextBox ozellik_ilan;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private Button exitbutton;
        private Panel panel2;
        private Label onemli;
        private Label label5;
        private MaskedTextBox telefon_box;
        private TextBox baslik_ilan;
    }
}