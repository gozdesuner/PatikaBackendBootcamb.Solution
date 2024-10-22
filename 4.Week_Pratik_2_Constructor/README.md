# 4. Haftalık Pratik 2 - Constructor Uygulaması

## Giriş
Bu proje, `Bebek` sınıfının oluşturulması ve constructor kullanımı üzerine odaklanmaktadır. Constructor, bir sınıfın örneği oluşturulduğunda otomatik olarak çağrılan özel bir metottur. Bu proje, constructor'ların nasıl kullanıldığını ve sınıf üyelerinin nasıl yapılandırılacağını göstermektedir.

## Teknolojiler
- C#
- .NET Framework

## Kod Genel Bakış
`Bebek` sınıfı, bir bebeğin adı, soyadı ve doğum tarihi bilgilerini saklamak için tasarlanmıştır. İki adet constructor bulunmaktadır: biri varsayılan değerler atamakta, diğeri ise kullanıcıdan isim ve soyisim alarak bu değerleri atamaktadır. Ayrıca, `Program` sınıfı, `Bebek` nesnelerinin oluşturulmasını ve bilgilerin konsola yazdırılmasını sağlar.

### Sınıf Yapısı

```csharp
namespace _4.Week_Pratik_2_Constructor
{
    public class Bebek
    {
        private DateTime _birthday { get; set; }
        private string _name { get; set; }
        private string _surname { get; set; }

        public Bebek()
        {
            _birthday = DateTime.Now;
            Console.WriteLine("Ingaaaaağğğğğğğğ");
            _name = "Unknown";
            _surname = "Unknown";
        }

        public Bebek(string _name, string _surname)
        {
            _birthday = DateTime.Now;
            Console.WriteLine("Ingaaaaağğğğğğğğ");
            _name = _name;
            _surname = _surname;
        }

        public void Printİnfo()
        {
            Console.WriteLine($"Name: {_name}, Surname: {_surname}, Birthday: {_birthday}");
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        Bebek baby1 = new Bebek();
        baby1.Printİnfo();

        Bebek baby2 = new Bebek("Adrianna", "Jammy");
        baby2.Printİnfo();
        Console.ReadKey();
    }
}
```

## Kullanım
1. `Bebek` sınıfını oluşturun.
2. Varsayılan constructor veya parametreli constructor kullanarak bir `Bebek` nesnesi oluşturun.
3. `Printİnfo` metodunu çağırarak bebeğin bilgilerini yazdırın.

### Örnek Kullanım

```csharp
Bebek baby1 = new Bebek(); // Varsayılan constructor
baby1.Printİnfo();

Bebek baby2 = new Bebek("Adrianna", "Jammy"); // Parametreli constructor
baby2.Printİnfo();
```

## Açıklama
- **Varsayılan Constructor**: `_birthday` alanını mevcut tarih ile başlatır ve adı ile soyadı "Unknown" olarak atar. Konsola bir mesaj yazdırır.
- **Parametreli Constructor**: Kullanıcıdan alınan isim ve soyisim ile `_birthday` alanını mevcut tarih ile başlatır. Konsola bir mesaj yazdırır.
- **Printİnfo Metodu**: Bebeğin adı, soyadı ve doğum tarihini konsola yazdırır.

## Çıktı
Konsolda yazdırılan bebek bilgileri aşağıdaki gibi olacaktır:

```
Name: Unknown, Surname: Unknown, Birthday: [Mevcut Tarih]
Name: Adrianna, Surname: Jammy, Birthday: [Mevcut Tarih]
```

## Lisans
Bu proje MIT Lisansı altında lisanslanmıştır.
