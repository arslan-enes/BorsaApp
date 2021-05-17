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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string path = @"C:\Users\enesf\Desktop\BorsaApp\Kullanicilar.txt";
            string s;
            if (!File.Exists(path))
            {
                MessageBox.Show("Kullanicilar dosyası bulunamadı !");
            }
            else
            {
                
                
                string Elemanlar = File.ReadAllText(path);
                int count = File.ReadAllLines(path).Length;
                Elemanlar = Elemanlar.Replace("\n", "").Replace("\r",""); //ParaHesabaGecirme sınfında bulunan mantık ile satır başı ve ikinci elemanlar textboxla karsilastiriliyor.
                string[] ss = Elemanlar.Split(' ');
                string temp;
                string text = File.ReadAllText(path);
                string[] kk = text.Split('\r');
                List<string> tmp = new List<string>(kk);
                kk[0] = kk[0].Replace("\n", "");


                for (int i=0; i < count*13-1; i+=13)
                {                    

                    if (textBox1.Text == ss[i] && textBox2.Text == ss[i + 1])
                    {
                        

                        if (ss[i+12]=="Alıcı") { 
                            AliciSaticiAnaEkran aliciSaticiAnaEkran = new AliciSaticiAnaEkran();
                            aliciSaticiAnaEkran.Show();
                                }
                        else if (ss[i + 12] == "Satıcı")
                        {
                            AliciSaticiAnaEkran aliciSaticiAnaEkran = new AliciSaticiAnaEkran();
                            aliciSaticiAnaEkran.Show();
                        }
                        else if (ss[i + 12] == "Admin")
                        {
                            AdminAnaEkran adminAnaEkran = new AdminAnaEkran();
                            adminAnaEkran.Show();
                        }
                        this.Hide();


                    }

                }

            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            KayitEkrani kayitEkrani = new KayitEkrani();
            kayitEkrani.Show();
        }

        private void BasaAl(string path)
        {
            
        }
    }
}
