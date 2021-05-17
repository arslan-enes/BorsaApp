using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace BorsaApp
{
    class AliciTexteYazdır
    {
        public AliciTexteYazdır (Alici alici)
        {
            string path = @"C:\Users\enesf\Desktop\BorsaApp\Kullanicilar.txt";
            string s;
            if (!File.Exists(path))
            {
                File.Create(path).Close();
            }

            string person = alici.kullaniciAdi + " " +
                            alici.Sifre + " " +
                            alici.Ad + " " +
                            alici.Soyad + " " +
                            alici.TCKimlikNo + " " +
                            alici.Telefon + " " +
                            alici.Email + " " +
                            alici.Adres + " " +                            
                            alici.UrunAdi + "YOK " +
                            alici.UrunMiktari + " " +
                            alici.BirimFiyat + " " +
                            alici.Para + " " +
                            alici.KullaniciTipi + " ";
            
            File.AppendAllText(path, person + Environment.NewLine);
            //Alici nesnesini texte yazdıran sınıf.
        }
    }
}
