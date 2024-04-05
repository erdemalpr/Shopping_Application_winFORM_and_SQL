using System.Windows.Forms;

namespace form_deneme
{
    partial class User_Interface
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(User_Interface));
            this.sidebarcontainer = new System.Windows.Forms.FlowLayoutPanel();
            this.Menu_Panel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.Menu_Label = new System.Windows.Forms.Label();
            this.sidebartimer = new System.Windows.Forms.Timer(this.components);
            this.exitbutton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button10 = new System.Windows.Forms.Button();
            this.ozellikler1 = new System.Windows.Forms.RichTextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button34 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.fiyat1 = new System.Windows.Forms.Label();
            this.baslik1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button11 = new System.Windows.Forms.Button();
            this.ozellikler2 = new System.Windows.Forms.RichTextBox();
            this.button7 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.fiyat2 = new System.Windows.Forms.Label();
            this.baslik2 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.button12 = new System.Windows.Forms.Button();
            this.ozellikler3 = new System.Windows.Forms.RichTextBox();
            this.button9 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.fiyat3 = new System.Windows.Forms.Label();
            this.baslik3 = new System.Windows.Forms.Label();
            this.search_textbox = new System.Windows.Forms.TextBox();
            this.ara_Button = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.ilanresim1 = new System.Windows.Forms.PictureBox();
            this.ilanresim2 = new System.Windows.Forms.PictureBox();
            this.ilanresim3 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menu_button = new System.Windows.Forms.Button();
            this.Profile_Button = new System.Windows.Forms.Button();
            this.Events_button = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.basket = new System.Windows.Forms.Button();
            this.setting_button = new System.Windows.Forms.Button();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.panel5 = new System.Windows.Forms.Panel();
            this.button14 = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            systraybutton = new System.Windows.Forms.Button();
            this.sidebarcontainer.SuspendLayout();
            this.Menu_Panel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ilanresim1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ilanresim2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ilanresim3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.panel5.SuspendLayout();
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
            systraybutton.Location = new System.Drawing.Point(1193, 3);
            systraybutton.Name = "systraybutton";
            systraybutton.Size = new System.Drawing.Size(40, 40);
            systraybutton.TabIndex = 3;
            systraybutton.Text = "-";
            systraybutton.UseVisualStyleBackColor = true;
            systraybutton.Click += new System.EventHandler(this.Systraybutton_Click);
            // 
            // sidebarcontainer
            // 
            this.sidebarcontainer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.sidebarcontainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.sidebarcontainer.Controls.Add(this.Menu_Panel);
            this.sidebarcontainer.Controls.Add(this.Profile_Button);
            this.sidebarcontainer.Controls.Add(this.Events_button);
            this.sidebarcontainer.Controls.Add(this.button1);
            this.sidebarcontainer.Controls.Add(this.basket);
            this.sidebarcontainer.Controls.Add(this.setting_button);
            this.sidebarcontainer.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.sidebarcontainer.ForeColor = System.Drawing.Color.White;
            this.sidebarcontainer.Location = new System.Drawing.Point(0, 62);
            this.sidebarcontainer.MaximumSize = new System.Drawing.Size(238, 720);
            this.sidebarcontainer.MinimumSize = new System.Drawing.Size(75, 660);
            this.sidebarcontainer.Name = "sidebarcontainer";
            this.sidebarcontainer.Size = new System.Drawing.Size(238, 660);
            this.sidebarcontainer.TabIndex = 0;
            this.sidebarcontainer.Paint += new System.Windows.Forms.PaintEventHandler(this.Sidebarcontainer_Paint);
            // 
            // Menu_Panel
            // 
            this.Menu_Panel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Menu_Panel.Controls.Add(this.label1);
            this.Menu_Panel.Controls.Add(this.menu_button);
            this.Menu_Panel.Controls.Add(this.Menu_Label);
            this.Menu_Panel.Location = new System.Drawing.Point(3, 3);
            this.Menu_Panel.Name = "Menu_Panel";
            this.Menu_Panel.Size = new System.Drawing.Size(235, 50);
            this.Menu_Panel.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(80, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Menü";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Menu_Label
            // 
            this.Menu_Label.AutoSize = true;
            this.Menu_Label.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15F);
            this.Menu_Label.Location = new System.Drawing.Point(3, 174);
            this.Menu_Label.Name = "Menu_Label";
            this.Menu_Label.Size = new System.Drawing.Size(63, 23);
            this.Menu_Label.TabIndex = 1;
            this.Menu_Label.Text = "Menü";
            // 
            // sidebartimer
            // 
            this.sidebartimer.Tick += new System.EventHandler(this.Sidebartimer_Tick);
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
            this.exitbutton.Location = new System.Drawing.Point(1239, 2);
            this.exitbutton.Name = "exitbutton";
            this.exitbutton.Size = new System.Drawing.Size(38, 41);
            this.exitbutton.TabIndex = 2;
            this.exitbutton.Text = "X";
            this.exitbutton.UseVisualStyleBackColor = true;
            this.exitbutton.Click += new System.EventHandler(this.Exitbutton_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(systraybutton);
            this.panel1.Controls.Add(this.exitbutton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1280, 67);
            this.panel1.TabIndex = 3;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Panel1_MouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Panel1_MouseUp);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Controls.Add(this.panel2);
            this.flowLayoutPanel1.Controls.Add(this.panel3);
            this.flowLayoutPanel1.Controls.Add(this.panel4);
            this.flowLayoutPanel1.Controls.Add(this.panel5);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(239, 108);
            this.flowLayoutPanel1.MaximumSize = new System.Drawing.Size(1205, 614);
            this.flowLayoutPanel1.MinimumSize = new System.Drawing.Size(1041, 614);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1041, 614);
            this.flowLayoutPanel1.TabIndex = 4;
            this.flowLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel1_Paint);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.button10);
            this.panel2.Controls.Add(this.ozellikler1);
            this.panel2.Controls.Add(this.button3);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.button34);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.ilanresim1);
            this.panel2.Controls.Add(this.fiyat1);
            this.panel2.Controls.Add(this.baslik1);
            this.panel2.Location = new System.Drawing.Point(13, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(317, 563);
            this.panel2.TabIndex = 0;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // button10
            // 
            this.button10.BackColor = System.Drawing.Color.Blue;
            this.button10.Font = new System.Drawing.Font("Arial Nova Cond", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button10.ForeColor = System.Drawing.Color.White;
            this.button10.Location = new System.Drawing.Point(69, 524);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(177, 39);
            this.button10.TabIndex = 23;
            this.button10.Text = "Satıcıya Git";
            this.button10.UseVisualStyleBackColor = false;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // ozellikler1
            // 
            this.ozellikler1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ozellikler1.Location = new System.Drawing.Point(48, 243);
            this.ozellikler1.Name = "ozellikler1";
            this.ozellikler1.Size = new System.Drawing.Size(215, 196);
            this.ozellikler1.TabIndex = 22;
            this.ozellikler1.Text = "";
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Blue;
            this.button3.Font = new System.Drawing.Font("Arial Nova Cond", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(169, 178);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(21, 19);
            this.button3.TabIndex = 21;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Blue;
            this.button2.Font = new System.Drawing.Font("Arial Nova Cond", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(106, 178);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(21, 19);
            this.button2.TabIndex = 20;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // button34
            // 
            this.button34.BackColor = System.Drawing.Color.Blue;
            this.button34.Font = new System.Drawing.Font("Arial Nova Cond", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button34.ForeColor = System.Drawing.Color.White;
            this.button34.Location = new System.Drawing.Point(69, 479);
            this.button34.Name = "button34";
            this.button34.Size = new System.Drawing.Size(177, 39);
            this.button34.TabIndex = 18;
            this.button34.Text = "Favorilere Ekle";
            this.button34.UseVisualStyleBackColor = false;
            this.button34.Click += new System.EventHandler(this.button34_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(151, 453);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "TL";
            // 
            // fiyat1
            // 
            this.fiyat1.AutoSize = true;
            this.fiyat1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.fiyat1.Location = new System.Drawing.Point(102, 453);
            this.fiyat1.Name = "fiyat1";
            this.fiyat1.Size = new System.Drawing.Size(43, 20);
            this.fiyat1.TabIndex = 2;
            this.fiyat1.Text = "Fiyat";
            // 
            // baslik1
            // 
            this.baslik1.AutoSize = true;
            this.baslik1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.baslik1.Location = new System.Drawing.Point(84, 215);
            this.baslik1.Name = "baslik1";
            this.baslik1.Size = new System.Drawing.Size(137, 25);
            this.baslik1.TabIndex = 1;
            this.baslik1.Text = "ILAN BAŞLIK";
            this.baslik1.Click += new System.EventHandler(this.baslik1_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.button11);
            this.panel3.Controls.Add(this.ozellikler2);
            this.panel3.Controls.Add(this.button7);
            this.panel3.Controls.Add(this.button5);
            this.panel3.Controls.Add(this.button4);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.ilanresim2);
            this.panel3.Controls.Add(this.fiyat2);
            this.panel3.Controls.Add(this.baslik2);
            this.panel3.Location = new System.Drawing.Point(336, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(296, 563);
            this.panel3.TabIndex = 1;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // button11
            // 
            this.button11.BackColor = System.Drawing.Color.Blue;
            this.button11.Font = new System.Drawing.Font("Arial Nova Cond", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button11.ForeColor = System.Drawing.Color.White;
            this.button11.Location = new System.Drawing.Point(59, 524);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(177, 39);
            this.button11.TabIndex = 24;
            this.button11.Text = "Satıcıya Git";
            this.button11.UseVisualStyleBackColor = false;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // ozellikler2
            // 
            this.ozellikler2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ozellikler2.Location = new System.Drawing.Point(39, 243);
            this.ozellikler2.Name = "ozellikler2";
            this.ozellikler2.Size = new System.Drawing.Size(215, 196);
            this.ozellikler2.TabIndex = 23;
            this.ozellikler2.Text = "";
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.Blue;
            this.button7.Font = new System.Drawing.Font("Arial Nova Cond", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button7.ForeColor = System.Drawing.Color.White;
            this.button7.Location = new System.Drawing.Point(171, 178);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(21, 19);
            this.button7.TabIndex = 22;
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Blue;
            this.button5.Font = new System.Drawing.Font("Arial Nova Cond", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button5.ForeColor = System.Drawing.Color.White;
            this.button5.Location = new System.Drawing.Point(100, 178);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(21, 19);
            this.button5.TabIndex = 21;
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click_1);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Blue;
            this.button4.Font = new System.Drawing.Font("Arial Nova Cond", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(59, 479);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(177, 39);
            this.button4.TabIndex = 18;
            this.button4.Text = "Favorilere Ekle";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(154, 453);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "TL";
            // 
            // fiyat2
            // 
            this.fiyat2.AutoSize = true;
            this.fiyat2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.fiyat2.Location = new System.Drawing.Point(105, 453);
            this.fiyat2.Name = "fiyat2";
            this.fiyat2.Size = new System.Drawing.Size(43, 20);
            this.fiyat2.TabIndex = 2;
            this.fiyat2.Text = "Fiyat";
            // 
            // baslik2
            // 
            this.baslik2.AutoSize = true;
            this.baslik2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.baslik2.Location = new System.Drawing.Point(74, 215);
            this.baslik2.Name = "baslik2";
            this.baslik2.Size = new System.Drawing.Size(137, 25);
            this.baslik2.TabIndex = 1;
            this.baslik2.Text = "ILAN BAŞLIK";
            this.baslik2.Click += new System.EventHandler(this.baslik2_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Controls.Add(this.button12);
            this.panel4.Controls.Add(this.ozellikler3);
            this.panel4.Controls.Add(this.button9);
            this.panel4.Controls.Add(this.button8);
            this.panel4.Controls.Add(this.button6);
            this.panel4.Controls.Add(this.label6);
            this.panel4.Controls.Add(this.ilanresim3);
            this.panel4.Controls.Add(this.fiyat3);
            this.panel4.Controls.Add(this.baslik3);
            this.panel4.Location = new System.Drawing.Point(638, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(296, 563);
            this.panel4.TabIndex = 2;
            this.panel4.Paint += new System.Windows.Forms.PaintEventHandler(this.panel4_Paint);
            // 
            // button12
            // 
            this.button12.BackColor = System.Drawing.Color.Blue;
            this.button12.Font = new System.Drawing.Font("Arial Nova Cond", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button12.ForeColor = System.Drawing.Color.White;
            this.button12.Location = new System.Drawing.Point(55, 524);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(177, 39);
            this.button12.TabIndex = 26;
            this.button12.Text = "Satıcıya Git";
            this.button12.UseVisualStyleBackColor = false;
            // 
            // ozellikler3
            // 
            this.ozellikler3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ozellikler3.Location = new System.Drawing.Point(45, 243);
            this.ozellikler3.Name = "ozellikler3";
            this.ozellikler3.Size = new System.Drawing.Size(215, 196);
            this.ozellikler3.TabIndex = 25;
            this.ozellikler3.Text = "";
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.Color.Blue;
            this.button9.Font = new System.Drawing.Font("Arial Nova Cond", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button9.ForeColor = System.Drawing.Color.White;
            this.button9.Location = new System.Drawing.Point(164, 178);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(21, 19);
            this.button9.TabIndex = 24;
            this.button9.UseVisualStyleBackColor = false;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.Blue;
            this.button8.Font = new System.Drawing.Font("Arial Nova Cond", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button8.ForeColor = System.Drawing.Color.White;
            this.button8.Location = new System.Drawing.Point(101, 178);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(21, 19);
            this.button8.TabIndex = 23;
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.Blue;
            this.button6.Font = new System.Drawing.Font("Arial Nova Cond", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button6.ForeColor = System.Drawing.Color.White;
            this.button6.Location = new System.Drawing.Point(55, 479);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(177, 39);
            this.button6.TabIndex = 18;
            this.button6.Text = "Favorilere Ekle";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(146, 453);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(27, 20);
            this.label6.TabIndex = 6;
            this.label6.Text = "TL";
            // 
            // fiyat3
            // 
            this.fiyat3.AutoSize = true;
            this.fiyat3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.fiyat3.Location = new System.Drawing.Point(97, 453);
            this.fiyat3.Name = "fiyat3";
            this.fiyat3.Size = new System.Drawing.Size(43, 20);
            this.fiyat3.TabIndex = 2;
            this.fiyat3.Text = "Fiyat";
            // 
            // baslik3
            // 
            this.baslik3.AutoSize = true;
            this.baslik3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.baslik3.Location = new System.Drawing.Point(84, 215);
            this.baslik3.Name = "baslik3";
            this.baslik3.Size = new System.Drawing.Size(137, 25);
            this.baslik3.TabIndex = 1;
            this.baslik3.Text = "ILAN BAŞLIK";
            // 
            // search_textbox
            // 
            this.search_textbox.Location = new System.Drawing.Point(536, 69);
            this.search_textbox.Name = "search_textbox";
            this.search_textbox.Size = new System.Drawing.Size(250, 39);
            this.search_textbox.TabIndex = 24;
            this.search_textbox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.search_textbox_MouseClick);
            // 
            // ara_Button
            // 
            this.ara_Button.Location = new System.Drawing.Point(778, 67);
            this.ara_Button.Name = "ara_Button";
            this.ara_Button.Size = new System.Drawing.Size(93, 43);
            this.ara_Button.TabIndex = 25;
            this.ara_Button.Text = "arama_button";
            this.ara_Button.UseVisualStyleBackColor = true;
            this.ara_Button.Click += new System.EventHandler(this.ara_Button_Click);
            // 
            // button13
            // 
            this.button13.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button13.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button13.FlatAppearance.BorderSize = 0;
            this.button13.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.button13.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.button13.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button13.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button13.ForeColor = System.Drawing.Color.White;
            this.button13.Image = ((System.Drawing.Image)(resources.GetObject("button13.Image")));
            this.button13.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button13.Location = new System.Drawing.Point(1073, 65);
            this.button13.Name = "button13";
            this.button13.Padding = new System.Windows.Forms.Padding(13, 1, 1, 1);
            this.button13.Size = new System.Drawing.Size(207, 40);
            this.button13.TabIndex = 5;
            this.button13.Tag = "Profile";
            this.button13.Text = "Profilim";
            this.button13.UseVisualStyleBackColor = false;
            this.button13.Click += new System.EventHandler(this.button13_Click);
            // 
            // ilanresim1
            // 
            this.ilanresim1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ilanresim1.Location = new System.Drawing.Point(21, 18);
            this.ilanresim1.Name = "ilanresim1";
            this.ilanresim1.Size = new System.Drawing.Size(266, 154);
            this.ilanresim1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ilanresim1.TabIndex = 5;
            this.ilanresim1.TabStop = false;
            this.ilanresim1.Click += new System.EventHandler(this.ilanresim1_Click);
            // 
            // ilanresim2
            // 
            this.ilanresim2.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ilanresim2.Location = new System.Drawing.Point(21, 18);
            this.ilanresim2.Name = "ilanresim2";
            this.ilanresim2.Size = new System.Drawing.Size(254, 154);
            this.ilanresim2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ilanresim2.TabIndex = 5;
            this.ilanresim2.TabStop = false;
            this.ilanresim2.Click += new System.EventHandler(this.ilanresim2_Click);
            // 
            // ilanresim3
            // 
            this.ilanresim3.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ilanresim3.Location = new System.Drawing.Point(21, 18);
            this.ilanresim3.Name = "ilanresim3";
            this.ilanresim3.Size = new System.Drawing.Size(254, 154);
            this.ilanresim3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ilanresim3.TabIndex = 5;
            this.ilanresim3.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(536, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(250, 61);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // menu_button
            // 
            this.menu_button.AutoEllipsis = true;
            this.menu_button.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("menu_button.BackgroundImage")));
            this.menu_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.menu_button.FlatAppearance.BorderSize = 0;
            this.menu_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.menu_button.Location = new System.Drawing.Point(17, 8);
            this.menu_button.Name = "menu_button";
            this.menu_button.Size = new System.Drawing.Size(32, 32);
            this.menu_button.TabIndex = 1;
            this.menu_button.UseVisualStyleBackColor = true;
            this.menu_button.Click += new System.EventHandler(this.Button1_Click);
            // 
            // Profile_Button
            // 
            this.Profile_Button.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Profile_Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Profile_Button.FlatAppearance.BorderSize = 0;
            this.Profile_Button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.Profile_Button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.Profile_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Profile_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.Profile_Button.ForeColor = System.Drawing.Color.White;
            this.Profile_Button.Image = ((System.Drawing.Image)(resources.GetObject("Profile_Button.Image")));
            this.Profile_Button.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Profile_Button.Location = new System.Drawing.Point(3, 59);
            this.Profile_Button.Name = "Profile_Button";
            this.Profile_Button.Padding = new System.Windows.Forms.Padding(13, 1, 1, 1);
            this.Profile_Button.Size = new System.Drawing.Size(235, 50);
            this.Profile_Button.TabIndex = 2;
            this.Profile_Button.Tag = "Profile";
            this.Profile_Button.Text = "Profilim";
            this.Profile_Button.UseVisualStyleBackColor = false;
            this.Profile_Button.Enter += new System.EventHandler(this.Profile_Button_Enter);
            this.Profile_Button.Leave += new System.EventHandler(this.Profile_Button_Leave);
            this.Profile_Button.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Profile_Button_MouseClick);
            // 
            // Events_button
            // 
            this.Events_button.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Events_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Events_button.FlatAppearance.BorderSize = 0;
            this.Events_button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.Events_button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.Events_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Events_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.Events_button.ForeColor = System.Drawing.Color.White;
            this.Events_button.Image = ((System.Drawing.Image)(resources.GetObject("Events_button.Image")));
            this.Events_button.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Events_button.Location = new System.Drawing.Point(3, 115);
            this.Events_button.Name = "Events_button";
            this.Events_button.Padding = new System.Windows.Forms.Padding(13, 1, 1, 1);
            this.Events_button.Size = new System.Drawing.Size(235, 50);
            this.Events_button.TabIndex = 3;
            this.Events_button.Tag = "Events";
            this.Events_button.Text = "    Etkinlikler";
            this.Events_button.UseVisualStyleBackColor = false;
            this.Events_button.Click += new System.EventHandler(this.Events_button_Click);
            this.Events_button.Enter += new System.EventHandler(this.Events_button_Enter);
            this.Events_button.Leave += new System.EventHandler(this.Events_button_Leave);
            // 
            // button1
            // 
            this.button1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(3, 171);
            this.button1.Name = "button1";
            this.button1.Padding = new System.Windows.Forms.Padding(13, 1, 1, 1);
            this.button1.Size = new System.Drawing.Size(235, 50);
            this.button1.TabIndex = 4;
            this.button1.Tag = "Events";
            this.button1.Text = "   İlan ekle";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Button1_Click_1);
            this.button1.Enter += new System.EventHandler(this.Button1_Enter);
            this.button1.Leave += new System.EventHandler(this.Button1_Leave);
            // 
            // basket
            // 
            this.basket.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.basket.Cursor = System.Windows.Forms.Cursors.Hand;
            this.basket.FlatAppearance.BorderSize = 0;
            this.basket.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.basket.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.basket.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.basket.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.basket.ForeColor = System.Drawing.Color.White;
            this.basket.Image = ((System.Drawing.Image)(resources.GetObject("basket.Image")));
            this.basket.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.basket.Location = new System.Drawing.Point(3, 227);
            this.basket.Name = "basket";
            this.basket.Padding = new System.Windows.Forms.Padding(13, 1, 1, 1);
            this.basket.Size = new System.Drawing.Size(235, 50);
            this.basket.TabIndex = 5;
            this.basket.Tag = "Events";
            this.basket.Text = "Favoriler";
            this.basket.UseVisualStyleBackColor = false;
            this.basket.Click += new System.EventHandler(this.basket_Click);
            this.basket.Enter += new System.EventHandler(this.Basket_Enter);
            this.basket.Leave += new System.EventHandler(this.Basket_Leave);
            // 
            // setting_button
            // 
            this.setting_button.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.setting_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.setting_button.FlatAppearance.BorderSize = 0;
            this.setting_button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.setting_button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.setting_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.setting_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.setting_button.ForeColor = System.Drawing.Color.White;
            this.setting_button.Image = ((System.Drawing.Image)(resources.GetObject("setting_button.Image")));
            this.setting_button.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.setting_button.Location = new System.Drawing.Point(3, 283);
            this.setting_button.Name = "setting_button";
            this.setting_button.Padding = new System.Windows.Forms.Padding(13, 1, 1, 1);
            this.setting_button.Size = new System.Drawing.Size(235, 50);
            this.setting_button.TabIndex = 6;
            this.setting_button.Tag = "Settings";
            this.setting_button.Text = " Ayarlar";
            this.setting_button.UseVisualStyleBackColor = false;
            this.setting_button.Enter += new System.EventHandler(this.Setting_button_Enter);
            this.setting_button.Leave += new System.EventHandler(this.Setting_button_Leave);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.button15);
            this.panel5.Controls.Add(this.button14);
            this.panel5.Location = new System.Drawing.Point(13, 572);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(943, 28);
            this.panel5.TabIndex = 3;
            // 
            // button14
            // 
            this.button14.BackColor = System.Drawing.Color.Blue;
            this.button14.Font = new System.Drawing.Font("Arial Nova Cond", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button14.ForeColor = System.Drawing.Color.White;
            this.button14.Location = new System.Drawing.Point(402, 6);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(21, 19);
            this.button14.TabIndex = 22;
            this.button14.UseVisualStyleBackColor = false;
            this.button14.Click += new System.EventHandler(this.button14_Click_1);
            // 
            // button15
            // 
            this.button15.BackColor = System.Drawing.Color.Blue;
            this.button15.Font = new System.Drawing.Font("Arial Nova Cond", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button15.ForeColor = System.Drawing.Color.White;
            this.button15.Location = new System.Drawing.Point(450, 6);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(21, 19);
            this.button15.TabIndex = 23;
            this.button15.UseVisualStyleBackColor = false;
            this.button15.Click += new System.EventHandler(this.button15_Click_1);
            // 
            // User_Interface
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.ara_Button);
            this.Controls.Add(this.search_textbox);
            this.Controls.Add(this.button13);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.sidebarcontainer);
            this.Font = new System.Drawing.Font("Segoe UI", 18F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "User_Interface";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Deal Interface";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.User_Interface_Load_1);
            this.sidebarcontainer.ResumeLayout(false);
            this.Menu_Panel.ResumeLayout(false);
            this.Menu_Panel.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ilanresim1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ilanresim2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ilanresim3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.panel5.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FlowLayoutPanel sidebarcontainer;
        private Button Profile_Button;
        private Panel Menu_Panel;
        private Label Menu_Label;
        private System.Windows.Forms.Timer sidebartimer;
      
        private Button menu_button;
        private Label label1;
        private Button Events_button;
        private Button exitbutton;
        private Button setting_button;
        private Panel panel1;
        private PictureBox pictureBox1;
        private BindingSource bindingSource1;
        private Button button1;
        private Button basket;
        private FlowLayoutPanel flowLayoutPanel1;
        private Panel panel2;
        private Label fiyat1;
        private Label baslik1;
        private PictureBox ilanresim1;
        private Button button34;
        private Label label2;
        private Panel panel3;
        private Button button4;
        private Label label3;
        private PictureBox ilanresim2;
        private Label fiyat2;
        private Label baslik2;
        private Panel panel4;
        private Button button6;
        private Label label6;
        private PictureBox ilanresim3;
        private Label fiyat3;
        private Label baslik3;
        private Button button2;
        private Button button3;
        private Button button7;
        private Button button5;
        private Button button9;
        private Button button8;
        private RichTextBox ozellikler1;
        private RichTextBox ozellikler2;
        private RichTextBox ozellikler3;
        private Button button10;
        private Button button11;
        private Button button12;
        private Button button13;
        private TextBox search_textbox;
        private Button ara_Button;
        private Panel panel5;
        private Button button15;
        private Button button14;
    }
}