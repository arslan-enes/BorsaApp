using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace BorsaApp
{
    class UrunEkleme
    {
        string path = @"C:\Users\enesf\Desktop\BorsaApp\OnayIslemleri.txt";
        public UrunEkleme(string kullaniciAdi ,string urunAdi, int urunMiktari, int birimFiyat)
        {
        
            File.AppendAllText(path,kullaniciAdi + " " + urunMiktari.ToString() + " " + urunAdi + " " + birimFiyat.ToString() + " " +Environment.NewLine);


        }
    }
}
