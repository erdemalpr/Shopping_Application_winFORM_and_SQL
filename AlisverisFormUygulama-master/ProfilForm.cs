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
    public partial class ProfilForm : Form
    {
        public ProfilForm()
        {
            InitializeComponent();
        }

        private void ProfilForm_Load(object sender, EventArgs e)
        {

        }

        private void exitbutton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            //richTextBox1.Enabled = true;
        }

        private void richTextBox1_MouseClick(object sender, MouseEventArgs e)
        {

        }
    }
}
