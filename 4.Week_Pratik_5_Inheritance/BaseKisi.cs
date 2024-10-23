namespace _4.Week_Pratik_5_Inheritance
{
    public class BaseKisi
    {
        public string Ad { get; set; }
        public string Soyad { get; set; }

        public void KisiBilsisi()
        {
            Console.WriteLine($"Ad:{Ad} Soyad:{Soyad}");
        }

    }
    public class Ogrenci : BaseKisi
    {
        public int OgrenciNo { get; set; }

        public void OgrenciBilgisi()
        {
            KisiBilsisi();
            Console.WriteLine($"Öğrenci No:{OgrenciNo}");
        }
    }
    public class Ogretmen : BaseKisi
    {
        public decimal Maas { get; set; }

        public void OgretmenBilgi()
        {
            KisiBilsisi();
            Console.WriteLine($"Maaş: {Maas}TL");
        }
    }
}
