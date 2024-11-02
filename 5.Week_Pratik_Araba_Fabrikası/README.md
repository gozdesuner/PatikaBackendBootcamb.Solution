
# Araba Fabrikası Uygulaması

Bu C# uygulaması, kullanıcıdan araba bilgilerini alarak bir araba fabrikasında üretim sürecini simüle eder. Kullanıcıya araba üretmek isteyip istemediği sorulur; "E" yanıtını verirse, özelliklerini belirlediği bir `Araba` nesnesi üretilir ve listeye eklenir. Kullanıcı daha fazla araba eklemek istemediğinde, tüm üretilen arabaların bilgileri listelenir.

## Table of Contents
- [Introduction](#introduction)
- [Technologies](#technologies)
- [Code Overview](#code-overview)
- [Usage](#usage)
- [Explanation](#explanation)
- [Output](#output)
- [License](#license)

## Introduction
Bu uygulama, bir araba fabrikasında üretilen araçların özelliklerini belirlemek için bir konsol arayüzü sunar. Kullanıcı, araba üretmek istemediği zaman programa son verir ve üretilen arabaların tümü listelenir.

## Technologies
- C#
- .NET Framework

## Code Overview
- **Namespace `_5.Week_Pratik_Araba_Fabrikası`**: Araba fabrikası uygulamasının ana alanını içerir.
- **Araba Sınıfı**: Araba nesneleri için `Üretim Tarihi`, `Seri Numarası`, `Marka`, `Model`, `Renk` ve `Kapı Sayısı` özelliklerine sahip bir sınıf tanımlanmıştır.
- **Üretim Tarihi Otomatik Ayarı**: `UretimTarihi` özelliği, her `Araba` nesnesi oluşturulduğunda otomatik olarak o anki tarih ile atanır.
- **Program Sınıfı**: Kullanıcıdan araba bilgilerini alır ve araba listesini yönetir.

## Usage
Uygulama çalıştırıldığında kullanıcıya araba üretmek isteyip istemediği sorulur. Kullanıcı "E" veya "H" harfleri ile cevap verir. "E" cevabı verildiğinde, araba üretim süreci başlar ve kullanıcıdan gerekli bilgiler istenir. "H" cevabı verildiğinde program sonlanır ve üretilen arabalar listelenir.

1. **Araba Üretimi**: "E" cevabını verdikten sonra kullanıcıdan sırasıyla araba bilgileri istenir.
2. **Kapı Sayısı Kontrolü**: Kapı sayısı için geçersiz bir giriş yapılırsa uyarı verilir ve tekrar giriş istenir.
3. **Listeye Ekleme ve Listeleme**: Üretilen araba `arabalar` listesine eklenir. Kullanıcı üretimden çıkmak istediğinde listelenir ve program kapanır.

## Explanation
Kodun detaylı açıklaması aşağıda verilmiştir:

```csharp
namespace _5.Week_Pratik_Araba_Fabrikası // Namespace tanımı
{
    public class Araba // Araba sınıfı başlıyor
    {
        public DateTime UretimTarihi { get; private set; } // Üretim tarihi otomatik olarak atanır
        public string SeriNo { get; set; } // Seri numarası
        public string Marka { get; set; } // Marka
        public string Model { get; set; } // Model
        public string Renk { get; set; } // Renk
        public int KapiSayisi { get; set; } // Kapı sayısı

        public Araba() // Yapıcı metot (constructor)
        {
            UretimTarihi = DateTime.Now; // Araba oluşturulduğunda üretim tarihi atanır
        }
    }
}

class Program
{
    static void Main()
    {
        List<Araba> arabalar = new List<Araba>(); // Araba nesnelerini saklayacak liste tanımlanıyor

        while (true) // Kullanıcı sonlandırana kadar devam edecek sonsuz döngü
        {
            Console.WriteLine("Araba üretmek istiyor musunuz?(E/H)"); // Kullanıcıya araba üretmek isteyip istemediği soruluyor
            string cevap = Console.ReadLine().ToLower(); // Cevap küçük harfe dönüştürülerek alınır

            if (cevap != "e" && cevap != "h") // Geçersiz giriş kontrolü
            {
                Console.WriteLine("Geçersiz cevap! Lütfen 'E' veya 'H' giriniz.");
                continue; // Döngü başına dönerek tekrar sorar
            }
            else if (cevap == "h") // Cevap "H" ise program sonlanır
            {
                Console.WriteLine("Program sonlandırılıyor.");
                break; // Döngü sonlanır
            }

            Araba YeniAraba = new Araba(); // Yeni araba nesnesi oluşturulur

            Console.WriteLine("Seri Numarası:");
            YeniAraba.SeriNo = Console.ReadLine();

            Console.WriteLine("Marka:");
            YeniAraba.Marka = Console.ReadLine();

            Console.WriteLine("Model:");
            YeniAraba.Model = Console.ReadLine();

            Console.WriteLine("Renk:");
            YeniAraba.Renk = Console.ReadLine();

        Kapı: // Kapı sayısı girişi için goto etiketi
            Console.WriteLine("Kapı Sayısı:");
            try
            {
                YeniAraba.KapiSayisi = int.Parse(Console.ReadLine()); // Kapı sayısı için int giriş yapılır
            }
            catch
            {
                Console.WriteLine("Geçersiz giriş yaptınız. Lütfen bir sayı giriniz.");
                goto Kapı; // Hatalı giriş yapılırsa tekrar kapı girişine döner
            }

            arabalar.Add(YeniAraba); // Yeni araba arabalar listesine eklenir
            Console.WriteLine("Araba üretildi! Hayırlı Olsun.");

            Console.WriteLine("Başka bir araba üretmek istiyor musunuz? (E/H):");
            cevap = Console.ReadLine().ToLower(); // Cevap küçük harfe dönüştürülerek alınır

            if (cevap == "h") // Cevap "H" ise araba listesi gösterilir ve program sonlanır
            {
                Console.WriteLine("Üretilen arabalar:");
                foreach (var araba in arabalar) // Arabalar listesi döngüyle yazdırılır
                {
                    Console.WriteLine($"Seri No: {araba.SeriNo}, Marka: {araba.Marka}");
                }
                break;
            }
        }
    }
}
```

## Output
Örnek çıktı:

```
Araba üretmek istiyor musunuz?(E/H): e
Seri Numarası: ABC123
Marka: Toyota
Model: Corolla
Renk: Beyaz
Kapı Sayısı: 4
Araba üretildi! Hayırlı Olsun.
Başka bir araba üretmek istiyor musunuz? (E/H): h

Üretilen arabalar:
Seri No: ABC123, Marka: Toyota
```

## License
Bu proje MIT Lisansı ile lisanslanmıştır.
