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
    public partial class ExitQuestion : Form
    {
        public ExitQuestion()
        {
            InitializeComponent();
        }

        private void exit_button_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void log_out_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void close_question_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
