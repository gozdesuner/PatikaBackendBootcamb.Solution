
# Sayı Karesi Hesaplama Programı

Bu C# programı, kullanıcıdan bir sayı alarak geçerli bir sayı girişi yapıldığında bu sayının karesini hesaplar ve ekrana yazdırır. Kullanıcı geçersiz bir giriş yaparsa (örneğin, sayı yerine harf veya sembol girerse), program hata mesajı gösterir.

## Table of Contents
- [Introduction](#introduction)
- [Technologies](#technologies)
- [Code Overview](#code-overview)
- [Usage](#usage)
- [Explanation](#explanation)
- [Output](#output)
- [License](#license)

## Introduction
Bu proje, kullanıcıdan sayı girişi alarak geçerli bir giriş yapıldığında sayının karesini hesaplayıp ekrana yazdırır. Kullanıcı geçersiz bir giriş yaptığında `FormatException` hatası yakalanır ve kullanıcıya hata mesajı gösterilir.

## Technologies
- C#
- .NET

## Code Overview
- **double.Parse**: Kullanıcının girdiği değeri `double` türüne dönüştürür.
- **try-catch Bloğu**: Kullanıcının geçersiz bir giriş yapması durumunda oluşacak `FormatException` hatasını yakalar ve kullanıcıya hata mesajı gösterir.

## Usage
Program, kullanıcıdan bir sayı girdisi aldıktan sonra bu sayının karesini hesaplayarak ekrana yazdırır.

1. Uygulama çalıştırılır.
2. Kullanıcıdan bir sayı girmesi istenir.
3. Kullanıcı geçerli bir sayı girdiğinde, bu sayının karesi ekrana yazdırılır.
4. Kullanıcı geçersiz bir giriş yaparsa, "Geçersiz giriş! Lütfen bir sayı giriniz." şeklinde bir hata mesajı gösterilir.

## Explanation
Aşağıda kodun satır satır açıklaması bulunmaktadır:

```csharp
class Program // Program sınıfı başlıyor
{
    static void Main() // Ana giriş noktası olan Main metodu başlıyor
    {
        Console.Write("Bir sayı giriniz: "); // Kullanıcıdan sayı girmesi isteniyor

        try
        {
            // Kullanıcının girdiği değeri double olarak parslıyoruz
            double sayi = double.Parse(Console.ReadLine());

            // Geçerli bir sayı girildiyse karesini hesaplayıp gösteriyoruz
            double kare = sayi * sayi;
            Console.WriteLine($"Girilen sayının karesi: {kare}");
        }
        catch (FormatException)
        {
            // Kullanıcı geçersiz bir giriş yaparsa hata mesajı gösteriyoruz
            Console.WriteLine("Geçersiz giriş! Lütfen bir sayı giriniz.");
        }
    }
}
```

## Output
Örnek çıktı:

Geçerli bir giriş yapılırsa:
```
Bir sayı giriniz: 5
Girilen sayının karesi: 25
```

Geçersiz bir giriş yapılırsa:
```
Bir sayı giriniz: abc
Geçersiz giriş! Lütfen bir sayı giriniz.
```

## License
Bu proje MIT Lisansı ile lisanslanmıştır.
