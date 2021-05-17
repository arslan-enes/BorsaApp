using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace BorsaApp
{
    class AdminTexteYazdir
    {
        
        
        public AdminTexteYazdir (Admin admin)
        {
            string path = @"C:\Users\enesf\Desktop\BorsaApp\Kullanicilar.txt";
            string s;
            if (!File.Exists(path))
            {
                File.Create(path).Close();
            }
            
            string person = admin.kullaniciAdi + " " +
                            admin.Sifre + " " +
                            admin.Ad + " " +
                            admin.Soyad + " " +
                            admin.TCKimlikNo + " " +
                            admin.Telefon + " " +
                            admin.Email + " " +
                            admin.Adres +
                            " YOK 0 0 0 " +
                            admin.KullaniciTipi + " ";
            File.AppendAllText(path, person + Environment.NewLine);
                
           //Oluşturulan admin nesnesi dosyaya yazdırılıyor.
            
            
            
        }
    }
}
