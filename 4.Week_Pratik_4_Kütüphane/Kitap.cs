namespace _4.Week_Pratik_4_Kütüphane
{
    public class Kitap
    {
        //Properties
        public string Ad { get; set; }
        public string YazarAdi { get; set; }
        public string YazarSoyad { get; set; }
        public int SayfaSayisi { get; set; }
        public string Yayinevi { get; set; }
        public DateTime KayitTarihi { get; private set; }//Kayıt tarihi otomatik atanacak.

        // Default constructor (parametresiz)
        public Kitap()
        {
            KayitTarihi = DateTime.Now;

        }
        public Kitap(string ad, string yazarAdi, string yazarSoyad, int sayfaSayisi, string yayinevi)//Parametre alan constructor
        {
            Ad = ad;
            YazarAdi = yazarAdi;
            YazarSoyad = yazarSoyad;
            SayfaSayisi = sayfaSayisi;
            Yayinevi = yayinevi;
            KayitTarihi = DateTime.Now;// Kayıt tarihi otomatik atanıyor.
        }

        public void Yazdir()
        {
            Console.WriteLine($"Kitabın Adı:{Ad}");
            Console.WriteLine($"Yazar:{YazarAdi}{YazarSoyad}");
            Console.WriteLine($"Sayfa Sayısı:{SayfaSayisi}");
            Console.WriteLine($"Yayınevi:{Yayinevi}");
            Console.WriteLine($"Kayıt Tarihi:{KayitTarihi}");
        }
    }
}
