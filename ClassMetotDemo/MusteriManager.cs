using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMetotDemo
{
    class MusteriManager
    {

        public void Ekle(Musteri musteri)
        {
            Console.WriteLine(musteri.Name + " " + musteri.Surname + " " + "Eklendi");
        }

        public void Sil(Musteri musteri)
        {
            Console.WriteLine(musteri.Name + " " + musteri.Surname + " " + "Silindi");
        }

        public void FaizVer(Musteri musteri)
        {
            Console.WriteLine("Müşteriye" + " " + musteri.FaizOrani + " " + "Oranda Faiz Verildi");
        }

    }
}
