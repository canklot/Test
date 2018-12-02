using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TasarimDesenleri
{
    public partial class pastane : Form
    {
        public pastane()
        {
            InitializeComponent();
        }

      

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void yuvarlakkap_Click(object sender, EventArgs e)
        {
            yuvarlakres.Visible = true;
        }

        private void kakotus_Click(object sender, EventArgs e)
        {
            yuvarlakres.Visible = false;
            pictureBox3.Visible = true;
        }

        private void cikolattus_Click(object sender, EventArgs e)
        {
            pictureBox3.Visible = false;
            pictureBox2.Visible = true;
        }
    }
}
