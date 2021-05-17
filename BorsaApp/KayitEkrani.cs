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
    public partial class KayitEkrani : Form
    {
        public KayitEkrani()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Kullanici_Yarat();
        }

        private void Kullanici_Yarat()
        {
                                                              //Comboboxta secilen iteme göre nesne oluşturuluyor. 
            if (comboBox1.SelectedItem.ToString() == "Admin") //Duruma göre 3 farklı nesne oluştuğu için copy paste yapmaktan başka bir yol bulamadım.
            {
                Admin K = new Admin();
                K.Ad = AdText.Text;
                K.Soyad = SoyadText.Text;
                K.kullaniciAdi = KullaniciAdiText.Text;
                K.Sifre = SifreText.Text;
                K.TCKimlikNo = TCKNOText.Text;
                K.Telefon = TelefonText.Text;
                K.Email = EmailText.Text;
                K.Adres = AdresText.Text;
                K.KullaniciTipi = comboBox1.SelectedItem.ToString();
                AdminTexteYazdir adminTexteYazdir = new AdminTexteYazdir(K);
                
                MessageBox.Show("Admin eklendi.\nGiriş ekranına yönlendiriliyor.");
                this.Hide();
                Login login = new Login();
                login.Show();

            }
            else if (comboBox1.SelectedItem.ToString() == "Satıcı")
            {
                Satici K = new Satici();
                K.Ad = AdText.Text;
                K.Soyad = SoyadText.Text;
                K.kullaniciAdi = KullaniciAdiText.Text;
                K.Sifre = SifreText.Text;
                K.TCKimlikNo = TCKNOText.Text;
                K.Telefon = TelefonText.Text;
                K.Email = EmailText.Text;
                K.Adres = AdresText.Text;
                K.KullaniciTipi = comboBox1.SelectedItem.ToString();
                SaticiTexteYazdir saticiTexteYazdir = new SaticiTexteYazdir(K);
                MessageBox.Show("Satici eklendi.\nGiriş ekranına yönlendiriliyor.");
                this.Hide();
                Login login = new Login();
                login.Show();
            }
            else
            {
                Alici K = new Alici();
                K.Ad = AdText.Text;
                K.Soyad = SoyadText.Text;
                K.kullaniciAdi = KullaniciAdiText.Text;
                K.Sifre = SifreText.Text;
                K.TCKimlikNo = TCKNOText.Text;
                K.Telefon = TelefonText.Text;
                K.Email = EmailText.Text;
                K.Adres = AdresText.Text;
                K.KullaniciTipi = comboBox1.SelectedItem.ToString();
                AliciTexteYazdır aliciTexteYazdır = new AliciTexteYazdır(K);
                MessageBox.Show("Alici eklendi.\nGiriş ekranına yönlendiriliyor.");
                this.Hide();
                Login login = new Login();
                login.Show();

            }
            
        }

        
    }
}
