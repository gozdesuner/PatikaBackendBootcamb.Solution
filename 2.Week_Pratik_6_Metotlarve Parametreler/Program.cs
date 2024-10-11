//soru1-Aşağıdaki çıktıyı yazan bir program.Merhaba Nasılsın ? İyiyim Sen nasılsın ?
using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Merhaba \r\nNasılsın ?\r\nİyiyim \r\nSen nasılsın ?");
        Console.ReadKey();
    }
}

//Soru2-Bir adet metinsel , bir adet tam sayı verisi tutmak için 2 adet değişken tanımlayınız. Bunların değerlerini atayıp , ekrana yazdırınız.

using System;
class program
{
    static void Main(String[] args)
    {
        int yas = 10;
        string ad = "Efe";
        Console.WriteLine($"Adınız:{ad}\r\nYaşınız:{yas}");
    }

}

//Soru3-Rastgele bir sayı üretip , ekrana yazdırınız.

using System;
class program
{
    static void Main(String[] args)
    {
        Random rnd = new Random();//Random sınıfından bır sayı oluşturdum
        int sayı = rnd.Next(1, 1001);//'Next()' metodu ile rastgele bir tamsayı (int) üretiyoruz. Üretilen bu sayı 'sayı' değişkenine atanıyor.

        {
            Console.WriteLine($"{sayı}");
        }
    }
}

//Soru4- Rastgele bir sayı üretip , bunun 3'e bölümünden kalanı ekrana yazdırınız.

using System;
class program
{
    static void Main(String[] args)
    {
        Random rnd = new Random();//Random sınıfından bır sayı oluşturdum.
        int sayı = rnd.Next(1, 1001);//'Next()' metodu ile rastgele bir tamsayı (int) üretiyoruz. Üretilen bu sayı 'sayı' değişkenine atanıyor.


        Console.WriteLine($"Sayı:{sayı}");

        int kalan = sayı % 3;// Sayının 3'e bölümünden kalanı hesapla.
        Console.WriteLine($"Rastgele üretilen sayının kalanı:{kalan}");
    }
}
//Soru5-Kullanıcıya yaşını sorup , 18'den büyükse "+" küçükse "-" yazdıran bir uygulama.

using System;
class program
{
    static void Main(String[] args)
    {

        Console.WriteLine("Yaşınız?:");
        int yas = Convert.ToInt32(Console.ReadLine());


        if (yas >= 18)
        {
            Console.WriteLine("+");
        }
        else
        {
            Console.WriteLine("-");
        }
    }
}
//Soru6-Ekrana 10 defa " Sen Vodafone gibi anı yaşarken , ben Turkcell gibi seni her yerde çekemem." yazan bir uygulama.

int i = 0;
for (i = 0; i < 10; i++)
    Console.WriteLine(" Sen Vodafone gibi anı yaşarken , ben Turkcell gibi seni her yerde çekemem.");

//Soru7-Kullanıcıdan 2 adet metinsel değer alıp "Gülse Birsel" , "Demet Evgar" , bunların yerlerini değiştiriniz.

Console.WriteLine("Ad1:");
string ad1 = Console.ReadLine();// Kullanıcıdan ilk adı al

Console.WriteLine("Ad2:");
string ad2 = Console.ReadLine();// Kullanıcıdan ikinci adı al

Console.WriteLine($"Değiştirmeden önce:{ad1} {ad2}");// Değiştirmeden önce ad1 ve ad2'yi ekrana yazdır

string degis = ad1;// ad1'in değerini geçici bir değişkene at
ad1 = ad2;// ad1'e ad2'nin değerini ata
ad2 = degis;// ad2'ye geçici değişkenin değerini ata

Console.WriteLine($"Değiştirmeden önce:{ad1} {ad2}");// Değiştirdikten sonra ad1 ve ad2'yi ekrana yazdır
Console.ReadKey();// Kullanıcının bir tuşa basmasını bekle

//Soru8- Değer döndürmeyen ismi BenDegerDondurmem olan bir metot tanımlayınız. Ekrana "Ben değer döndürmem , benim bir karşılığım yok , beni değişkene atamaya çalışma" yazsın.

using System;
class program
{
    public static void BenDegerDondurmem()//Bu satır, BenDegerDondurmem adında, geri dönüş değeri olmayan (void) bir metot tanımlar.
    {
        Console.WriteLine("Ben değer döndürmem, benim bir karşılığım yok, beni değişkene atamaya çalışma.");
    }
    static void Main(string[] args)//Programın başlangıç noktası olan Main metodunu tanımlar. Program çalıştığında, bu metot ilk olarak çağrılır
    {
        BenDegerDondurmem();// Bu ifade, daha önce tanımlanan BenDegerDondurmem metodunu çağırır.
        Console.ReadKey();
    }
}

//Soru9- İki sayıyı alıp bunların toplam değerini geriye döndüren bir metot yazınız.

using System;

class Program
{
    // İki int sayıyı toplayan metot
    static int Toplam(int a, int b) => a + b;

    static void Main(string[] args)
    {
        // Toplama işlemini yapıp sonucu yazdır
        Console.WriteLine("5 ve 10'un toplamı: " + Toplam(5, 10));

        // Programın sonlanmaması için kullanıcıdan bir tuşa basmasını bekle
        Console.ReadKey();
    }
}

//Soru10- Kullanıcıdan true ya da false değeri alıp string bir değer dönen bir metot tanımlayınız.
string Cevap(bool cvp)
{
    return cvp ? "Evet" : "Hayır";
}

Console.WriteLine("Benimle evlenir misin? : " + Cevap(false));

Console.ReadKey();

//Soru11-3 Kişinin yaşlarını alıp en yaşlı olanının yaş bilgisini dönen bir metot yazınız.

using System;

class Program
{
    // Üç kişinin yaşlarını alıp en yaşlı olanının yaşını döndüren metot
    static int EnYasli(int yas1, int yas2, int yas3)
    {
        // En büyük yaşı bul
        return Math.Max(yas1, Math.Max(yas2, yas3));
    }

    static void Main(string[] args)
    {
        // Kullanıcıdan üç kişinin yaşlarını al
        Console.Write("Birinci kişinin yaşını girin: ");
        int yas1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("İkinci kişinin yaşını girin: ");
        int yas2 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Üçüncü kişinin yaşını girin: ");
        int yas3 = Convert.ToInt32(Console.ReadLine());

        // En yaşlı olan kişinin yaşını bul
        int enYasli = EnYasli(yas1, yas2, yas3);

        // Sonucu ekrana yazdır
        Console.WriteLine("En yaşlı kişinin yaşı: " + enYasli);

        Console.ReadKey(); // Programın sonlanmaması için kullanıcıdan bir tuşa basmasını bekler
    }
}

//Soru12-Kullanıcıdan sınırsız sayıda sayı alıp , bunlardan en büyüğünü ekrana yazdıran ve aynı zamanda geriye dönen bir metot yazınız.


int enBuyukSayi = EnBuyukSayiyiBul();// En büyük sayıyı bulmak için metodu çağır

Console.WriteLine("Girilen sayılardan en büyüğü: " + enBuyukSayi);// En büyük sayıyı ekrana yazdır

Console.ReadKey(); // Programın sonlanmaması için bir tuşa basılmasını bekle
    

    // Sınırsız sayıda sayı alıp en büyüğünü döndüren metot
    static int EnBuyukSayiyiBul()
{
    int enBuyuk = int.MinValue; // En büyük sayıyı başta en küçük tamsayı ile başlat

    while (true)
    {
        Console.Write("Bir sayı girin (Çıkmak için 0 girin): ");
        string giris = Console.ReadLine();
        int sayi;

        // Kullanıcıdan alınan değeri sayıya çevirme
        if (int.TryParse(giris, out sayi))
        {
            // Kullanıcı 0 girdiğinde döngüyü sonlandır
            if (sayi == 0)
            {
                break;
            }

            // Girilen sayı en büyük sayıdan büyükse güncelle
            if (sayi > enBuyuk)
            {
                enBuyuk = sayi;
            }
        }
        else
        {
            Console.WriteLine("Lütfen geçerli bir sayı girin."); // Geçersiz giriş için hata mesajı
        }
    }

    return enBuyuk; // En büyük sayıyı geri döndür
}   



//Soru13-Bir metot yardımıyla kullanıcıdan alınan 2 ismin yerlerini değiştiren uygulamayı yazınız.

using System;

class Program
{
    
    static void IsimleriDegistir(string isim1, string isim2, out string yeniIsim1, out string yeniIsim2)// İki ismin yerlerini değiştiren metot
    {
        // İsimlerin yerlerini değiştir
        yeniIsim1 = isim2;
        yeniIsim2 = isim1;
    }

    static void Main(string[] args)
    {
        // Kullanıcıdan iki isim al
        Console.Write("Birinci ismi giriniz: ");
        string isim1 = Console.ReadLine();

        Console.Write("İkinci ismi giriniz: ");
        string isim2 = Console.ReadLine();

        // İsimleri değiştiren metodu çağır
        IsimleriDegistir(isim1, isim2, out string yeniIsim1, out string yeniIsim2);// İsimleri değiştiren metodu çağır

        // Değiştirilen isimleri ekrana yazdır
        Console.WriteLine("Değiştirilmiş İsimler:");
        Console.WriteLine("Birinci İsim: " + yeniIsim1);
        Console.WriteLine("İkinci İsim: " + yeniIsim2);

        Console.ReadKey(); // Programın sonlanmaması için kullanıcıdan bir tuşa basmasını bekler
    }
}

//Soru14-Kullanıcıdan alınan sayının tek mi yoksa çift mi olduğu bilgisini (true/false) dönen bir metot.

using System;

class Program
{
   
    static bool CiftMi(int sayi) // Sayının çift olup olmadığını kontrol eden metot
    {
       
        return sayi % 2 == 0; // Sayının 2'ye bölümünden kalan 0 ise çift, değilse tek
    }

    static void Main(string[] args)
    {
        // Kullanıcıdan bir sayı al
        Console.Write("Bir sayı giriniz: ");
        int sayi = Convert.ToInt32(Console.ReadLine());

        
        bool sonuc = CiftMi(sayi);// CiftMi metodunu çağırarak sayının çift olup olmadığını kontrol et

        // Sonucu ekrana yazdır
        if (sonuc)
        {
            Console.WriteLine("Girilen sayı çift.");
        }
        else
        {
            Console.WriteLine("Girilen sayı tek.");
        }

        Console.ReadKey(); // Programın sonlanmaması için kullanıcıdan bir tuşa basmasını bekler
    }
}

//Soru15-Kullanıcıdan alınan hız ve zaman bilgileriyle , gidilen yolu hesaplayan bir metot yazınız.

double HesaplaYol(double hiz, double zaman)
{
    return hiz * zaman; // Yol = Hız x Zaman
}
Console.Write("Lütfen hızınızı (km/s) giriniz: ");
double hiz = Convert.ToDouble(Console.ReadLine());

Console.Write("Lütfen zamanınızı (saat) giriniz: ");
double zaman = Convert.ToDouble(Console.ReadLine());

double yol = HesaplaYol(hiz, zaman);// HesaplaYol metodunu çağırarak gidilen yolu hesapla

Console.WriteLine("Gidilen yol: " + yol + " km");

Console.ReadKey(); // Programın sonlanmaması için kullanıcıdan bir tuşa basmasını bekler


//Soru16- Yarıçap bilgisi verilen bir dairenin alanını hesaplayan bir metot yazınız.


double DaireAlan(double r)// Dairenin alanını hesaplayan metot
{
    return Math.PI * r * r;// Dairenin alanı formülü: π * r^2
}
Console.WriteLine("Yarıçapı:");
double r = Convert.ToDouble(Console.ReadLine());// Kullanıcıdan yarıçapı al ve double'a çevir
Console.WriteLine("Alanı:" + DaireAlan(r));
Console.ReadKey();

//Soru17-"Zaman bir GeRi SayIm" cümlesini alıp , hepsi büyük harf ve hepsi küçük harfle yazdırınız.

string cumle = "Zaman bir GeRi SayIm";

Console.WriteLine(cumle.ToUpper());
Console.WriteLine(cumle.ToLower());

Console.ReadKey();

//Soru18-"    Selamlar   " metnini bir değişkene atayıp , başındaki ve sonundaki boşlukları siliniz. Kalıcı olarak.


string metin = "    Selamlar   ";// Metni bir değişkene ata.
metin = metin.Trim(); // Başındaki ve sonundaki boşlukları sil.
Console.WriteLine("Güncellenmiş Metin: '" + metin + "'");
Console.ReadKey(); // Programın sonlanmaması için bir tuşa basılmasını bekle
