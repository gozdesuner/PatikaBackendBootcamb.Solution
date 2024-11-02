
# IMDB - Film Listesi Uygulaması

Bu C# uygulaması, kullanıcıdan film adı ve IMDB puanı alarak bir film listesi oluşturur. Kullanıcı, yeni bir film eklemek istediği sürece döngü devam eder. Uygulama, filmleri istenen kriterlere göre listeler.

## Table of Contents
- [Introduction](#introduction)
- [Technologies](#technologies)
- [Code Overview](#code-overview)
- [Usage](#usage)
- [Explanation](#explanation)
- [Output](#output)
- [License](#license)

## Introduction
Bu proje, IMDB puanları ve film adlarını kullanıcıdan alarak bir listeye kaydeder. Listeye ekleme işlemi, kullanıcı "Evet" dediği sürece devam eder. Uygulama sonunda tüm filmleri, IMDB puanı 4 ile 9 arasında olan filmleri ve 'A' harfi ile başlayan filmleri listeler.

## Technologies
- C#
- .NET

## Code Overview
- `List<Tuple<double, string>>`: IMDB puanları (double) ve film adlarını (string) bir arada saklar.
- Kullanıcıdan film bilgileri `Console.ReadLine()` ile alınır.
- Döngü yapısı ile ekleme işlemi tekrar edilir.
- `Where` LINQ sorgusu ile belirli kriterlere göre liste filtrelenir.

## Usage
Bu uygulamayı çalıştırmak için Visual Studio veya bir C# derleyici gereklidir. Program çalıştırıldığında kullanıcıya film adı ve IMDB puanı sorulur. Kullanıcı dilediği kadar film ekleyebilir ve ekleme işlemi sona erdiğinde listeleme sonuçları ekranda gösterilir.

1. Uygulama çalıştırılır.
2. Kullanıcıdan film adı ve IMDB puanı istenir.
3. Kullanıcı yeni film eklemek isteyip istemediğini belirler.
4. Sonuçlar ekranda gösterilir.

## Explanation
Aşağıda kodun satır satır açıklaması bulunmaktadır:

```csharp
class Program // Program sınıfı başlıyor
{
    static void Main() // Ana giriş noktası olan Main metodu başlıyor
    {
        List<Tuple<double, string>> filmList = new List<Tuple<double, string>>(); // IMDb puanı ve film ismini saklayacak Tuple yapısında bir film listesi oluşturuluyor
        bool devam = true; // Kullanıcının film eklemeye devam etmek isteyip istemediğini kontrol edecek boolean değişken tanımlanıyor ve başlangıç değeri true olarak ayarlanıyor

        while (devam) // Kullanıcı devam etmek istediği sürece döngü tekrar edecek
        {
            Console.WriteLine("Film adı:"); // Kullanıcıdan film adını isteyen bir mesaj yazdırılıyor
            string isim = Console.ReadLine(); // Kullanıcının girdiği film adı 'isim' değişkenine atanıyor

            Console.WriteLine("IMDB puanı:"); // Kullanıcıdan IMDb puanını isteyen bir mesaj yazdırılıyor
            double imdbPuanı; // IMDb puanını saklayacak double türünde bir değişken tanımlanıyor

            while (!double.TryParse(Console.ReadLine(), out imdbPuanı)) // Girilen değerin double türüne dönüşüp dönüşmediğini kontrol ediyor
            {
                Console.WriteLine("Geçerli bir IMDB puanı girin:"); // Hatalı giriş yapılırsa kullanıcıya tekrar geçerli bir IMDb puanı girmesi söyleniyor
                Console.WriteLine("IMDB puanı:"); // Tekrar IMDb puanı isteniyor
            }

            filmList.Add(new Tuple<double, string>(imdbPuanı, isim)); // Tuple yapısında IMDb puanı ve film adını listeye ekliyor

            Console.WriteLine("Yeni bir film eklemek ister misiniz?(Evet/Hayır):"); // Kullanıcıya yeni bir film eklemek isteyip istemediği soruluyor
            string cevap = Console.ReadLine().ToLower(); // Kullanıcıdan alınan cevap küçük harfe çevriliyor
            devam = cevap == "evet"; // Cevap "evet" ise döngü devam edecek, aksi takdirde sona erecek
        }

        Console.WriteLine("\n Tüm filmler:"); // Tüm filmleri listelemek için başlık yazdırılıyor
        foreach (var film in filmList) // Tüm film listesindeki her bir film için döngü
        {
            Console.WriteLine($"Film Adı: {film.Item2}, IMDB Puanı: {film.Item1}"); // Film adı ve IMDb puanı ekrana yazdırılıyor
        }

        Console.WriteLine("\nİsmi 'A' ile başlayan filmler:"); // 'A' harfi ile başlayan filmleri listelemek için başlık yazdırılıyor
        var aIleBaslayanFilm = filmList.Where(f => f.Item2.Length > 0 && (f.Item2[0] == 'A' || f.Item2[0] == 'a')); // İsmi 'A' veya 'a' ile başlayan filmleri filtreliyor

        foreach (var film in aIleBaslayanFilm) // Filtrelenen filmler için döngü
        {
            Console.WriteLine($"Film Adı: {film.Item2}, IMDB Puanı: {film.Item1}"); // Film adı ve IMDb puanı ekrana yazdırılıyor
        }
    }
}
```

## Output
Örnek çıktı:

```
Film adı: Inception
IMDB puanı: 8.8
Yeni bir film eklemek ister misiniz?(Evet/Hayır): Evet

Film adı: Titanic
IMDB puanı: 7.8
Yeni bir film eklemek ister misiniz?(Evet/Hayır): Hayır

Tüm Filmler:
Film Adı: Inception, IMDB Puanı: 8.8
Film Adı: Titanic, IMDB Puanı: 7.8

İsmi 'A' ile başlayan Filmler:
Film Adı: Avatar, IMDB Puanı: 7.8
```

## License
Bu proje MIT Lisansı ile lisanslanmıştır.
