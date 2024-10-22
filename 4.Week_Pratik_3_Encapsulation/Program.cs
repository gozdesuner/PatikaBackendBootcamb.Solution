using _4.Week_Pratik_3_Encapsulation;

class Program
{
    static void Main(string[] args)
    {

        Araba araba1 = new Araba("Alfa Romeo", "Tonale", "Gri", 4);
        Console.WriteLine($"Araba1:{araba1.marka},{araba1.model},{araba1.renk},Kapı Sayısı:{araba1.KapiSayisi}");

        Araba araba2 = new Araba("Mercedes", "GLC", "Mavi", 5);
        Console.WriteLine($"Araba2:{araba2.marka},{araba2.model},{araba2.renk},Kapı Sayısı:{araba2.KapiSayisi}");

    }
}