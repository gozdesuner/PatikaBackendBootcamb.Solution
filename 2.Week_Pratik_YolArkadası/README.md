
# Tatil Acentesi Uygulaması

Bu C# konsol uygulaması, kullanıcıların tatil planı yapmalarına yardımcı olmak için tasarlanmıştır. Kullanıcı, gitmek istediği lokasyonu seçer, kişi sayısını belirtir ve ulaşım yöntemini seçerek toplam tatil maliyetini hesaplar.

## Table of Contents

- [Introduction](#introduction)
- [Technologies](#technologies)
- [Code Overview](#code-overview)
- [Usage](#usage)
- [Explanation](#explanation)
- [Output](#output)
- [License](#license)

## Introduction

Bu uygulama, kullanıcıların tatil planları oluşturmasına yardımcı olur. Kullanıcı, belirli bir lokasyonu seçer, ulaşım seçeneğini belirtir ve toplam maliyeti hesaplar. 

## Technologies

- C# 10.0 veya daha yeni sürümler
- .NET 6.0 SDK veya daha yeni sürümler

## Code Overview

### 1. Ana Metot

```csharp
static void Main(string[] args)
{
    bool devamEt = true; // Kullanıcının tatil planı yapmak isteyip istemediğini kontrol ediyoruz.
    
    while (devamEt) // devamEt true olduğu sürece döngü devam eder.
    {
        // ...
    }
}
```

- **Açıklama**: Programın başlangıç noktasıdır. Kullanıcının tatil planı yapıp yapmadığını kontrol eden bir döngü içerir.

### 2. Lokasyon Seçimi

```csharp
string lokasyon = Console.ReadLine().ToLower(); // Lokasyonu küçük harfle al
```

- **Açıklama**: Kullanıcıdan gitmek istediği lokasyonu alır. `ToLower()` metodu ile kullanıcı girişindeki büyük/küçük harf duyarlılığı ortadan kaldırılır.

### 3. Paket Fiyatı Belirleme

```csharp
if (lokasyon == "bodrum") 
{
    paket = 4000; // Bodrum paketi
} 
else if (lokasyon == "marmaris") 
{
    paket = 3000; // Marmaris paketi
} 
else if (lokasyon == "çeşme") 
{
    paket = 5000; // Çeşme paketi
}
```

- **Açıklama**: Kullanıcının seçtiği lokasyona göre paket fiyatını belirler ve ekrana bilgi yazdırır.

### 4. Kişi Sayısını Alma

```csharp
int KisiSayısı = Convert.ToInt32(Console.ReadLine()); // Kişi sayısını al
```

- **Açıklama**: Kullanıcıdan tatil planındaki kişi sayısını alır ve `KisiSayısı` değişkenine atar.

### 5. Ulaşım Yöntemini Seçme

```csharp
int UlasımSecimi = Convert.ToInt32(Console.ReadLine());
int UlasımÜcreti = 0; // Ulaşım ücretini tutacak değişken

if (UlasımSecimi == 1) 
{
    UlasımÜcreti = 1500; // Kara yolu ücreti
} 
else if (UlasımSecimi == 2) 
{
    UlasımÜcreti = 4000; // Hava yolu ücreti
}
```

- **Açıklama**: Kullanıcıdan ulaşım yöntemini seçmesini ister ve seçime göre ulaşım ücretini belirler.

### 6. Toplam Maliyeti Hesaplama

```csharp
int toplamfiyat = paket + (KisiSayısı * UlasımÜcreti); // Toplam maliyet
```

- **Açıklama**: Seçilen paket fiyatı ile ulaşım ücretini çarparak toplam tatil maliyetini hesaplar.

## Usage

Uygulamayı çalıştırmak için şu adımları izleyin:

1. .NET 6.0 SDK veya daha yeni sürümünü yükleyin.
2. Yukarıdaki kodu bir C# dosyasına (örneğin `Program.cs`) kopyalayın.
3. Terminalde proje dizinine gidin.
4. Aşağıdaki komutla uygulamayı çalıştırın:
   ```bash
   dotnet run
   ```
5. Ekranda verilen talimatları izleyin ve yanıtları girin.

### Örnek Kullanıcı

```plaintext
Lütfen gitmek istediğiniz lokasyonu seçiniz: Bodrum, Marmaris, Çeşme
Marmaris
Bu tatil planınızda kaç kişi olacaksınız?
5
Tatilinize hangi yolla gitmek istersiniz
1-Kara Yolu (Kişi başı ulasım ücreti:1500 TL
2-Hava Yolu (Kişi başı ulasım ücreti:4000 TL
Lütfen 1 veya 2 şeklinde giriniz.
2
Toplam tatil ücretiniz:20000 TL
Başka bir tatil planlamak ister misiniz? (E/H)
E
```

## Explanation

Bu uygulama, kullanıcıdan belirli girdiler alarak bir tatil planlamasına yardımcı olur. Kullanıcı, gitmek istediği lokasyonu, kişi sayısını ve ulaşım yöntemini seçerek toplam maliyeti hesaplayabilir.

## Output

Uygulama çalıştırıldığında, kullanıcıdan alınan girişlere göre aşağıdaki gibi bir çıktı verir:

```plaintext
Lütfen gitmek istediğiniz lokasyonu seçiniz: Bodrum, Marmaris, Çeşme
Bodrum
Bu tatil planınızda kaç kişi olacaksınız?
3
Tatilinize hangi yolla gitmek istersiniz
1-Kara Yolu (Kişi başı ulasım ücreti:1500 TL
2-Hava Yolu (Kişi başı ulasım ücreti:4000 TL
Lütfen 1 veya 2 şeklinde giriniz.
1
Toplam tatil ücretiniz:13500 TL
Başka bir tatil planlamak ister misiniz? (E/H)
H
İyi günler dileriz!
```

## License

Bu proje MIT Lisansı altında lisanslanmıştır. İhtiyacınıza göre kullanabilir ve değiştirebilirsiniz.
