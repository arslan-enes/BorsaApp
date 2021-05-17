using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace BorsaApp
{
    class SaticiTexteYazdir
    {

        public SaticiTexteYazdir(Satici satici)
        {
            string path = @"C:\Users\enesf\Desktop\BorsaApp\Kullanicilar.txt";
            string s;
            if (!File.Exists(path))
            {
                File.Create(path).Close();
            }

            string person = satici.kullaniciAdi + " " +
                            satici.Sifre + " " +
                            satici.Ad + " " +
                            satici.Soyad + " " +
                            satici.TCKimlikNo + " " +
                            satici.Telefon + " " +
                            satici.Email + " " +
                            satici.Adres + " " +
                            satici.UrunAdi + "YOK " +
                            satici.UrunMiktari + " " +
                            satici.BirimFiyat + " " +
                            satici.Para + " " +
                            satici.KullaniciTipi + " ";

            File.AppendAllText(path, person + Environment.NewLine);
            //Satici nesnesi texte yazdırılıyor.
        }
    }
}
