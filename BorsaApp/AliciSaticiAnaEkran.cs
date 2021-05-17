using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BorsaApp
{
    public partial class AliciSaticiAnaEkran : Form
    {
        public AliciSaticiAnaEkran()
        {
            InitializeComponent();          
        }

        private void button3_Click(object sender, EventArgs e)
        {
            UrunEkleme urunEkleme = new UrunEkleme(KullanıcıAdıText.Text,UrunAdiText.Text,Convert.ToInt32(UrunMiktariText.Text),Convert.ToInt32(BirimFiyatText.Text));
            UrunAdiText.Text = "";
            UrunMiktariText.Text = "";
            BirimFiyatText.Text = "";           

        }

        private void button2_Click(object sender, EventArgs e)
        {
            ParaEkleme paraEkleme = new ParaEkleme(KullanıcıAdıText.Text, Convert.ToInt32(ParaText.Text));
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
