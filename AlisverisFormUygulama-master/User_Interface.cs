using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using form_deneme;
using System.Threading;

namespace form_deneme
{
   
    
    public partial class User_Interface : Form
    {
        int buton_deger = 0;

        VeriTabani S1 = new VeriTabani();

        string kullanici_id;
        
        public User_Interface(string id_deger) //giriş yapan kişinin ID değeri
        {
            InitializeComponent();
            this.ControlBox = false;
            this.DoubleBuffered = true;
            panel1.BringToFront();
           
            
            kullanici_id = id_deger;
            string kullanici_isim = S1.ID_Isimalma(kullanici_id);
            button13.Text = kullanici_isim;


            S1.ilan_bilgileri(); //veri tabanı bilgileri bu kısımda çekiyor
            Thread.Sleep(100);   //çok küçük bekleme sağlat yoksa hata veriyor

            //urunbilgi listesinin [0].indeksi resim 1 uzantı [1].indeksi resim 2 uzantı
            //[2].indeksi başlık [3].indeksi genel_ozellikler [4].indeksi fiyat ve 0-4 5-9 10-14

            ilanresim1.ImageLocation = S1.urunbilgi_listesi[0].ToString();
            baslik1.Text = S1.urunbilgi_listesi[2].ToString();
            ozellikler1.Text = S1.urunbilgi_listesi[3].ToString();
            fiyat1.Text = S1.urunbilgi_listesi[4].ToString();
            

            ilanresim2.ImageLocation = S1.urunbilgi_listesi[5].ToString();
            baslik2.Text = S1.urunbilgi_listesi[7].ToString();
            ozellikler2.Text = S1.urunbilgi_listesi[8].ToString();
            fiyat2.Text = S1.urunbilgi_listesi[9].ToString();

            ilanresim3.ImageLocation = S1.urunbilgi_listesi[10].ToString();
            baslik3.Text = S1.urunbilgi_listesi[12].ToString();
            ozellikler3.Text = S1.urunbilgi_listesi[13].ToString();
            fiyat3.Text = S1.urunbilgi_listesi[14].ToString();
          
        }
        

        #region sidebar ayarları
        bool sidebar_acıcı = true;
        private void Sidebartimer_Tick(object sender, EventArgs e)
        {
            if (sidebar_acıcı)
            {
                sidebarcontainer.Width -= 75;
                if (sidebarcontainer.Width == sidebarcontainer.MinimumSize.Width)
                {
                    sidebar_acıcı = false;
                    sidebartimer.Stop();
        

                }
                flowLayoutPanel1.Location = new Point(75, 108);
                flowLayoutPanel1.Size = new Size(flowLayoutPanel1.MaximumSize.Width, flowLayoutPanel1.MaximumSize.Height);

            }
             else  
            {
                sidebarcontainer.Width += 75;
                if (sidebarcontainer.Width == sidebarcontainer.MaximumSize.Width)
                {
                    sidebar_acıcı = true;
                    sidebartimer.Stop();
                    
                }
                flowLayoutPanel1.Location = new Point(239, 108);
                flowLayoutPanel1.Size = new Size(flowLayoutPanel1.MinimumSize.Width, flowLayoutPanel1.MinimumSize.Height);
            }


        }

        private void Button1_Click(object sender, EventArgs e)
        {
            sidebartimer.Start();
        }
        #endregion
        #region slidemenü renk ayarları

        

        private void Profile_Button_Enter(object sender, EventArgs e)
        {
            Profile_Button.BackColor = Color.FromArgb(46, 51, 73);
        }

        private void Profile_Button_Leave(object sender, EventArgs e)
        {
            Profile_Button.BackColor = Color.FromArgb(26, 26, 26);
          
        }

        private void Events_button_Enter(object sender, EventArgs e)
        {
            Events_button.BackColor = Color.FromArgb(46, 51, 73);
        }

        private void Events_button_Leave(object sender, EventArgs e)
        {
            Events_button.BackColor = Color.FromArgb(26, 26, 26);
        }
        private void Setting_button_Enter(object sender, EventArgs e)
        {
            setting_button.BackColor = Color.FromArgb(46, 51, 73);
        }

        private void Setting_button_Leave(object sender, EventArgs e)
        {
            setting_button.BackColor = Color.FromArgb(26, 26, 26);
        }
        #endregion
        #region panel hareket ettirme

        int mouseX;
        int mouseY;
        bool mousedown;
       

        private void Panel1_MouseUp(object sender, MouseEventArgs e)
        {
            mousedown = false;

        }

        private void Panel1_MouseDown(object sender, MouseEventArgs e)
        {
            mousedown = true;
            mouseX = e.X;
            mouseY = e.Y;

        }

        private void Panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (mousedown == true)
            {
                this.SetDesktopLocation(MousePosition.X - mouseX, MousePosition.Y - mouseY);
            }
        }
        #endregion  
        private void Exitbutton_Click(object sender, EventArgs e)
        {
            ExitQuestion ext = new ExitQuestion();
            ext.ShowDialog();
        }
        private void Systraybutton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }


        
       

        private void Events_button_Click(object sender, EventArgs e)
        {
           Etkinlikler etknlk=new Etkinlikler();
            etknlk.ShowDialog();
            
        }

        private void Button1_Click_1(object sender, EventArgs e)
        {
            İlan_ekle iln_ekle=new İlan_ekle(kullanici_id); 
          
            iln_ekle.ShowDialog();
            

        }

       
     

        private void Main_Menu2_Load_1(object sender, EventArgs e)
        {
            this.AutoScroll=false;
            this.AutoSize=false;
        }


       
        private void Profile_Button_MouseClick(object sender, MouseEventArgs e)
        {
            string isim_soyisim = S1.ID_Isimalma(kullanici_id);
            ilanlarım iln=new ilanlarım(isim_soyisim);
            iln.BringToFront();
            iln.ShowDialog();
        }

        private void Button1_Enter(object sender, EventArgs e)
        {
            button1.BackColor = Color.FromArgb(46, 51, 73);
        }

        private void Button1_Leave(object sender, EventArgs e)
        {
            button1.BackColor = Color.FromArgb(26, 26, 26);
        }
        private void Basket_Enter(object sender, EventArgs e)
        {
            basket.BackColor = Color.FromArgb(46, 51, 73);
        }

        private void Basket_Leave(object sender, EventArgs e)
        {

            basket.BackColor = Color.FromArgb(26, 26, 26);
        }


        private void button3_Click(object sender, EventArgs e) //resim 1 2.versiyon
        {
            if (buton_deger == 0)
            {
                ilanresim1.ImageLocation = S1.urunbilgi_listesi[1].ToString();
            }
            else
            {
                ilanresim1.ImageLocation = S1.urunbilgi_listesi[16].ToString();
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            if (buton_deger == 0)
            {
                ilanresim1.ImageLocation = S1.urunbilgi_listesi[0].ToString();
            }
            else
            {
                ilanresim1.ImageLocation = S1.urunbilgi_listesi[15].ToString();
            }

        }

      

        private void button34_Click(object sender, EventArgs e)
        {

            string resim1_uzanti = S1.urunbilgi_listesi[0].ToString();
            string baslik = S1.urunbilgi_listesi[2].ToString();
            string ozellikler = S1.urunbilgi_listesi[3].ToString();
            string fiyat = S1.urunbilgi_listesi[4].ToString();
            string ad_soyad = S1.ID_Isimalma(kullanici_id);
            string deger=S1.favori_kayit(resim1_uzanti, baslik, ozellikler, fiyat, ad_soyad);
    
            if (deger != string.Empty)
            {
                MessageBox.Show("Ürün başarıyla favorilere eklenmiştir", "Tebrikler",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Veritabanında hata meydana gelmiştir.Lütfen daha sonra tekrar deneyiniz", "Üzgünüz", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void button4_Click(object sender, EventArgs e)
        {
            string resim1_uzanti = S1.urunbilgi_listesi[5].ToString();
            string baslik = S1.urunbilgi_listesi[7].ToString();
            string ozellikler = S1.urunbilgi_listesi[8].ToString();
            string fiyat = S1.urunbilgi_listesi[9].ToString();
            string ad_soyad = S1.ID_Isimalma(kullanici_id);
            string deger = S1.favori_kayit(resim1_uzanti, baslik, ozellikler, fiyat, ad_soyad);
            if (deger != string.Empty)
            {
                MessageBox.Show("Ürün başarıyla favorilere eklenmiştir", "Tebrikler", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Veritabanında hata meydana gelmiştir.Lütfen daha sonra tekrar deneyiniz", "Üzgünüz", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void button6_Click(object sender, EventArgs e)
        {
            string resim1_uzanti = S1.urunbilgi_listesi[10].ToString();
            string baslik = S1.urunbilgi_listesi[12].ToString();
            string ozellikler = S1.urunbilgi_listesi[13].ToString();
            string fiyat = S1.urunbilgi_listesi[14].ToString();
            string ad_soyad = S1.ID_Isimalma(kullanici_id);
            string deger = S1.favori_kayit(resim1_uzanti, baslik, ozellikler, fiyat, ad_soyad);
            if (deger != string.Empty)
            {
                MessageBox.Show("Ürün başarıyla favorilere eklenmiştir", "Tebrikler", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Veritabanında hata meydana gelmiştir.Lütfen daha sonra tekrar deneyiniz", "Üzgünüz", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            string deger=S1.saticipanel_bilgileri(baslik1.Text, ozellikler1.Text);
            if (deger != String.Empty)
            {
                string satici_isim = S1.panel_saticilist[0].ToString();
                string telefon = S1.panel_saticilist[1].ToString();
                SatıcıBilgiForm Sat1 = new SatıcıBilgiForm(satici_isim, telefon);
                Sat1.Show();
            }
            else
            {
                MessageBox.Show("hata");
            }

        }

        private void basket_Click(object sender, EventArgs e)
        {
            favoripanel F1 = new favoripanel(kullanici_id);
            F1.BringToFront();
            F1.Show();

        }
        private void button7_Click(object sender, EventArgs e)
        {
            if (buton_deger == 0)
            {
                ilanresim2.ImageLocation = S1.urunbilgi_listesi[6].ToString();
            }
            else
            {
                ilanresim2.ImageLocation = S1.urunbilgi_listesi[21].ToString();
            }
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            if (buton_deger == 0)
            {
                ilanresim2.ImageLocation = S1.urunbilgi_listesi[5].ToString();
            }
            else
            {
                ilanresim2.ImageLocation = S1.urunbilgi_listesi[20].ToString();
            }

        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (buton_deger == 0)
            {
                ilanresim3.ImageLocation = S1.urunbilgi_listesi[10].ToString();
            }
            else
            {
                ilanresim3.ImageLocation = S1.urunbilgi_listesi[25].ToString();
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (buton_deger == 0)
            {
                ilanresim3.ImageLocation = S1.urunbilgi_listesi[11].ToString();
            }
            else
            {
                ilanresim3.ImageLocation = S1.urunbilgi_listesi[26].ToString();
            }
        }

      

        private void button13_Click(object sender, EventArgs e)
        {
            ProfilForm prflfrm = new ProfilForm();
            prflfrm.Show();
        }

        private void ara_Button_Click(object sender, EventArgs e)
        {
            string aranacak_urun = search_textbox.Text;
            //MessageBox.Show(aranacak_urun);
            string deger=S1.sorgu_verileri(aranacak_urun);
            if (aranacak_urun == String.Empty)
            {
                panel2.Show();
                panel3.Show();
                panel4.Show();
            }
            else if (S1.aramasonuc_listesi.Count > 0)
            {
                panel3.Hide();
                panel4.Hide();
                panel2.Hide();

                /*
                ilanresim1.ImageLocation = S1.aramasonuc_listesi[0].ToString();
                baslik1.Text = S1.aramasonuc_listesi[2].ToString();
                ozellikler1.Text = S1.aramasonuc_listesi[3].ToString();
                fiyat1.Text = S1.aramasonuc_listesi[4].ToString();
                */
                UrunPanelForm U1 = new UrunPanelForm(S1.aramasonuc_listesi[0].ToString(), S1.aramasonuc_listesi[1].ToString(), S1.aramasonuc_listesi[2].ToString(), S1.aramasonuc_listesi[3].ToString(), S1.aramasonuc_listesi[4].ToString());
                U1.ShowDialog();
                        
               
            }
            else
            {
                MessageBox.Show("Girilen bilgiye göre ürün bulunamamaıştır.Lütfen daha sonra tekrar deneyiniz");
                search_textbox.Text = String.Empty;
                panel2.Show();
                panel3.Show();
                panel4.Show();
            }
            
            
            
        }

        private void search_textbox_MouseClick(object sender, MouseEventArgs e)
        {
            panel2.Show();
            panel3.Show();
            panel4.Show();
        }

        private void button14_Click_1(object sender, EventArgs e)
        {
            buton_deger = 0;

            ilanresim1.ImageLocation = S1.urunbilgi_listesi[0].ToString();
            baslik1.Text = S1.urunbilgi_listesi[2].ToString();
            ozellikler1.Text = S1.urunbilgi_listesi[3].ToString();
            fiyat1.Text = S1.urunbilgi_listesi[4].ToString();


            ilanresim2.ImageLocation = S1.urunbilgi_listesi[5].ToString();
            baslik2.Text = S1.urunbilgi_listesi[7].ToString();
            ozellikler2.Text = S1.urunbilgi_listesi[8].ToString();
            fiyat2.Text = S1.urunbilgi_listesi[9].ToString();

            ilanresim3.ImageLocation = S1.urunbilgi_listesi[10].ToString();
            baslik3.Text = S1.urunbilgi_listesi[12].ToString();
            ozellikler3.Text = S1.urunbilgi_listesi[13].ToString();
            fiyat3.Text = S1.urunbilgi_listesi[14].ToString();

        }

        private void button15_Click_1(object sender, EventArgs e)
        {
            buton_deger = 1;

            ilanresim1.ImageLocation = S1.urunbilgi_listesi[15].ToString();
            baslik1.Text = S1.urunbilgi_listesi[17].ToString();
            ozellikler1.Text = S1.urunbilgi_listesi[18].ToString();
            fiyat1.Text = S1.urunbilgi_listesi[19].ToString();


            ilanresim2.ImageLocation = S1.urunbilgi_listesi[20].ToString();
            baslik2.Text = S1.urunbilgi_listesi[22].ToString();
            ozellikler2.Text = S1.urunbilgi_listesi[23].ToString();
            fiyat2.Text = S1.urunbilgi_listesi[24].ToString();

            ilanresim3.ImageLocation = S1.urunbilgi_listesi[25].ToString();
            baslik3.Text = S1.urunbilgi_listesi[27].ToString();
            ozellikler3.Text = S1.urunbilgi_listesi[28].ToString();
            fiyat3.Text = S1.urunbilgi_listesi[29].ToString();

           

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ilanresim2_Click(object sender, EventArgs e)
        {

        }


        private void baslik1_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void User_Interface_Load_1(object sender, EventArgs e)
        {

        }
        private void Sidebarcontainer_Paint(object sender, PaintEventArgs e)
        {

        }

        private void User_Interface_Load(object sender, EventArgs e)
        {

        }

        private void Profile_Button_Click(object sender, EventArgs e)
        {


        }
        private void Shopping_Basket_Click(object sender, EventArgs e)
        {

        }

        private void ilanresim1_Click(object sender, EventArgs e)
        {

        }

        private void baslik2_Click(object sender, EventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {

        }

        private void button14_Click(object sender, EventArgs e)
        {



        }

        private void arama_Text_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void button15_Click(object sender, EventArgs e)
        {


        }
    }
}
