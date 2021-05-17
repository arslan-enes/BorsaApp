using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace BorsaApp
{
    class ParaEkleme
    {
        
            string path = @"C:\Users\enesf\Desktop\BorsaApp\OnayIslemleri.txt";
            public ParaEkleme(string kullaniciAdi, int para)
            {
                File.AppendAllText(path, kullaniciAdi +" "+ para+ " TL " + Environment.NewLine);
                //Kullanıcının girdiği para miktarı admin için oluşturulan onay textine yazılıyor.

            }
        
    }
}
