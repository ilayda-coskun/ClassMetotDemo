using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.Id = 1;
            musteri1.Name = "İlayda";
            musteri1.LastName = "Coşkun";
            musteri1.PhoneNumber = 05555555555;

            Musteri musteri2 = new Musteri();
            musteri2.Id = 2;
            musteri2.Name = "Engin";
            musteri2.LastName = "Demiroğ";
            musteri2.PhoneNumber = 05444444444;


            //Listeleme
            Musteri[] musteriler = new Musteri[] {musteri1, musteri2 };

            Console.WriteLine("-----------MÜŞTERİLER-----------");
            foreach (var m in musteriler)
            {
                Console.WriteLine(m.Id + " " + m.Name + " " + m.LastName + " " + m.PhoneNumber);
            }

            MusteriManager musteriManager = new MusteriManager();


            //Ekleme
            Console.WriteLine("\n---------MÜŞTERİ EKLEME---------");
            for (int i = 0; i < musteriler.Length; i++)
            {
                musteriManager.Add(musteriler[i]);
            }


            //Silme
            Console.WriteLine("\n----------MÜŞTERİ SİLME----------");
            musteriManager.Delete(musteri1);
            musteriManager.Delete(musteri2);

            
        }
    }
}
