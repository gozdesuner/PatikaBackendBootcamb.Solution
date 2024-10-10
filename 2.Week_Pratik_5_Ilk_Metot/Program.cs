//1-Geriye Değer Döndürmeyen Bir void metot.Ekrana sevdiğiniz bir şarkı sözünü yazdırma.

using System;
using System.Reflection.Metadata;
class Greeting
{
    public static void SarkıSozu()// SarkıSozu adında bir metot tanımladım.Public olması sınıf dışından bu metoda ulaşılmasını sağlar.void olması geriye bir değer döndürmez.
    {
        Console.WriteLine("Sorsam bana benden yakındın\nŞimdi neden uzaktasın?\nHayal kurup hep inandırdın\nYalanın batsın, yalancısın.");
    }

    static void Main(string[]args)
    {
        SarkıSozu();
    }
}
//2-Geriye Tamsayı Döndüren Bir metot.Rastgele bir sayı üretip bu sayının 2'ye bölümünden kalanı geriye döndürsün.

using System;

class Program
{
    // Geriye tamsayı döndüren AddNumber metodu
    public static int AddNumber()
    {
        Random random = new Random(); // Rastgele sayı üretici
        int rastgeleSayi = random.Next(1, 1001); // 1 ile 1000 arasında bir rastgele sayı üret
        Console.WriteLine("Üretilen Rastgele Sayı: " + rastgeleSayi);

        // Sayının 2'ye bölümünden kalanı hesapla ve geriye döndür
        return rastgeleSayi % 2;
    }

    static void Main(string[] args)
    {
        // AddNumber metodunu çağırarak 2'ye bölümünden kalan sonucu ekrana yazdır
        int kalan = AddNumber();
        Console.WriteLine("2'ye bölümünden kalan: " + kalan);
    }
}

//3-Parametre Alan ve Geriye Değer Döndüren Bir Metot.Parametre olarak aldığı iki sayının çarpımını geriye dönsün.

using System;

class Program
{
    static void Main(string[] args)
    {
        // Kullanıcıdan iki sayı al
        Console.Write("Birinci sayıyı giriniz: ");
        int sayi1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("İkinci sayıyı giriniz: ");
        int sayi2 = Convert.ToInt32(Console.ReadLine());

        // İki sayının çarpımını hesaplayan metodu çağır
        int carpimSonucu = Carp(sayi1, sayi2);

        // Sonucu ekrana yazdır
        Console.WriteLine("İki sayının çarpımı: " + carpimSonucu);
    }

    // Parametre olarak aldığı iki sayının çarpımını geri döndüren metot
    static int Carp(int a, int b)
    {
        return a * b;
    }
}
//4-Parametre Alan ve Geriye Değer Döndürmeyen bir Metot.Parametre olarak isim ve soyisim bilgilerini alıp " Hoş Geldiniz {isim} {soyisim} " şeklinde ekrana bassın.

using System;

class Program
{
    static void Main(string[] args)
    {
        // Kullanıcıdan isim ve soyisim bilgilerini al
        Console.Write("Lütfen isminizi giriniz: ");
        string isim = Console.ReadLine();

        Console.Write("Lütfen soyisminizi giriniz: ");
        string soyisim = Console.ReadLine();

        // Hoş geldiniz mesajını yazdıran metodu çağır
        HosGeldiniz(isim, soyisim);
    }

    // Parametre olarak isim ve soyisim alıp ekrana hoş geldiniz mesajı yazdıran metot
    static void HosGeldiniz(string isim, string soyisim)
    {
        Console.WriteLine("Hoş Geldiniz " + isim + " " + soyisim);
    }
}
