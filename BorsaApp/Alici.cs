using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BorsaApp
{
    class Alici : Kullanici
    {
        public string UrunAdi { get; set; }
        public int UrunMiktari { get; set; }
        public int BirimFiyat { get; set; }
        public int Para { get; set; }

        //Kullanicidan kalitim alan alici sinifi
    }
}
