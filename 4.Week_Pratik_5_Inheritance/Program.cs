using _4.Week_Pratik_5_Inheritance;

class Program
{
    static void Main(string[] args)
    {
        Ogrenci ogrenci = new Ogrenci
        {
            Ad = "Ece",
            Soyad = "Aydın",
            OgrenciNo = 1888
        };
        ogrenci.OgrenciBilgisi();

        Ogretmen ogretmen = new Ogretmen
        {
            Ad = "Caner",
            Soyad = "Demiz",
            Maas = 58000
        };
        ogretmen.OgretmenBilgi();
    }
}