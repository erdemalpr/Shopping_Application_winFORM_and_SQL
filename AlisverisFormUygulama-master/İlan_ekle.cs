using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace form_deneme
{
    public partial class İlan_ekle : Form
    {
        string kullanici_id;
        VeriTabani S1 = new VeriTabani();
        login_screen L1 = new login_screen();
        

        public İlan_ekle(string ID) //Giriş yapan kişinin ID değeri
        {
            InitializeComponent();
            kullanici_id = ID;      
            
        }
        
        

        private void button2_Click(object sender, EventArgs e) //Ana resim
        {
            try
            {
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    resim1_ilan.Image = Image.FromFile(openFileDialog1.FileName);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Resim Yüklerken Bir Hata Meydana Geldi.Lütfen Tekrar Deneyiniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button3_Click(object sender, EventArgs e) //diğer resim
        {

            try
            {
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    resim2_ilan.Image = Image.FromFile(openFileDialog1.FileName);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Resim Yüklerken Bir Hata Meydana Geldi.Lütfen Tekrar Deneyiniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        int dogru = 0;
        private void button5_Click(object sender, EventArgs e) //İlan kayıt click
        {
            string kategori = kategori_ilan.Text;
            string baslik = baslik_ilan.Text;
            string fiyat = fiyat_ilan.Text;
            string genel_ozellikler = ozellik_ilan.Text;
            string telefon = telefon_box.Text;
            int fiyat_kontrol = S1.rakam_kontrol(fiyat);
            
            if (kategori == "" || baslik == "" || fiyat == "") //Girilmeyen bilgi varsa bu bloğa gircek
            {
                MessageBox.Show("Girilen bilgilerde eksiklik bulunmaktadır.Lütfen tekrar gözden geçiriniz", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (resim1_ilan.Image == null || resim2_ilan.Image == null) //2 resim de yüklenmemişse bu bloğa girecek
            {
                MessageBox.Show("Lütfen İki Resmi de Tam Yükleyiniz", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (baslik.Length < 3 || baslik.Length > 20) //başlık 3 karakterden küçük ya da 20 karakterden büyük olursa buraya gircek
            {
                MessageBox.Show("İlanın Başlığı 3 Karakterden Küçük Veya 20 Karakterdenden Büyük Olamaz.Lütfen Tekrardan Gözden Geçirin", "Dikkat", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (genel_ozellikler.Length < 10) //genel özellikler için en az 10 karakterden büyük olma şartı var olmazsa bu bloğa girecek
            {
                MessageBox.Show("İlanın genel özellikleri en az 10 karakter büyüklüğünde olmalıdır.Lütfen doldurmadan geçmeyiniz", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if(fiyat_kontrol == 1 )
            {
                MessageBox.Show("Lütfen geçerli bir fiyat giriniz.Girmiş olduğunuz fiyatta rakam dışında girdi bulunmaktadır.","Dikkat",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            else if (telefon.Length < 14)
            {
                MessageBox.Show("Lütfen geçerli bir telefon numarası giriniz.Girilen telefon numarasında rakam dışında girdi kullanılmıştır", "Dikkat");
            }
            else
            {

                this.Close();
                string kullanici_adsoyad = S1.ID_Isimalma(kullanici_id); //ID sahibi kişinin AD-SOYAD (GİRİŞ YAPAN KİŞİ)

                int deger = S1.Ilan_Kayit(kategori, resim1_ilan.ImageLocation, resim2_ilan.ImageLocation, baslik, fiyat, genel_ozellikler,kullanici_adsoyad,telefon);
                //deger ilan kayıttan gelecek değeri tutuyor 1 ise veri tabanına kayıt oldu 2 ise hata meydana gelmiştir
                if (deger == 1)
                {
                    
                    MessageBox.Show("Tebrikler!İlanınız Başarıyla Sisteme Yüklenmiştir.", "İşlem Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                                      
                }
                else
                {
                    MessageBox.Show("Veri tabanından kaynaklı hata meydana gelmiştir. Lütfen daha sonra tekrar deneyiniz","Üzgünüz",MessageBoxButtons.OK,MessageBoxIcon.Information);
                }
                dogru = 1;

                
                #region knk oku burayı
                /* 
                 knk burdan veriyi doğru  girince "dogru" değişkeni=0 olacak.Ve user_interface formu içine bu değeri gönderecek
                user_interface formu bu değeri alınca yeni panel oluşturacak.Get set ile denedim veriyi yollayamadım. yollayabilirsen 
                yapıp bana yolla.

                */
                #endregion

            }


        }
        
      

        private void button2_Click_1(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            resim1_ilan.ImageLocation = openFileDialog1.FileName;
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            resim2_ilan.ImageLocation = openFileDialog1.FileName;
        }

        private void exitbutton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void İlan_ekle_Load(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {
                    }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click_1(object sender, EventArgs e)
        {

        }

        private void fiyat_ilan_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
