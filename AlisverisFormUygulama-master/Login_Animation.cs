using System;
using System.Windows.Forms;

namespace form_deneme
{
    public partial class Login_Animation : Form     //Giriþ kaybolan logo kodlarý
    {
        public Login_Animation()
        {
            InitializeComponent();
        }
        bool islem = false;
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (islem==false)
            {
                this.Opacity += 0.005;

            }
            if (this.Opacity==1.0)
            {
                islem = true;
            }
            if (islem == true)
            {
                
                this.Opacity -= 0.009;
                if (this.Opacity==0)
                {
                    login_screen lgnd=new login_screen();
                    lgnd.Show();
                    timer1.Enabled = false;
                    
                }
                this.Hide();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}