using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace BorsaApp
{
    public partial class AdminAnaEkran : Form
    {
        public AdminAnaEkran()
        {
            InitializeComponent();
        }

        string path = @"C:\Users\enesf\Desktop\BorsaApp\OnayIslemleri.txt";

        private void AdminAnaEkran_Load(object sender, EventArgs e)
        {
            ListBox_Doldur();
            
        }

        private void ListBox_Doldur()
        {

            if (!File.Exists(path))
            {
                File.Create(path).Close();
            }
            string Elemanlar = File.ReadAllText(path);
            int count = File.ReadAllLines(path).Length;
            string[] ss = Elemanlar.Split('\n');

            
            for (int i = 0; i < count; i++)
            {
                listBox1.Items.Add(ss[i]);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a = listBox1.SelectedIndex;
            string b = listBox1.SelectedItem.ToString(); //Secilen liste ögesi onaylandıgı için texte yazdırılmaya gidiyor.
            string[] ss = b.ToString().Split(' ');
            if (ss[2] == "TL")
            {
                ParaHesabaGecirme paraHesabaGecirme = new ParaHesabaGecirme(ss[0],Convert.ToInt32(ss[1]));
            }
            else
            {
                UrunuHesabaGecirme urunuHesabaGecirme = new UrunuHesabaGecirme(ss[0], ss[2], Convert.ToInt32(ss[1]), Convert.ToInt32(ss[3]));
            }
            listBox1.Items.RemoveAt(a);
            OnayDosyasiniGuncelle();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int a = listBox1.SelectedIndex;
            listBox1.Items.RemoveAt(a);
            OnayDosyasiniGuncelle();
            //İstegi hem dosyadan hem de listboxtan silen remove butonu

        }

        private void OnayDosyasiniGuncelle()
        {
            File.WriteAllText(path, String.Empty);
            int a = listBox1.Items.Count;
            for(int i=0; i < a; i++)
            {
                File.AppendAllText(path, listBox1.Items[i].ToString());
            }
            //Onaylan ve kaldırılan ögeleri textten kaldırıyor.
        }
    }
}
