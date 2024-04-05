using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace form_deneme

{
    public partial class login_screen : Form
    {
       

        VeriTabani S1 = new VeriTabani();

        public login_screen()
        {
            InitializeComponent();
            login_panel.BringToFront();
        }

       

        private void button1_Click(object sender, EventArgs e)
        {

            Application.Exit(); // exit buton kodu
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }



        #region sürüklemekodlari
        bool move;
        int mouseX;
        int mouseY;


        private void Form2_MouseDown(object sender, MouseEventArgs e)
        {
            move = true;
            mouseX = e.X;
            mouseY = e.Y;
        }

        private void Form2_MouseMove(object sender, MouseEventArgs e)
        {
            if (move == true)
            {
                this.SetDesktopLocation(MousePosition.X - mouseX, MousePosition.Y - mouseY);
            }
        }

        private void Form2_MouseUp(object sender, MouseEventArgs e)
        {
            move = false;

        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            move = false;
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            move = true;
            mouseX = e.X;
            mouseY = e.Y;
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (move == true)
            {
                this.SetDesktopLocation(MousePosition.X - mouseX, MousePosition.Y - mouseY);
            }
        }
        #endregion

        

        private void showpass_mouseup(object sender, MouseEventArgs e)
        {
            password.UseSystemPasswordChar = false;
        }

        private void showpass_mousedown(object sender, MouseEventArgs e)
        {
            password.UseSystemPasswordChar = true;
        }

        

        private void username_Click(object sender, EventArgs e)
        {
            // tıklayınca e-mail boxu belirgin yapma

            username.BackColor = Color.White;
            panel4.BackColor = Color.White;
            panel5.BackColor = SystemColors.Control;
            password.BackColor = SystemColors.Control;


        }

        private void password_Click(object sender, EventArgs e)
        {
            // tıklayınca şifre boxu belirgin yapma

            password.BackColor = Color.White;
            panel5.BackColor = Color.White;
            username.BackColor = SystemColors.Control;
            panel4.BackColor = SystemColors.Control;
        }

        private void password_TextChanged_1(object sender, EventArgs e)
        {

        }

        
        #region giriş ekranı görsel düzeltmeleri

        private void username_Enter(object sender, EventArgs e)
        {
            if (username.Text == "E-mail")
            {
                username.Text = "";
                username.ForeColor = SystemColors.WindowText;
            }
        }

        private void username_Leave(object sender, EventArgs e)
        {
            if (username.Text == "")
            {
                username.Text = "E-mail";
                username.ForeColor = SystemColors.WindowFrame;

            }

        }

        private void password_Enter(object sender, EventArgs e)
        {
            if (password.Text == "Parola")
            {
                password.Text = "";
                password.ForeColor = SystemColors.WindowText;
                password.UseSystemPasswordChar = false;
            }
        }

        private void password_Leave(object sender, EventArgs e)
        {
            if (password.Text == "")
            {

                password.Text = "Parola";
                password.ForeColor = SystemColors.WindowFrame;
                password.UseSystemPasswordChar = true;
            }
        }
        #endregion
        private void loggin_Click(object sender, EventArgs e)
        {
            string kullanici_adi = username.Text;
            string sifre = password.Text;
            string giris_deger = S1.Kullanici_Sorgulama(kullanici_adi, kullanici_adi, sifre); //SQL de bir kullanıcı ile eşleşirse kullanicinin ID degerini gönderecek. 
                                                                                              //Eşleşmezse string.empty gönderilecek
            if (kullanici_adi == "E-mail" || sifre == "Parola")
            {
                MessageBox.Show("İçeriği girilmemiş boş alan bulunmaktadır.Lütfen alanları eksiksiz bir biçimde doldurunuz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (giris_deger != String.Empty)
                {
                                
                    User_Interface U1 = new User_Interface(giris_deger); //giriş değer=giriş yapan kişinin ID değeri
                    U1.ShowDialog();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Girilen bilgilere ait bir kullanıcı bulunamamıştır.Lütfen girdiğiniz bilgileri tekrardan gözden geçiriniz", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

        }

        private void loggin_BackColorChanged(object sender, EventArgs e)
        {
            loggin.BackColor = Color.FromArgb(31, 32, 71);
        }

        
        private void panel6_Paint(object sender, PaintEventArgs e)
        {
            Opacity = 0;
        }

       

        
        private void register_Click_1(object sender, EventArgs e)
        {

            register_panel.Visible = true;
            register_panel.BringToFront();
            
        }

        

        
        private void Vazgeç_Click(object sender, EventArgs e)
        {
            register_panel.Visible=false;
            register_panel.SendToBack();
            
            
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void register_panel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel11_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Vazgec_Click(object sender, EventArgs e)
        {
            register_panel.Visible=false ;
            login_panel.Visible=true ;
            login_panel.BringToFront() ;
        }

        private void name_regist_TextChanged(object sender, EventArgs e)
        {
           
        }
        //************************************KAYIT EKRANI GÖRSEL DÜZELTMELERİ**********************************
        #region kayitformu görsel düzeltmeleri
        private void name_regist_Click(object sender, EventArgs e)
        {
            name_regist.BackColor = Color.White;
            panel7.BackColor = Color.White;
            

        }

        private void name_regist_Enter(object sender, EventArgs e)
        {
            if (name_regist.Text=="Ad")
            {
                name_regist.Text = "";
                name_regist.ForeColor = SystemColors.ControlText;
            }

        }

        private void name_regist_Leave(object sender, EventArgs e)
        {
            if (name_regist.Text=="")
            {
                name_regist.Text = "Ad";
                name_regist.ForeColor= SystemColors.WindowFrame;
               
                
            }
            name_regist.BackColor= SystemColors.Control;
            panel7.BackColor= SystemColors.Control;
          
        }

        private void surname_regist_Click(object sender, EventArgs e)
        {
            surname_regist.BackColor = Color.White;
            panel8.BackColor=Color.White;
          
            
        }

        private void surname_regist_Enter(object sender, EventArgs e)
        {
            if (surname_regist.Text=="Soyad")
            {
                surname_regist.Text = "";
                surname_regist.ForeColor=SystemColors.ControlText;
            }
        }

        private void surname_regist_Leave(object sender, EventArgs e)
        {
            if (surname_regist.Text=="")
            {
                surname_regist.Text = "Soyad";
                surname_regist.ForeColor=SystemColors.WindowFrame;
                
            }
            surname_regist.BackColor = SystemColors.Control;
            panel8.BackColor= SystemColors.Control;
        }

        private void mail_regist_Click(object sender, EventArgs e)
        {
            mail_regist.BackColor = Color.White;
            panel6.BackColor = Color.White;
            mail_regist.ForeColor = SystemColors.ControlText;
        }

        private void mail_regist_Enter(object sender, EventArgs e)
        {
            if (mail_regist.Text=="E-mail adresi")
            {
                mail_regist.Text = "";
                mail_regist.ForeColor=SystemColors.ControlText;
            }

        }

        private void mail_regist_Leave(object sender, EventArgs e)
        {
            if (mail_regist.Text=="")
            {
                mail_regist.Text = "E-mail adresi";
                mail_regist.ForeColor = SystemColors.WindowFrame;
            }
            mail_regist.BackColor = SystemColors.Control;
            panel6.BackColor = SystemColors.Control;
            
        }

        private void password_regist_Click(object sender, EventArgs e)
        {
            password_regist.BackColor = Color.White;
            panel9.BackColor = Color.White;
            password_regist.ForeColor = SystemColors.ControlText;

        }

        private void password_regist_Enter(object sender, EventArgs e)
        {
            if (password_regist.Text == "Şifre")
            {
                password_regist.Text = "";
                password_regist.ForeColor = SystemColors.ControlText;
            }

        }

        private void password_regist_Leave(object sender, EventArgs e)
        {
            if (password_regist.Text == "")
            {
                password_regist.Text = "Şifre";
                password_regist.ForeColor = SystemColors.WindowFrame;
            }
            password_regist.BackColor = SystemColors.Control;
            panel9.BackColor = SystemColors.Control;

        }

        private void passwordagain_regist_Click(object sender, EventArgs e)
        {
            passwordagain_regist.BackColor = Color.White;
            panel10.BackColor = Color.White;
            passwordagain_regist.ForeColor = SystemColors.ControlText;
        }

        private void passwordagain_regist_Enter(object sender, EventArgs e)
        {
            if (passwordagain_regist.Text == "Şifre tekrar")
            {
                passwordagain_regist.Text = "";
                passwordagain_regist.ForeColor = SystemColors.ControlText;
            }

        }

        private void passwordagain_regist_Leave(object sender, EventArgs e)
        {
            if (passwordagain_regist.Text == "")
            {
                passwordagain_regist.Text = "Şifre tekrar";
                passwordagain_regist.ForeColor = SystemColors.WindowFrame;
            }
            passwordagain_regist.BackColor = SystemColors.Control;
            panel10.BackColor = SystemColors.Control;

        }

        private void Hesap_Olustur_Click(object sender, EventArgs e)
        {
            string isim = name_regist.Text;
            string soyisim = surname_regist.Text;
            string e_mail = mail_regist.Text;
            string sifre = password_regist.Text;
            string sifre_tekrar = passwordagain_regist.Text;

            int deger = S1.Eposta_kontrol(e_mail);        //E Postada @ ve .com uzantılarının olup olmadığı kontrolü
            int deger2 = S1.Sifre_kontrol(sifre);         //Sifrede karakter ve int kontrolü
            int deger3 = S1.Eposta_sorgulama(e_mail);     //Sistemde kayıtlı E-Posta var mı?
            if (isim == "Ad" || soyisim == "Soyad" || e_mail == "E-mail adresi" || sifre == "Şifre" || sifre_tekrar == "Şifre tekrar")
            {
                MessageBox.Show("İçeriği girilmemiş boş alan bulunmaktadır.Lütfen alanları eksiksiz bir biçimde doldurunuz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (deger == 0)
                {
                    MessageBox.Show("E Posta Adresi Uygun Şartları Sağlamamaktadır. Lütfen Tekrar Gözden Geçiriniz", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (sifre != sifre_tekrar)
                {
                    MessageBox.Show("Girilen şifreler birbirleriyle uyuşmamaktadır.Lütfen girdiğiniz şifreleri tekrar kontrol ediniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (deger2 == 0 || sifre.Length < 8)
                {
                    MessageBox.Show("Sifreniz Yeterli Şartları Sağlamamaktadır. Lütfen En Az 8 Uzunlukta En Az 1 Rakam ve En Az 1 Karakter Kullanmalısınız", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (deger3 == 1)
                {
                    MessageBox.Show("E Posta Sistemde Kayıtlıdır. Lütfen Farklı Bir E Posta Giriniz", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (isim.Length < 2)
                {
                    MessageBox.Show("Isminiz 1 Karakterden Büyük Olmalıdır", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (soyisim.Length < 2)
                {
                    MessageBox.Show("Soyisiminz 1 Karakterden Büyük OLmalıdır", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    int veritabanideger = S1.veri_kayit(isim, soyisim, e_mail, sifre); //Veri tabanı kayıt işlemleri
                    if (veritabanideger == 1)
                    {
                        MessageBox.Show("Tebrikler!Sistemimize Başarıyla Kayıt Oldunuz", "Tebrikler", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Veri Tabanımızda Bir Hata Meydana Gelmiştir.Lütfen Daha Sonra Tekrar Deneyiniz", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }

        }
    }
    #endregion
}
