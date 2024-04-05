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
    public partial class ilanlarım : Form
    {

        VeriTabani S1 = new VeriTabani();
        string isim_verisi;

        public ilanlarım(string isim_soyisim)
        {
            InitializeComponent();
            isim_verisi = isim_soyisim;
            string veri=S1.Ilan_SahibiSorgulama(isim_soyisim);
            
            try
            {
                if (S1.sahip_ilanlar.Count >0) //Eğer ilan sahibinin ilanı varsa
                {
                    pictureBox1.ImageLocation = S1.sahip_ilanlar[0].ToString();
                    baslik1.Text = S1.sahip_ilanlar[2].ToString();
                    richTextBox1.Text = S1.sahip_ilanlar[3].ToString();
                    fiyat.Text = S1.sahip_ilanlar[4].ToString();

                    urun_panel2.Hide(); //2.ürünün genel paneli
                    urun_panel3.Hide(); //3.ürünün genel paneli
                    alt_panel.Hide();   //diğer sayfa için 2 li butonun olduğu panel

                    if (S1.sahip_ilanlar.Count > 5 && S1.sahip_ilanlar.Count<=10) //ilancının ilan sayısı 2 ise
                    {
                        pictureBox2.ImageLocation = S1.sahip_ilanlar[5].ToString();
                        baslik2.Text = S1.sahip_ilanlar[7].ToString();
                        richTextBox2.Text = S1.sahip_ilanlar[8].ToString();
                        fiyat2.Text = S1.sahip_ilanlar[9].ToString();
                        urun_panel2.Show();

                    }
                    else if(S1.sahip_ilanlar.Count>10 && S1.sahip_ilanlar.Count <= 15) //ilancının ilan sayısı 3 ise
                    {
                        
                        pictureBox2.ImageLocation = S1.sahip_ilanlar[5].ToString();
                        baslik2.Text = S1.sahip_ilanlar[7].ToString();
                        richTextBox2.Text = S1.sahip_ilanlar[8].ToString();
                        fiyat2.Text = S1.sahip_ilanlar[9].ToString();

                        pictureBox3.ImageLocation = S1.sahip_ilanlar[10].ToString();
                        baslik3.Text = S1.sahip_ilanlar[12].ToString();
                        richTextBox3.Text = S1.sahip_ilanlar[13].ToString();
                        fiyat3.Text = S1.sahip_ilanlar[14].ToString();

                        urun_panel2.Show();
                        urun_panel3.Show();
                    }
                    else if(S1.sahip_ilanlar.Count > 15 ) //ilancının ilan sayısı 4 ise
                    {
                       
                        
                        pictureBox2.ImageLocation = S1.sahip_ilanlar[5].ToString();
                        baslik2.Text = S1.sahip_ilanlar[7].ToString();
                        richTextBox2.Text = S1.sahip_ilanlar[8].ToString();
                        fiyat2.Text = S1.sahip_ilanlar[9].ToString();

                        pictureBox3.ImageLocation = S1.sahip_ilanlar[10].ToString();
                        baslik3.Text = S1.sahip_ilanlar[12].ToString();
                        richTextBox3.Text = S1.sahip_ilanlar[13].ToString();
                        fiyat3.Text = S1.sahip_ilanlar[14].ToString();
                        urun_panel2.Show();
                        urun_panel3.Show();
                        
                        alt_panel.Show();

                        /*
                        pictureBox2.ImageLocation = S1.sahip_ilanlar[5].ToString();
                        baslik2.Text = S1.sahip_ilanlar[7].ToString();
                        richTextBox2.Text = S1.sahip_ilanlar[8].ToString();
                        fiyat2.Text = S1.sahip_ilanlar[9].ToString();

                        pictureBox3.ImageLocation = S1.sahip_ilanlar[10].ToString();
                        baslik3.Text = S1.sahip_ilanlar[12].ToString();
                        richTextBox3.Text = S1.sahip_ilanlar[13].ToString();
                        fiyat3.Text = S1.sahip_ilanlar[14].ToString();

                        urun_panel2.Show();
                        urun_panel3.Show();
                        alt_panel.Show();
                        //button 6 click ile panel bilgilerini değiştir
                        */


                    }
                    /*
                    else if(S1.sahip_ilanlar.Count > 20 )  //ilancının ilan sayısı 5 ve daha fazla ise
                    {
                        pictureBox2.ImageLocation = S1.sahip_ilanlar[5].ToString();
                        baslik2.Text = S1.sahip_ilanlar[7].ToString();
                        richTextBox2.Text = S1.sahip_ilanlar[8].ToString();
                        fiyat2.Text = S1.sahip_ilanlar[9].ToString();

                        pictureBox3.ImageLocation = S1.sahip_ilanlar[10].ToString();
                        baslik3.Text = S1.sahip_ilanlar[12].ToString();
                        richTextBox3.Text = S1.sahip_ilanlar[13].ToString();
                        fiyat3.Text = S1.sahip_ilanlar[14].ToString();
                        urun_panel2.Show();
                        urun_panel3.Show();
                        alt_panel.Show();

                        
                        pictureBox2.ImageLocation = S1.sahip_ilanlar[5].ToString();
                        baslik2.Text = S1.sahip_ilanlar[7].ToString();
                        richTextBox2.Text = S1.sahip_ilanlar[8].ToString();
                        fiyat2.Text = S1.sahip_ilanlar[9].ToString();

                        pictureBox3.ImageLocation = S1.sahip_ilanlar[10].ToString();
                        baslik3.Text = S1.sahip_ilanlar[12].ToString();
                        richTextBox3.Text = S1.sahip_ilanlar[13].ToString();
                        fiyat3.Text = S1.sahip_ilanlar[14].ToString();

                        urun_panel2.Show();
                        urun_panel3.Show();
                        alt_panel.Show();                      
                    }*/
                    
                }
                else
                {
                    alt_panel.Hide();
                    urun_panel1.Hide();
                    urun_panel2.Hide();
                    urun_panel3.Hide();
                }
                             
            }
            catch (Exception)
            {
                MessageBox.Show("Veri tabanımızdan kaynaklı hata meydana geldi.Lütfen daha sonra tekrar deneyiniz", "Üzgünüz", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
        }
        private void button5_Click(object sender, EventArgs e) //tekrar aynı sayfaya geçiren buton
        {


            pictureBox1.ImageLocation = S1.sahip_ilanlar[0].ToString(); // ilk ilan panelinin verileri 0 2 3 4 
            baslik1.Text = S1.sahip_ilanlar[2].ToString();
            richTextBox1.Text = S1.sahip_ilanlar[3].ToString();
            fiyat.Text = S1.sahip_ilanlar[4].ToString();

            pictureBox2.ImageLocation = S1.sahip_ilanlar[5].ToString(); //ikinci ilan panelinin verileri 5 7 8 9
            baslik2.Text = S1.sahip_ilanlar[7].ToString();
            richTextBox2.Text = S1.sahip_ilanlar[8].ToString();
            fiyat2.Text = S1.sahip_ilanlar[9].ToString();
            urun_panel2.Show();


            pictureBox3.ImageLocation = S1.sahip_ilanlar[10].ToString(); //üçüncü ilan panelinin verileri 10 11 12 13
            baslik3.Text = S1.sahip_ilanlar[12].ToString();
            richTextBox3.Text = S1.sahip_ilanlar[13].ToString();
            fiyat3.Text = S1.sahip_ilanlar[14].ToString();
            urun_panel3.Show();
        }
        private void button6_Click(object sender, EventArgs e) //diğer sayfaya geçiren buton
        {
            /*
            pictureBox1.ImageLocation = S1.sahip_ilanlar[15].ToString();  //4.üncü ilan panelinin verileri 15 17 18 19
            baslik1.Text = S1.sahip_ilanlar[17].ToString();
            richTextBox1.Text = S1.sahip_ilanlar[18].ToString();
            fiyat.Text = S1.sahip_ilanlar[19].ToString();
            */
           
            try
            {
                urun_panel1.Hide();
                urun_panel2.Hide();
                urun_panel3.Hide();

                if (S1.sahip_ilanlar.Count > 15 && S1.sahip_ilanlar.Count <= 20)  //ilancının ilan sayısı 4 ise
                {
                    pictureBox1.ImageLocation = S1.sahip_ilanlar[15].ToString();
                    baslik1.Text = S1.sahip_ilanlar[17].ToString();
                    richTextBox1.Text = S1.sahip_ilanlar[18].ToString();
                    fiyat.Text = S1.sahip_ilanlar[19].ToString();

                    urun_panel1.Show();
                    urun_panel2.Hide();
                    urun_panel3.Hide();
                    alt_panel.Show();
                   
                }

                else if (S1.sahip_ilanlar.Count > 20 && S1.sahip_ilanlar.Count <= 25) //5.ilan panelinin verileri 20 22 23 24
                {
                    pictureBox1.ImageLocation = S1.sahip_ilanlar[15].ToString();
                    baslik1.Text = S1.sahip_ilanlar[17].ToString();
                    richTextBox1.Text = S1.sahip_ilanlar[18].ToString();
                    fiyat.Text = S1.sahip_ilanlar[19].ToString();

                    pictureBox2.ImageLocation = S1.sahip_ilanlar[20].ToString();
                    baslik2.Text = S1.sahip_ilanlar[22].ToString();
                    richTextBox2.Text = S1.sahip_ilanlar[23].ToString();
                    fiyat2.Text = S1.sahip_ilanlar[24].ToString();

                    urun_panel1.Show();
                    urun_panel2.Show();
                    
                }
                else if (S1.sahip_ilanlar.Count > 25 && S1.sahip_ilanlar.Count <= 30) //6.ilanın panel verileri
                {
                    pictureBox1.ImageLocation = S1.sahip_ilanlar[15].ToString();
                    baslik1.Text = S1.sahip_ilanlar[17].ToString();
                    richTextBox1.Text = S1.sahip_ilanlar[18].ToString();
                    fiyat.Text = S1.sahip_ilanlar[19].ToString();

                    pictureBox2.ImageLocation = S1.sahip_ilanlar[20].ToString();
                    baslik2.Text = S1.sahip_ilanlar[22].ToString();
                    richTextBox2.Text = S1.sahip_ilanlar[23].ToString();
                    fiyat2.Text = S1.sahip_ilanlar[24].ToString();

                    pictureBox3.ImageLocation = S1.sahip_ilanlar[25].ToString();
                    baslik3.Text = S1.sahip_ilanlar[27].ToString();
                    richTextBox3.Text = S1.sahip_ilanlar[28].ToString();
                    fiyat3.Text = S1.sahip_ilanlar[29].ToString();

                    urun_panel1.Show();
                    urun_panel2.Show();
                    urun_panel3.Show();

                    
                }
                else if (S1.sahip_ilanlar.Count > 30)
                {
                    //MessageBox.Show("Sayın kullanıcı,6 ürnünüzden en az 1'ini satmadığınız sürece diğer ürünlerinize erişemezsiniz", "Üzgünüz", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    pictureBox1.ImageLocation = S1.sahip_ilanlar[15].ToString();
                    baslik1.Text = S1.sahip_ilanlar[17].ToString();
                    richTextBox1.Text = S1.sahip_ilanlar[18].ToString();
                    fiyat.Text = S1.sahip_ilanlar[19].ToString();

                    pictureBox2.ImageLocation = S1.sahip_ilanlar[20].ToString();
                    baslik2.Text = S1.sahip_ilanlar[22].ToString();
                    richTextBox2.Text = S1.sahip_ilanlar[23].ToString();
                    fiyat2.Text = S1.sahip_ilanlar[24].ToString();

                    pictureBox3.ImageLocation = S1.sahip_ilanlar[25].ToString();
                    baslik3.Text = S1.sahip_ilanlar[27].ToString();
                    richTextBox3.Text = S1.sahip_ilanlar[28].ToString();
                    fiyat3.Text = S1.sahip_ilanlar[29].ToString();

                    urun_panel1.Show();
                    urun_panel2.Show();
                    urun_panel3.Show();
                    
                }
                else
                {
                    MessageBox.Show("Veri tabanımızdan kaynaklı hata meydana geldi.Lütfen daha sonra tekrar deneyiniz", "Üzgünüz", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Veri tabanımızdan kaynaklı hata meydana geldi.Lütfen daha sonra tekrar deneyiniz", "Üzgünüz", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
            }
         
           
            
        }

        private void richTextBox3_TextChanged(object sender, EventArgs e)
        {

        }
        private void Profilim_Load(object sender, EventArgs e)
        {
            
        }

        private void exitbutton_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void urun_panel3_Paint(object sender, PaintEventArgs e)
        {

        }


        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            İlan_ekle I1 = new İlan_ekle(isim_verisi);
            I1.Show();
            I1.Controls["baslik_ilan"].Text = S1.sahip_ilanlar[2].ToString();
            I1.Controls["ozellik_ilan"].Text = S1.sahip_ilanlar[3].ToString();
            I1.Controls["fiyat_ilan"].Text = S1.sahip_ilanlar[4].ToString();
            string deger=S1.ilan_silme(S1.sahip_ilanlar[2].ToString(),isim_verisi);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            İlan_ekle I1 = new İlan_ekle(isim_verisi);
            I1.Show();
            I1.Controls["baslik_ilan"].Text = S1.sahip_ilanlar[7].ToString();
            I1.Controls["ozellik_ilan"].Text = S1.sahip_ilanlar[8].ToString();
            I1.Controls["fiyat_ilan"].Text = S1.sahip_ilanlar[9].ToString();
            string deger = S1.ilan_silme(S1.sahip_ilanlar[7].ToString(), isim_verisi);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            İlan_ekle I1 = new İlan_ekle(isim_verisi);
            I1.Show();
            I1.Controls["baslik_ilan"].Text = S1.sahip_ilanlar[12].ToString();
            I1.Controls["ozellik_ilan"].Text = S1.sahip_ilanlar[13].ToString();
            I1.Controls["fiyat_ilan"].Text = S1.sahip_ilanlar[14].ToString();
            string deger = S1.ilan_silme(S1.sahip_ilanlar[7].ToString(), isim_verisi);
        }

        private void alt_panel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            string veri=S1.ilan_silme(S1.sahip_ilanlar[2].ToString(),isim_verisi); 
            if (veri != String.Empty)
            {
                MessageBox.Show("İlanınız başarıyla sistemimizden kaldırılmıştır","Tebrikler",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Veri tabanından kaynaklı problem yaşandı. Lütfen daha sonra silmeyi tekrar deneyiniz", "Üzgünüz", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            this.Hide();

        }

        private void button8_Click(object sender, EventArgs e)
        {
            string veri=S1.ilan_silme(S1.sahip_ilanlar[7].ToString(), isim_verisi);
            if (veri != String.Empty)
            {
                MessageBox.Show("İlanınız başarıyla sistemimizden kaldırılmıştır", "Tebrikler", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Veri tabanından kaynaklı problem yaşandı. Lütfen daha sonra silmeyi tekrar deneyiniz", "Üzgünüz", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            this.Hide();

        }

        private void button9_Click(object sender, EventArgs e)
        {
            string veri=S1.ilan_silme(S1.sahip_ilanlar[12].ToString(), isim_verisi);
            if (veri != String.Empty)
            {
                MessageBox.Show("İlanınız başarıyla sistemimizden kaldırılmıştır", "Tebrikler", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Veri tabanından kaynaklı problem yaşandı. Lütfen daha sonra silmeyi tekrar deneyiniz", "Üzgünüz", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            this.Hide();
        }
    }
}
