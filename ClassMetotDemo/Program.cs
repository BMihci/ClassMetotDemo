using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {

            Musteri musteri1 = new Musteri();
            musteri1.Id = 0001;
            musteri1.Name = "Berkan";
            musteri1.Surname = "Türemen";
            musteri1.Age = 30;
            musteri1.FaizOrani = 1.19;

            Musteri musteri2 = new Musteri();
            musteri2.Id = 0002;
            musteri2.Name = "Aylin";
            musteri2.Surname = "Tunalı";
            musteri2.Age = 26;
            musteri2.FaizOrani = 1.35;

            Musteri musteri3 = new Musteri();
            musteri3.Id = 0003;
            musteri3.Name = "Feza";
            musteri3.Surname = "Mıhçı";
            musteri3.Age = 54;
            musteri3.FaizOrani = 1.61;

            Musteri musteri4 = new Musteri();
            musteri4.Id = 0004;
            musteri4.Name = "Serkan";
            musteri4.Surname = "Arpacı";
            musteri4.Age = 29;
            musteri4.FaizOrani = 1.72;

            Musteri musteri5 = new Musteri();
            musteri5.Id = 0005;
            musteri5.Name = "Kübra";
            musteri5.Surname = "Çöllü";
            musteri5.Age = 25;
            musteri5.FaizOrani = 1.85;


            Musteri[] musteriler = new Musteri[] { musteri1, musteri2, musteri3, musteri4, musteri5 };

            Console.WriteLine("Simulasyonlar");

            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Ekle(musteri1);
            musteriManager.Ekle(musteri2);
            musteriManager.Sil(musteri3);
            musteriManager.FaizVer(musteri4);
            musteriManager.FaizVer(musteri5);

        }
    }
}
