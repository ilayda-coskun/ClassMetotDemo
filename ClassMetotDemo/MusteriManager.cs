using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void Add(Musteri musteri)
        {
            Console.WriteLine(musteri.Name + " " + musteri.LastName + " adlı müşteri eklendi." );
        }

        public void Delete(Musteri musteri)
        {
            Console.WriteLine(musteri.Name + " " + musteri.LastName + " adlı müşteri silindi.");
        }

        public void List(Musteri musteri)
        {
            Console.WriteLine(musteri.Id + " " + musteri.Name + " " +  musteri.LastName);

        }
    }
}
