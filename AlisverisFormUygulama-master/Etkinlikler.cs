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
    public partial class Etkinlikler : Form
    {
        public Etkinlikler()
        {
            InitializeComponent();
        }

        private void exitbutton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Etkinlikler_Load(object sender, EventArgs e)
        {

        }
    }
}
