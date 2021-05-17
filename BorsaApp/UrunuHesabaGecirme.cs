using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace BorsaApp
{
    class UrunuHesabaGecirme
    {   
        string path = @"C:\Users\enesf\Desktop\BorsaApp\Kullanicilar.txt";
        public UrunuHesabaGecirme(string kullaniciAdi, string urunAdi , int urunMiktari , int birimFiyat)
        {
            string Elemanlar = File.ReadAllText(path);
            int count = File.ReadAllLines(path).Length;
            Elemanlar = Elemanlar.Replace("\n", "").Replace("\r", "");//ParaHesabaGecirme sınıfı ile aynı mantık ve algoritmalar mevcut. 
            string[] ss = Elemanlar.Split(' ');
            string[] kk = Elemanlar.Split('\r');
            List<string> tmp = new List<string>(kk);
            int line_to_edit=0;
            string line_to_write ="";
            
            string[] lines = File.ReadAllLines(path);

            for (int i = 0; i < count * 13 - 1; i += 13)
            {
                if (ss[i] == kullaniciAdi)
                {
                    ss = tmp[0].Split(' ');

                    ss[i+8] = urunAdi;
                    ss[i+9] = urunMiktari.ToString();
                    ss[i+10] = birimFiyat.ToString();

                    line_to_write = ss[i] + " " + ss[i+1] + " " + ss[i + 2] + " " + ss[i + 3] + " " + ss[i + 4] + " " + ss[i + 5] + " " + ss[i + 6] + " " + ss[i + 7] + " " + ss[i + 8] + " " + ss[i + 9] + " " + ss[i + 10] + " " + ss[i + 11] + " " + ss[i + 12] + " ";

                    line_to_edit = (i/13)+1;
                }

            }


            using (StreamWriter writer = new StreamWriter(path))
            {
                for (int currentLine = 1; currentLine <= lines.Length; ++currentLine)
                {
                    if (currentLine == line_to_edit)
                    {
                        writer.WriteLine(line_to_write);
                    }
                    else
                    {
                        writer.WriteLine(lines[currentLine - 1]);
                    }
                }
            }


        }
    }
}
