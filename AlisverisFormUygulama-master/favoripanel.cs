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
    public partial class favoripanel : Form
    {
        VeriTabani S1 = new VeriTabani();
        string isim_soyisim;
        public favoripanel(string id)
        {
            InitializeComponent();
            isim_soyisim = S1.ID_Isimalma(id);
            string veri = S1.favori_verileri(isim_soyisim);
            urun_panel1.Hide();
            urun_panel2.Hide();
            urun_panel3.Hide();
            alt_panel.Hide();
            try
            {

                if (S1.favori_listesi.Count > 0)
                {
                    pictureBox1.ImageLocation = S1.favori_listesi[0].ToString();
                    baslik1.Text = S1.favori_listesi[1].ToString();
                    richTextBox1.Text = S1.favori_listesi[2].ToString();
                    fiyat.Text = S1.favori_listesi[3].ToString();

                    urun_panel1.Show();

                    if (S1.favori_listesi.Count > 4 && S1.favori_listesi.Count <= 8)
                    {
                        pictureBox1.ImageLocation = S1.favori_listesi[0].ToString();
                        baslik1.Text = S1.favori_listesi[1].ToString();
                        richTextBox1.Text = S1.favori_listesi[2].ToString();
                        fiyat.Text = S1.favori_listesi[3].ToString();

                        pictureBox2.ImageLocation = S1.favori_listesi[4].ToString();
                        baslik2.Text = S1.favori_listesi[5].ToString();
                        richTextBox2.Text = S1.favori_listesi[6].ToString();
                        fiyat2.Text = S1.favori_listesi[7].ToString();

                        urun_panel1.Show();
                        urun_panel2.Show();
                    }
                    else if (S1.favori_listesi.Count > 8 && S1.favori_listesi.Count <= 12)
                    {
                        pictureBox1.ImageLocation = S1.favori_listesi[0].ToString();
                        baslik1.Text = S1.favori_listesi[1].ToString();
                        richTextBox1.Text = S1.favori_listesi[2].ToString();
                        fiyat.Text = S1.favori_listesi[3].ToString();

                        pictureBox2.ImageLocation = S1.favori_listesi[4].ToString();
                        baslik2.Text = S1.favori_listesi[5].ToString();
                        richTextBox2.Text = S1.favori_listesi[6].ToString();
                        fiyat2.Text = S1.favori_listesi[7].ToString();

                        pictureBox3.ImageLocation = S1.favori_listesi[8].ToString();
                        baslik3.Text = S1.favori_listesi[9].ToString();
                        richTextBox3.Text = S1.favori_listesi[10].ToString();
                        fiyat3.Text = S1.favori_listesi[11].ToString();

                        urun_panel1.Show();
                        urun_panel2.Show();
                        urun_panel3.Show();
                    }
                    else if (S1.favori_listesi.Count > 12)
                    {
                        pictureBox1.ImageLocation = S1.favori_listesi[0].ToString();
                        baslik1.Text = S1.favori_listesi[1].ToString();
                        richTextBox1.Text = S1.favori_listesi[2].ToString();
                        fiyat.Text = S1.favori_listesi[3].ToString();

                        pictureBox2.ImageLocation = S1.favori_listesi[4].ToString();
                        baslik2.Text = S1.favori_listesi[5].ToString();
                        richTextBox2.Text = S1.favori_listesi[6].ToString();
                        fiyat2.Text = S1.favori_listesi[7].ToString();

                        pictureBox3.ImageLocation = S1.favori_listesi[8].ToString();
                        baslik3.Text = S1.favori_listesi[9].ToString();
                        richTextBox3.Text = S1.favori_listesi[10].ToString();
                        fiyat3.Text = S1.favori_listesi[11].ToString();

                        urun_panel1.Show();
                        urun_panel2.Show();
                        urun_panel3.Show();
                        alt_panel.Show();
                    }

                }
                else
                {
                    urun_panel1.Hide();
                    urun_panel2.Hide();
                    urun_panel3.Hide();
                    alt_panel.Hide();
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Veri tabanından kaynaklı hata meydana gelmiştir.Lütfen daha sonra tekrar deneyiniz", "Üzgünüz", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }


        private void button6_Click(object sender, EventArgs e)
        {

            try
            {
                urun_panel1.Hide();
                urun_panel2.Hide();
                urun_panel3.Hide();

                if (S1.favori_listesi.Count > 12 && S1.favori_listesi.Count <= 16)
                {
                    pictureBox1.ImageLocation = S1.favori_listesi[12].ToString();
                    baslik1.Text = S1.favori_listesi[13].ToString();
                    richTextBox1.Text = S1.favori_listesi[14].ToString();
                    fiyat.Text = S1.favori_listesi[15].ToString();

                    urun_panel1.Show();
                    
                }
                else if(S1.favori_listesi.Count>16 && S1.favori_listesi.Count <= 20)
                {
                    pictureBox1.ImageLocation = S1.favori_listesi[12].ToString();
                    baslik1.Text = S1.favori_listesi[13].ToString();
                    richTextBox1.Text = S1.favori_listesi[14].ToString();
                    fiyat.Text = S1.favori_listesi[15].ToString();

                    pictureBox2.ImageLocation = S1.favori_listesi[16].ToString();
                    baslik2.Text = S1.favori_listesi[17].ToString();
                    richTextBox2.Text = S1.favori_listesi[18].ToString();
                    fiyat2.Text = S1.favori_listesi[19].ToString();

                    urun_panel1.Show();
                    urun_panel2.Show();

                }
                else if(S1.favori_listesi.Count>20 && S1.favori_listesi.Count <= 24)
                {
                    pictureBox1.ImageLocation = S1.favori_listesi[12].ToString();
                    baslik1.Text = S1.favori_listesi[13].ToString();
                    richTextBox1.Text = S1.favori_listesi[14].ToString();
                    fiyat.Text = S1.favori_listesi[15].ToString();

                    pictureBox2.ImageLocation = S1.favori_listesi[16].ToString();
                    baslik2.Text = S1.favori_listesi[17].ToString();
                    richTextBox2.Text = S1.favori_listesi[18].ToString();
                    fiyat2.Text = S1.favori_listesi[19].ToString();


                    pictureBox2.ImageLocation = S1.favori_listesi[20].ToString();
                    baslik2.Text = S1.favori_listesi[21].ToString();
                    richTextBox2.Text = S1.favori_listesi[22].ToString();
                    fiyat2.Text = S1.favori_listesi[23].ToString();

                    urun_panel1.Show();
                    urun_panel2.Show();
                    urun_panel3.Show();
                }
                else if (S1.favori_listesi.Count > 24)
                {
                    pictureBox1.ImageLocation = S1.favori_listesi[12].ToString();
                    baslik1.Text = S1.favori_listesi[13].ToString();
                    richTextBox1.Text = S1.favori_listesi[14].ToString();
                    fiyat.Text = S1.favori_listesi[15].ToString();

                    pictureBox2.ImageLocation = S1.favori_listesi[16].ToString();
                    baslik2.Text = S1.favori_listesi[17].ToString();
                    richTextBox2.Text = S1.favori_listesi[18].ToString();
                    fiyat2.Text = S1.favori_listesi[19].ToString();


                    pictureBox2.ImageLocation = S1.favori_listesi[20].ToString();
                    baslik2.Text = S1.favori_listesi[21].ToString();
                    richTextBox2.Text = S1.favori_listesi[22].ToString();
                    fiyat2.Text = S1.favori_listesi[23].ToString();

                    urun_panel1.Show();
                    urun_panel2.Show();
                    urun_panel3.Show();
                }
                
            }

            catch (Exception)
            {

                MessageBox.Show("Veri tabanımızdan kaynaklı hata meydana gelmiştir.Lütfen daha sonra tekrar deneyiniz", "Üzgünüz", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button5_Click(object sender, EventArgs e) //alt panel ilk buton
        {
            urun_panel1.Show();
            urun_panel2.Show();
            urun_panel3.Show();

            pictureBox1.ImageLocation = S1.favori_listesi[0].ToString();
            baslik1.Text = S1.favori_listesi[1].ToString();
            richTextBox1.Text = S1.favori_listesi[2].ToString();
            fiyat.Text = S1.favori_listesi[3].ToString();

            pictureBox2.ImageLocation = S1.favori_listesi[4].ToString();
            baslik2.Text = S1.favori_listesi[5].ToString();
            richTextBox2.Text = S1.favori_listesi[6].ToString();
            fiyat2.Text = S1.favori_listesi[7].ToString();

            pictureBox3.ImageLocation = S1.favori_listesi[8].ToString();
            baslik3.Text = S1.favori_listesi[9].ToString();
            richTextBox3.Text = S1.favori_listesi[10].ToString();
            fiyat3.Text = S1.favori_listesi[11].ToString();
        }

        private void button7_Click(object sender, EventArgs e) //favori silme panel 1
        {
            string veri=S1.favori_silme(isim_soyisim,baslik1.Text);
            if (veri != string.Empty)
            {
                MessageBox.Show("Ürün favoriler kısmından kaldırılımıştır.", "İşlem Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Veri tabanından kaynaklı hata meydana gelmiştir.Lütfen daha sonra tekrar deneyiniz", "Üzgünüz", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            this.Hide();
        }

        private void button8_Click(object sender, EventArgs e) //favori silme panel 2
        {
            string veri = S1.favori_silme(isim_soyisim, baslik2.Text);

            if (veri != string.Empty)
            {
                MessageBox.Show("Ürün favoriler kısmından kaldırılımıştır.", "İşlem Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Veri tabanından kaynaklı hata meydana gelmiştir.Lütfen daha sonra tekrar deneyiniz", "Üzgünüz", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            this.Hide();
        }

        private void button9_Click(object sender, EventArgs e) //favori silme panel 3
        {
            string veri = S1.favori_silme(isim_soyisim, baslik3.Text);

            if (veri != string.Empty)
            {
                MessageBox.Show("Ürün favoriler kısmından kaldırılımıştır.", "İşlem Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Veri tabanından kaynaklı hata meydana gelmiştir.Lütfen daha sonra tekrar deneyiniz", "Üzgünüz", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            this.Hide();
        }


        private void favoripanel_Load(object sender, EventArgs e)
        {

        }

        private void exitbutton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void alt_panel_Paint(object sender, PaintEventArgs e)
        {

        }



    }
}


