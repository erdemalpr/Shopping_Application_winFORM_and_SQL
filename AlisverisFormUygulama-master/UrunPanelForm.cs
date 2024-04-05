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
    public partial class UrunPanelForm : Form
    {
        int kontrol = 1;

        string res1_uzanti;
        string res2_uzanti;
        public UrunPanelForm(string resim_uzanti1, string resim_uzanti2, string baslik, string ozellik, string fiyat)
        {
            InitializeComponent();
            urunpanel_res.ImageLocation = resim_uzanti1;
            urun_baslik1.Text = baslik;
            urun_ozellikler1.Text = ozellik;
            urun_fiyat1.Text = fiyat;

            res1_uzanti = resim_uzanti1;
            res2_uzanti = resim_uzanti2;
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void rs1_button_Click(object sender, EventArgs e)
        {
            urunpanel_res.ImageLocation = res1_uzanti;
        }

        private void rs2_button_Click(object sender, EventArgs e)
        {
            urunpanel_res.ImageLocation = res2_uzanti;
        }

        private void exitbutton_Click(object sender, EventArgs e)
        {

            this.Close();
            kontrol = 0;
        }
        public int degerdondur
        {
            get { return kontrol; }
            set { kontrol = value; }
        }
        
        
    }
}
