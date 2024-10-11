# C# Metot Uygulamaları

## Table of Contents

- [Introduction](#introduction)
- [Technologies](#technologies)
- [Code Overview](#code-overview)
- [Usage](#usage)
- [Explanation](#explanation)
- [Output](#output)
- [License](#license)

## Introduction

Bu proje, C# dilinde metot kullanımlarını gösteren bir konsol uygulamasıdır. Farklı türde metotlar tanımlanarak, geriye değer döndürme, parametre alma ve ekrana mesaj yazdırma gibi işlemler gerçekleştirilmiştir.

## Technologies

- C# 10.0
- .NET 6.0

## Code Overview

Aşağıda dört farklı metot ile ilgili kod parçaları bulunmaktadır:

### 1. Geriye Değer Döndürmeyen Bir void metot: Şarkı Sözü Yazdırma

Bu metot, ekrana bir şarkı sözü yazdırır.

```csharp
using System;

class Greeting
{
    public static void SarkıSozu() // Şarkı sözü yazdıran metot
    {
        Console.WriteLine("Sorsam bana benden yakındın\nŞimdi neden uzaktasın?\nHayal kurup hep inandırdın\nYalanın batsın, yalancısın.");
    }

    static void Main(string[] args)
    {
        SarkıSozu(); // Metot çağrısı
    }
}
```

### 2. Geriye Tamsayı Döndüren Bir Metot: Rastgele Sayı Üretimi

Bu metot, 1 ile 1000 arasında rastgele bir sayı üretir ve bu sayının 2'ye bölümünden kalanı döndürür.

```csharp
using System;

class Program
{
    public static int AddNumber() // Rastgele sayı döndüren metot
    {
        Random random = new Random(); // Rastgele sayı üretici
        int rastgeleSayi = random.Next(1, 1001); // 1 ile 1000 arasında bir rastgele sayı üret
        Console.WriteLine("Üretilen Rastgele Sayı: " + rastgeleSayi);
        return rastgeleSayi % 2; // Sayının 2'ye bölümünden kalan
    }

    static void Main(string[] args)
    {
        int kalan = AddNumber(); // Metot çağrısı
        Console.WriteLine("2'ye bölümünden kalan: " + kalan);
    }
}
```

### 3. Parametre Alan ve Geriye Değer Döndüren Bir Metot: Çarpım Hesaplama

Bu metot, kullanıcıdan iki sayı alır ve bu sayıların çarpımını döndürür.

```csharp
using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Birinci sayıyı giriniz: "); // Kullanıcıdan birinci sayı
        int sayi1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("İkinci sayıyı giriniz: "); // Kullanıcıdan ikinci sayı
        int sayi2 = Convert.ToInt32(Console.ReadLine());

        int carpimSonucu = Carp(sayi1, sayi2); // Çarpım metodu çağrısı
        Console.WriteLine("İki sayının çarpımı: " + carpimSonucu); // Sonuç yazdırma
    }

    static int Carp(int a, int b) // Çarpım metodu
    {
        return a * b; // Çarpım sonucu
    }
}
```

### 4. Parametre Alan ve Geriye Değer Döndürmeyen bir Metot: Hoş Geldiniz Mesajı

Bu metot, kullanıcıdan isim ve soyisim alır ve hoş geldiniz mesajı yazdırır.

```csharp
using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Lütfen isminizi giriniz: "); // Kullanıcıdan isim
        string isim = Console.ReadLine();

        Console.Write("Lütfen soyisminizi giriniz: "); // Kullanıcıdan soyisim
        string soyisim = Console.ReadLine();

        HosGeldiniz(isim, soyisim); // Hoş geldiniz metodu çağrısı
    }

    static void HosGeldiniz(string isim, string soyisim) // Hoş geldiniz metodu
    {
        Console.WriteLine("Hoş Geldiniz " + isim + " " + soyisim); // Mesaj yazdırma
    }
}
```

## Usage

1. Uygulamayı çalıştırın.
2. İstenilen verileri girin (şarkı sözü, iki sayı, isim ve soyisim).
3. Sonuçları göreceksiniz.

## Explanation

- **Void Metot**: `SarkıSozu` metodu, geriye değer döndürmeden ekrana bir şarkı sözü yazdırır.
- **Tamsayı Döndüren Metot**: `AddNumber` metodu, rastgele bir sayı üretir ve bu sayının 2'ye bölümünden kalanı döndürür.
- **Parametre Alan ve Değer Döndüren Metot**: `Carp` metodu, iki sayının çarpımını geri döndürür.
- **Parametre Alan ve Değer Döndürmeyen Metot**: `HosGeldiniz` metodu, isim ve soyisim alarak hoş geldiniz mesajı yazdırır.

## Output

Her metot çağrıldığında, ilgili sonuçlar konsol ekranında görüntülenir.

## License

Bu proje MIT Lisansı altında lisanslanmıştır.
