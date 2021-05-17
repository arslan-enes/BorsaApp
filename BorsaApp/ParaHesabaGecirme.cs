using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace BorsaApp
{
    class ParaHesabaGecirme
    {
        string path = @"C:\Users\enesf\Desktop\BorsaApp\Kullanicilar.txt";
        public ParaHesabaGecirme(string kullaniciAdi, int para)
        {
            string Elemanlar = File.ReadAllText(path);
            int count = File.ReadAllLines(path).Length;
            Elemanlar = Elemanlar.Replace("\n", "").Replace("\r", "");// Dosyadaki satır atlama karakterleri atılıp Elemanlar stringi olarak oluşturuluyor.
            string[] ss = Elemanlar.Split(' '); // Aralarındaki boşluklardan yararlanarak kelimelerden her biri ayrı bir indise atanıyor.            
            string[] kk = Elemanlar.Split('\r');// Bu dizide ise her kk elemanı textin bir satırını tutuyor.            
            List<string> tmp = new List<string>(kk);
            int duzenlenecek_satir = 0;
            string yazılacak_satir = "";

            string[] lines = File.ReadAllLines(path);

            for (int i = 0; i < count * 13 - 1; i += 13) // Her bir satır 13 elemandan oluştuğu için, 13 elemanda bir satır başına geliniyor
            {
                if (ss[i] == kullaniciAdi) //Girilen kullanıcı adi ile uygun satır başına gelindiğinde dizi aritmetiği kullanarak istenilen elemanlara ulaşılıp değeri değiştiriliyor.
                {
                    ss = tmp[0].Split(' ');

                    ss[i + 11] = para.ToString(); //Onaylanan para diziye yazıldı ve texte aktarılıyor.

                    yazılacak_satir = ss[i] + " " + ss[i + 1] + " " + ss[i + 2] + " " + ss[i + 3] + " " + ss[i + 4] + " " + ss[i + 5] + " " + ss[i + 6] + " " + ss[i + 7] + " " + ss[i + 8] + " " + ss[i + 9] + " " + ss[i + 10] + " " + ss[i + 11] + " " + ss[i + 12] + " ";

                    duzenlenecek_satir = (i / 13) + 1;
                }

            }


            using (StreamWriter writer = new StreamWriter(path))
            {
                for (int bulunulan_satir = 1; bulunulan_satir <= lines.Length; ++bulunulan_satir)
                {
                    if (bulunulan_satir == duzenlenecek_satir)
                    {
                        writer.WriteLine(yazılacak_satir); //Paraya sahip kullanıcı hangi satirdaysa o satir yeniden yaziliyor.
                    }
                    else
                    {
                        writer.WriteLine(lines[bulunulan_satir - 1]);
                    }
                }
            }


        }
    }
}
