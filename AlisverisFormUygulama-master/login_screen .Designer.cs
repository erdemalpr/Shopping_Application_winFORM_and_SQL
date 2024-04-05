using System.Windows.Forms;

namespace form_deneme
{
    partial class login_screen
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Button systraybutton;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(login_screen));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.copyright = new System.Windows.Forms.Label();
            this.exitbutton = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.username = new System.Windows.Forms.TextBox();
            this.password = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.loggin = new System.Windows.Forms.Button();
            this.register = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.register_panel = new System.Windows.Forms.Panel();
            this.Vazgec = new System.Windows.Forms.Button();
            this.Hesap_Olustur = new System.Windows.Forms.Button();
            this.panel10 = new System.Windows.Forms.Panel();
            this.passwordagain_regist = new System.Windows.Forms.TextBox();
            this.textBox12 = new System.Windows.Forms.TextBox();
            this.textBox13 = new System.Windows.Forms.TextBox();
            this.textBox14 = new System.Windows.Forms.TextBox();
            this.panel9 = new System.Windows.Forms.Panel();
            this.password_regist = new System.Windows.Forms.TextBox();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.panel8 = new System.Windows.Forms.Panel();
            this.surname_regist = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.panel7 = new System.Windows.Forms.Panel();
            this.name_regist = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.mail_regist = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.login_panel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.button2 = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            systraybutton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.register_panel.SuspendLayout();
            this.panel10.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel6.SuspendLayout();
            this.login_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // systraybutton
            // 
            systraybutton.BackColor = System.Drawing.Color.Transparent;
            systraybutton.Cursor = System.Windows.Forms.Cursors.Hand;
            systraybutton.FlatAppearance.BorderSize = 0;
            systraybutton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(113)))), ((int)(((byte)(255)))));
            systraybutton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(113)))), ((int)(((byte)(255)))));
            systraybutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            systraybutton.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold);
            systraybutton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            systraybutton.Location = new System.Drawing.Point(726, 0);
            systraybutton.Name = "systraybutton";
            systraybutton.Size = new System.Drawing.Size(34, 35);
            systraybutton.TabIndex = 2;
            systraybutton.Text = "-";
            systraybutton.UseVisualStyleBackColor = true;
            systraybutton.Click += new System.EventHandler(this.button2_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(54)))), ((int)(((byte)(234)))));
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.copyright);
            this.panel1.Controls.Add(this.pictureBox4);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(273, 464);
            this.panel1.TabIndex = 0;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century", 20.25F);
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(57, 206);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(164, 33);
            this.label3.TabIndex = 28;
            this.label3.Text = "Fazlalıkları";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century", 20.25F);
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(17, 235);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(252, 33);
            this.label4.TabIndex = 29;
            this.label4.Text = "Nakite Çevir Veya";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century", 20.25F);
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(75, 262);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 33);
            this.label2.TabIndex = 30;
            this.label2.Text = "Satın al";
            // 
            // copyright
            // 
            this.copyright.AutoSize = true;
            this.copyright.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(113)))), ((int)(((byte)(244)))));
            this.copyright.Font = new System.Drawing.Font("Lucida Sans", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.copyright.ForeColor = System.Drawing.Color.Transparent;
            this.copyright.Location = new System.Drawing.Point(3, 449);
            this.copyright.Name = "copyright";
            this.copyright.Size = new System.Drawing.Size(125, 15);
            this.copyright.TabIndex = 2;
            this.copyright.Text = "Metafour   © 2022";
            // 
            // exitbutton
            // 
            this.exitbutton.BackColor = System.Drawing.Color.Transparent;
            this.exitbutton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exitbutton.FlatAppearance.BorderSize = 0;
            this.exitbutton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(113)))), ((int)(((byte)(255)))));
            this.exitbutton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(113)))), ((int)(((byte)(255)))));
            this.exitbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitbutton.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold);
            this.exitbutton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.exitbutton.Location = new System.Drawing.Point(765, 0);
            this.exitbutton.Name = "exitbutton";
            this.exitbutton.Size = new System.Drawing.Size(34, 35);
            this.exitbutton.TabIndex = 1;
            this.exitbutton.Text = "X";
            this.exitbutton.UseVisualStyleBackColor = true;
            this.exitbutton.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(113)))), ((int)(((byte)(255)))));
            this.panel3.Location = new System.Drawing.Point(142, 242);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(289, 2);
            this.panel3.TabIndex = 7;
            // 
            // username
            // 
            this.username.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.username.BackColor = System.Drawing.SystemColors.Control;
            this.username.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.username.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.username.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold);
            this.username.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.username.HideSelection = false;
            this.username.ImeMode = System.Windows.Forms.ImeMode.On;
            this.username.Location = new System.Drawing.Point(5, 7);
            this.username.MaxLength = 30;
            this.username.Multiline = true;
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(279, 25);
            this.username.TabIndex = 8;
            this.username.Text = "E-mail";
            this.username.Click += new System.EventHandler(this.username_Click);
            this.username.Enter += new System.EventHandler(this.username_Enter);
            this.username.Leave += new System.EventHandler(this.username_Leave);
            // 
            // password
            // 
            this.password.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.password.BackColor = System.Drawing.SystemColors.Control;
            this.password.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.password.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.password.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold);
            this.password.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.password.HideSelection = false;
            this.password.ImeMode = System.Windows.Forms.ImeMode.On;
            this.password.Location = new System.Drawing.Point(5, 7);
            this.password.MaxLength = 30;
            this.password.Multiline = true;
            this.password.Name = "password";
            this.password.PasswordChar = '*';
            this.password.Size = new System.Drawing.Size(252, 27);
            this.password.TabIndex = 13;
            this.password.Text = "Parola";
            this.password.UseSystemPasswordChar = true;
            this.password.Click += new System.EventHandler(this.password_Click);
            this.password.TextChanged += new System.EventHandler(this.password_TextChanged_1);
            this.password.Enter += new System.EventHandler(this.password_Enter);
            this.password.Leave += new System.EventHandler(this.password_Leave);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(113)))), ((int)(((byte)(255)))));
            this.panel2.Location = new System.Drawing.Point(142, 166);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(289, 2);
            this.panel2.TabIndex = 14;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.Control;
            this.panel4.Controls.Add(this.username);
            this.panel4.Location = new System.Drawing.Point(142, 122);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(287, 39);
            this.panel4.TabIndex = 18;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.Control;
            this.panel5.Controls.Add(this.textBox1);
            this.panel5.Controls.Add(this.password);
            this.panel5.Controls.Add(this.button2);
            this.panel5.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.panel5.Location = new System.Drawing.Point(142, 198);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(287, 39);
            this.panel5.TabIndex = 19;
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBox1.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            this.textBox1.HideSelection = false;
            this.textBox1.ImeMode = System.Windows.Forms.ImeMode.On;
            this.textBox1.Location = new System.Drawing.Point(5, -42);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(394, 25);
            this.textBox1.TabIndex = 8;
            this.textBox1.Text = "e-mail";
            // 
            // loggin
            // 
            this.loggin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(113)))), ((int)(((byte)(255)))));
            this.loggin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.loggin.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.loggin.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.loggin.Font = new System.Drawing.Font("Century Schoolbook", 18F);
            this.loggin.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.loggin.Location = new System.Drawing.Point(141, 292);
            this.loggin.Name = "loggin";
            this.loggin.Size = new System.Drawing.Size(285, 43);
            this.loggin.TabIndex = 20;
            this.loggin.Text = "Giriş Yap";
            this.loggin.UseVisualStyleBackColor = false;
            this.loggin.BackColorChanged += new System.EventHandler(this.loggin_BackColorChanged);
            this.loggin.Click += new System.EventHandler(this.loggin_Click);
            // 
            // register
            // 
            this.register.BackColor = System.Drawing.Color.Transparent;
            this.register.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.register.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.register.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.register.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.register.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.register.Font = new System.Drawing.Font("Century Schoolbook", 18F);
            this.register.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.register.Location = new System.Drawing.Point(141, 352);
            this.register.Name = "register";
            this.register.Size = new System.Drawing.Size(285, 43);
            this.register.TabIndex = 23;
            this.register.Text = "Kayıt Ol";
            this.register.UseVisualStyleBackColor = false;
            this.register.Click += new System.EventHandler(this.register_Click_1);
            // 
            // register_panel
            // 
            this.register_panel.Controls.Add(this.Vazgec);
            this.register_panel.Controls.Add(this.Hesap_Olustur);
            this.register_panel.Controls.Add(this.panel10);
            this.register_panel.Controls.Add(this.panel9);
            this.register_panel.Controls.Add(this.panel8);
            this.register_panel.Controls.Add(this.panel7);
            this.register_panel.Controls.Add(this.panel6);
            this.register_panel.Location = new System.Drawing.Point(275, 100);
            this.register_panel.Name = "register_panel";
            this.register_panel.Size = new System.Drawing.Size(527, 364);
            this.register_panel.TabIndex = 28;
            this.register_panel.Visible = false;
            this.register_panel.Paint += new System.Windows.Forms.PaintEventHandler(this.register_panel_Paint);
            // 
            // Vazgec
            // 
            this.Vazgec.BackColor = System.Drawing.Color.Transparent;
            this.Vazgec.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Vazgec.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.Vazgec.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.Vazgec.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.Vazgec.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Vazgec.Font = new System.Drawing.Font("Century Schoolbook", 18F);
            this.Vazgec.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Vazgec.Location = new System.Drawing.Point(147, 319);
            this.Vazgec.Name = "Vazgec";
            this.Vazgec.Size = new System.Drawing.Size(285, 43);
            this.Vazgec.TabIndex = 31;
            this.Vazgec.Text = "Vazgeç";
            this.Vazgec.UseVisualStyleBackColor = false;
            this.Vazgec.Click += new System.EventHandler(this.Vazgec_Click);
            // 
            // Hesap_Olustur
            // 
            this.Hesap_Olustur.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(113)))), ((int)(((byte)(255)))));
            this.Hesap_Olustur.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Hesap_Olustur.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.Hesap_Olustur.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Hesap_Olustur.Font = new System.Drawing.Font("Century Schoolbook", 18F);
            this.Hesap_Olustur.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Hesap_Olustur.Location = new System.Drawing.Point(147, 259);
            this.Hesap_Olustur.Name = "Hesap_Olustur";
            this.Hesap_Olustur.Size = new System.Drawing.Size(285, 43);
            this.Hesap_Olustur.TabIndex = 30;
            this.Hesap_Olustur.Text = "Hesap Oluştur";
            this.Hesap_Olustur.UseVisualStyleBackColor = false;
            this.Hesap_Olustur.Click += new System.EventHandler(this.Hesap_Olustur_Click);
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.SystemColors.Control;
            this.panel10.Controls.Add(this.passwordagain_regist);
            this.panel10.Controls.Add(this.textBox12);
            this.panel10.Controls.Add(this.textBox13);
            this.panel10.Controls.Add(this.textBox14);
            this.panel10.Location = new System.Drawing.Point(122, 182);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(317, 39);
            this.panel10.TabIndex = 29;
            // 
            // passwordagain_regist
            // 
            this.passwordagain_regist.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.passwordagain_regist.BackColor = System.Drawing.SystemColors.Control;
            this.passwordagain_regist.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.passwordagain_regist.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.passwordagain_regist.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold);
            this.passwordagain_regist.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.passwordagain_regist.HideSelection = false;
            this.passwordagain_regist.ImeMode = System.Windows.Forms.ImeMode.On;
            this.passwordagain_regist.Location = new System.Drawing.Point(4, 7);
            this.passwordagain_regist.MaxLength = 50;
            this.passwordagain_regist.Multiline = true;
            this.passwordagain_regist.Name = "passwordagain_regist";
            this.passwordagain_regist.Size = new System.Drawing.Size(309, 25);
            this.passwordagain_regist.TabIndex = 13;
            this.passwordagain_regist.Text = "Şifre tekrar";
            this.passwordagain_regist.Click += new System.EventHandler(this.passwordagain_regist_Click);
            this.passwordagain_regist.Enter += new System.EventHandler(this.passwordagain_regist_Enter);
            this.passwordagain_regist.Leave += new System.EventHandler(this.passwordagain_regist_Leave);
            // 
            // textBox12
            // 
            this.textBox12.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox12.BackColor = System.Drawing.SystemColors.Control;
            this.textBox12.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox12.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBox12.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold);
            this.textBox12.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.textBox12.HideSelection = false;
            this.textBox12.ImeMode = System.Windows.Forms.ImeMode.On;
            this.textBox12.Location = new System.Drawing.Point(4, 7);
            this.textBox12.Multiline = true;
            this.textBox12.Name = "textBox12";
            this.textBox12.Size = new System.Drawing.Size(455, 0);
            this.textBox12.TabIndex = 12;
            this.textBox12.Text = "Şifre";
            // 
            // textBox13
            // 
            this.textBox13.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox13.BackColor = System.Drawing.SystemColors.Control;
            this.textBox13.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox13.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBox13.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold);
            this.textBox13.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.textBox13.HideSelection = false;
            this.textBox13.ImeMode = System.Windows.Forms.ImeMode.On;
            this.textBox13.Location = new System.Drawing.Point(2, 7);
            this.textBox13.Multiline = true;
            this.textBox13.Name = "textBox13";
            this.textBox13.Size = new System.Drawing.Size(601, 0);
            this.textBox13.TabIndex = 11;
            this.textBox13.Text = "E-mail adresin";
            // 
            // textBox14
            // 
            this.textBox14.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox14.BackColor = System.Drawing.SystemColors.Control;
            this.textBox14.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox14.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBox14.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold);
            this.textBox14.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.textBox14.HideSelection = false;
            this.textBox14.ImeMode = System.Windows.Forms.ImeMode.On;
            this.textBox14.Location = new System.Drawing.Point(5, 7);
            this.textBox14.Multiline = true;
            this.textBox14.Name = "textBox14";
            this.textBox14.Size = new System.Drawing.Size(717, 0);
            this.textBox14.TabIndex = 8;
            this.textBox14.Text = "E-mail";
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.SystemColors.Control;
            this.panel9.Controls.Add(this.password_regist);
            this.panel9.Controls.Add(this.textBox9);
            this.panel9.Controls.Add(this.textBox10);
            this.panel9.Location = new System.Drawing.Point(122, 121);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(317, 39);
            this.panel9.TabIndex = 28;
            // 
            // password_regist
            // 
            this.password_regist.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.password_regist.BackColor = System.Drawing.SystemColors.Control;
            this.password_regist.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.password_regist.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.password_regist.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold);
            this.password_regist.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.password_regist.HideSelection = false;
            this.password_regist.ImeMode = System.Windows.Forms.ImeMode.On;
            this.password_regist.Location = new System.Drawing.Point(4, 7);
            this.password_regist.MaxLength = 50;
            this.password_regist.Multiline = true;
            this.password_regist.Name = "password_regist";
            this.password_regist.Size = new System.Drawing.Size(309, 25);
            this.password_regist.TabIndex = 12;
            this.password_regist.Text = "Şifre";
            this.password_regist.Click += new System.EventHandler(this.password_regist_Click);
            this.password_regist.Enter += new System.EventHandler(this.password_regist_Enter);
            this.password_regist.Leave += new System.EventHandler(this.password_regist_Leave);
            // 
            // textBox9
            // 
            this.textBox9.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox9.BackColor = System.Drawing.SystemColors.Control;
            this.textBox9.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox9.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBox9.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold);
            this.textBox9.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.textBox9.HideSelection = false;
            this.textBox9.ImeMode = System.Windows.Forms.ImeMode.On;
            this.textBox9.Location = new System.Drawing.Point(2, 7);
            this.textBox9.Multiline = true;
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(455, 0);
            this.textBox9.TabIndex = 11;
            this.textBox9.Text = "E-mail adresin";
            // 
            // textBox10
            // 
            this.textBox10.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox10.BackColor = System.Drawing.SystemColors.Control;
            this.textBox10.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox10.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBox10.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold);
            this.textBox10.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.textBox10.HideSelection = false;
            this.textBox10.ImeMode = System.Windows.Forms.ImeMode.On;
            this.textBox10.Location = new System.Drawing.Point(5, 7);
            this.textBox10.Multiline = true;
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(571, 0);
            this.textBox10.TabIndex = 8;
            this.textBox10.Text = "E-mail";
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.SystemColors.Control;
            this.panel8.Controls.Add(this.surname_regist);
            this.panel8.Controls.Add(this.textBox3);
            this.panel8.Controls.Add(this.textBox6);
            this.panel8.Controls.Add(this.textBox7);
            this.panel8.Location = new System.Drawing.Point(293, 5);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(146, 39);
            this.panel8.TabIndex = 27;
            // 
            // surname_regist
            // 
            this.surname_regist.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.surname_regist.BackColor = System.Drawing.SystemColors.Control;
            this.surname_regist.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.surname_regist.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.surname_regist.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold);
            this.surname_regist.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.surname_regist.HideSelection = false;
            this.surname_regist.ImeMode = System.Windows.Forms.ImeMode.On;
            this.surname_regist.Location = new System.Drawing.Point(4, 7);
            this.surname_regist.Multiline = true;
            this.surname_regist.Name = "surname_regist";
            this.surname_regist.Size = new System.Drawing.Size(138, 25);
            this.surname_regist.TabIndex = 11;
            this.surname_regist.Text = "Soyad";
            this.surname_regist.Click += new System.EventHandler(this.surname_regist_Click);
            this.surname_regist.Enter += new System.EventHandler(this.surname_regist_Enter);
            this.surname_regist.Leave += new System.EventHandler(this.surname_regist_Leave);
            // 
            // textBox3
            // 
            this.textBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox3.BackColor = System.Drawing.SystemColors.Control;
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox3.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBox3.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold);
            this.textBox3.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.textBox3.HideSelection = false;
            this.textBox3.ImeMode = System.Windows.Forms.ImeMode.On;
            this.textBox3.Location = new System.Drawing.Point(3, 7);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(83, 0);
            this.textBox3.TabIndex = 10;
            this.textBox3.Text = "E-mail";
            // 
            // textBox6
            // 
            this.textBox6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox6.BackColor = System.Drawing.SystemColors.Control;
            this.textBox6.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox6.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBox6.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold);
            this.textBox6.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.textBox6.HideSelection = false;
            this.textBox6.ImeMode = System.Windows.Forms.ImeMode.On;
            this.textBox6.Location = new System.Drawing.Point(3, 7);
            this.textBox6.Multiline = true;
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(199, 0);
            this.textBox6.TabIndex = 9;
            this.textBox6.Text = "E-mail";
            // 
            // textBox7
            // 
            this.textBox7.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox7.BackColor = System.Drawing.SystemColors.Control;
            this.textBox7.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox7.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBox7.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold);
            this.textBox7.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.textBox7.HideSelection = false;
            this.textBox7.ImeMode = System.Windows.Forms.ImeMode.On;
            this.textBox7.Location = new System.Drawing.Point(5, 7);
            this.textBox7.Multiline = true;
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(315, 0);
            this.textBox7.TabIndex = 8;
            this.textBox7.Text = "E-mail";
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.SystemColors.Control;
            this.panel7.Controls.Add(this.name_regist);
            this.panel7.Controls.Add(this.textBox4);
            this.panel7.Controls.Add(this.textBox5);
            this.panel7.Location = new System.Drawing.Point(122, 5);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(146, 39);
            this.panel7.TabIndex = 26;
            // 
            // name_regist
            // 
            this.name_regist.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.name_regist.BackColor = System.Drawing.SystemColors.Control;
            this.name_regist.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.name_regist.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.name_regist.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold);
            this.name_regist.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.name_regist.HideSelection = false;
            this.name_regist.ImeMode = System.Windows.Forms.ImeMode.On;
            this.name_regist.Location = new System.Drawing.Point(2, 7);
            this.name_regist.MaxLength = 30;
            this.name_regist.Multiline = true;
            this.name_regist.Name = "name_regist";
            this.name_regist.Size = new System.Drawing.Size(138, 25);
            this.name_regist.TabIndex = 10;
            this.name_regist.Text = "Ad";
            this.name_regist.Click += new System.EventHandler(this.name_regist_Click);
            this.name_regist.TextChanged += new System.EventHandler(this.name_regist_TextChanged);
            this.name_regist.Enter += new System.EventHandler(this.name_regist_Enter);
            this.name_regist.Leave += new System.EventHandler(this.name_regist_Leave);
            // 
            // textBox4
            // 
            this.textBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox4.BackColor = System.Drawing.SystemColors.Control;
            this.textBox4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox4.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBox4.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold);
            this.textBox4.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.textBox4.HideSelection = false;
            this.textBox4.ImeMode = System.Windows.Forms.ImeMode.On;
            this.textBox4.Location = new System.Drawing.Point(3, 7);
            this.textBox4.Multiline = true;
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(254, 0);
            this.textBox4.TabIndex = 9;
            this.textBox4.Text = "E-mail";
            // 
            // textBox5
            // 
            this.textBox5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox5.BackColor = System.Drawing.SystemColors.Control;
            this.textBox5.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox5.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBox5.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold);
            this.textBox5.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.textBox5.HideSelection = false;
            this.textBox5.ImeMode = System.Windows.Forms.ImeMode.On;
            this.textBox5.Location = new System.Drawing.Point(5, 7);
            this.textBox5.Multiline = true;
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(369, 0);
            this.textBox5.TabIndex = 8;
            this.textBox5.Text = "E-mail";
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.SystemColors.Control;
            this.panel6.Controls.Add(this.mail_regist);
            this.panel6.Controls.Add(this.textBox2);
            this.panel6.Location = new System.Drawing.Point(122, 64);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(317, 39);
            this.panel6.TabIndex = 25;
            // 
            // mail_regist
            // 
            this.mail_regist.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mail_regist.BackColor = System.Drawing.SystemColors.Control;
            this.mail_regist.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mail_regist.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.mail_regist.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold);
            this.mail_regist.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.mail_regist.HideSelection = false;
            this.mail_regist.ImeMode = System.Windows.Forms.ImeMode.On;
            this.mail_regist.Location = new System.Drawing.Point(2, 7);
            this.mail_regist.MaxLength = 70;
            this.mail_regist.Multiline = true;
            this.mail_regist.Name = "mail_regist";
            this.mail_regist.Size = new System.Drawing.Size(309, 25);
            this.mail_regist.TabIndex = 11;
            this.mail_regist.Text = "E-mail adresi";
            this.mail_regist.Click += new System.EventHandler(this.mail_regist_Click);
            this.mail_regist.Enter += new System.EventHandler(this.mail_regist_Enter);
            this.mail_regist.Leave += new System.EventHandler(this.mail_regist_Leave);
            // 
            // textBox2
            // 
            this.textBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox2.BackColor = System.Drawing.SystemColors.Control;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBox2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold);
            this.textBox2.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.textBox2.HideSelection = false;
            this.textBox2.ImeMode = System.Windows.Forms.ImeMode.On;
            this.textBox2.Location = new System.Drawing.Point(5, 7);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(425, 0);
            this.textBox2.TabIndex = 8;
            this.textBox2.Text = "E-mail";
            // 
            // login_panel
            // 
            this.login_panel.Controls.Add(this.label1);
            this.login_panel.Controls.Add(this.register);
            this.login_panel.Controls.Add(this.panel2);
            this.login_panel.Controls.Add(this.panel3);
            this.login_panel.Controls.Add(this.loggin);
            this.login_panel.Controls.Add(this.panel4);
            this.login_panel.Controls.Add(this.pictureBox2);
            this.login_panel.Controls.Add(this.panel5);
            this.login_panel.Controls.Add(this.pictureBox3);
            this.login_panel.Location = new System.Drawing.Point(275, 52);
            this.login_panel.Name = "login_panel";
            this.login_panel.Size = new System.Drawing.Size(527, 409);
            this.login_panel.TabIndex = 29;
            this.login_panel.Paint += new System.Windows.Forms.PaintEventHandler(this.panel11_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Schoolbook", 20.25F, System.Drawing.FontStyle.Italic);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(203, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 33);
            this.label1.TabIndex = 25;
            this.label1.Text = "Hoş Geldin";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(93, 120);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(45, 39);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(258, 6);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(27, 26);
            this.button2.TabIndex = 12;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.showpass_mousedown);
            this.button2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.showpass_mouseup);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(93, 198);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(45, 39);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 6;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(1, 268);
            this.pictureBox4.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(274, 196);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 26;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(29, -18);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(214, 200);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // login_screen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(802, 464);
            this.ControlBox = false;
            this.Controls.Add(this.login_panel);
            this.Controls.Add(this.register_panel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.exitbutton);
            this.Controls.Add(systraybutton);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "login_screen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Deal Login Screen";
            this.TransparencyKey = System.Drawing.Color.DimGray;
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form2_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form2_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form2_MouseUp);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.register_panel.ResumeLayout(false);
            this.panel10.ResumeLayout(false);
            this.panel10.PerformLayout();
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.login_panel.ResumeLayout(false);
            this.login_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Label copyright;
        private Button exitbutton;
        private PictureBox pictureBox2;
        private Panel panel3;
        private TextBox username;
        private Button button2;
        private PictureBox pictureBox3;
        private TextBox password;
        private Panel panel2;
        private Panel panel4;
        private Panel panel5;
        private TextBox textBox1;
        private Button loggin;
        private Button register;
        private PictureBox pictureBox4;
        private System.Windows.Forms.Timer timer1;
        private Panel register_panel;
        private Label label1;
        private Label label4;
        private Label label3;
        private Panel panel6;
        private TextBox textBox2;
        private Panel panel7;
        private TextBox name_regist;
        private TextBox textBox4;
        private TextBox textBox5;
        private TextBox mail_regist;
        private Panel panel8;
        private TextBox surname_regist;
        private TextBox textBox3;
        private TextBox textBox6;
        private TextBox textBox7;
        private Panel panel10;
        private TextBox passwordagain_regist;
        private TextBox textBox12;
        private TextBox textBox13;
        private TextBox textBox14;
        private Panel panel9;
        private TextBox password_regist;
        private TextBox textBox9;
        private TextBox textBox10;
        private Button Hesap_Olustur;
        private Panel login_panel;
        private Button Vazgec;
        private Label label2;
    }
}