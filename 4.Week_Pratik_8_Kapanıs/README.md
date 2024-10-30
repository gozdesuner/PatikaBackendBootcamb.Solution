
# 4th Week Practice 8 - Product Creation with Abstraction, Encapsulation, and Polymorphism

## Introduction
This project demonstrates object-oriented programming concepts in C#, including abstraction, encapsulation, and polymorphism. In this application, users can create products such as phones and computers, each with its specific properties, using a shared base class `BaseMakine` (Base Machine).

## Technologies
- C#
- .NET Framework

## Code Overview
The project consists of an abstract base class `BaseMakine` and two derived classes: `Telefon` (Phone) and `Bilgisayar` (Computer). Each class has unique properties and methods, showcasing encapsulation and polymorphism through method overriding.

### Class Structure

1. **`BaseMakine` Class (Abstract)**
   - Represents the general characteristics of a machine.
   - Properties include `UretimTarihi` (Production Date), `SeriNumarasi` (Serial Number), `Ad` (Name), `Aciklama` (Description), and `IsletimSistemi` (Operating System).
   - Implements a `BilgileriYazdir` method to display basic information, which can be overridden by derived classes.

   ```csharp
   abstract class BaseMakine
   {
       public DateTime UretimTarihi { get; private set; }
       public string SeriNumarasi { get; set; }
       public string Ad { get; set; }
       public string Aciklama { get; set; }
       public string IsletimSistemi { get; set; }

       public BaseMakine()
       {
           UretimTarihi = DateTime.Now;
       }

       public virtual void BilgileriYazdir()
       {
           Console.WriteLine($"Ad: {Ad}");
           Console.WriteLine($"Seri Numarası: {SeriNumarasi}");
           Console.WriteLine($"Açıklama: {Aciklama}");
           Console.WriteLine($"İşletim Sistemi: {IsletimSistemi}");
           Console.WriteLine($"Üretim Tarihi: {UretimTarihi}");
       }

       public abstract void UrunAdiGetir();
   }
   ```

2. **`Telefon` Class (Phone)**
   - Inherits from `BaseMakine`.
   - Adds a `TrLisansli` property to indicate if the phone is licensed in Turkey.
   - Overrides `BilgileriYazdir` to include phone-specific details and `UrunAdiGetir` to display the product name.

   ```csharp
   class Telefon : BaseMakine
   {
       public bool TrLisansli { get; set; }

       public override void BilgileriYazdir()
       {
           base.BilgileriYazdir();
           Console.WriteLine($"TR Lisanslı: {(TrLisansli ? "Evet" : "Hayır")}");
       }

       public override void UrunAdiGetir()
       {
           Console.WriteLine($"Telefonunuzun adı ---> {Ad}");
       }
   }
   ```

3. **`Bilgisayar` Class (Computer)**
   - Inherits from `BaseMakine`.
   - Adds properties for `UsbGirisSayisi` (USB Port Count) with encapsulation and `Bluetooth` (indicating Bluetooth support).
   - Overrides `BilgileriYazdir` and `UrunAdiGetir`.

   ```csharp
   class Bilgisayar : BaseMakine
   {
       private int usbGirisSayisi;

       public bool Bluetooth { get; set; }

       public int UsbGirisSayisi
       {
           get { return usbGirisSayisi; }
           set
           {
               if (value == 2 || value == 4)
                   usbGirisSayisi = value;
               else
               {
                   usbGirisSayisi = -1;
                   Console.WriteLine("Geçersiz USB giriş sayısı, 2 veya 4 olabilir. USB giriş sayısı -1 olarak atandı.");
               }
           }
       }

       public override void BilgileriYazdir()
       {
           base.BilgileriYazdir();
           Console.WriteLine($"USB Giriş Sayısı: {usbGirisSayisi}");
           Console.WriteLine($"Bluetooth: {(Bluetooth ? "Var" : "Yok")}");
       }

       public override void UrunAdiGetir()
       {
           Console.WriteLine($"Bilgisayarınızın adı ---> {Ad}");
       }
   }
   ```

### Program Execution
The `Main` method allows the user to create and configure either a phone or computer. Each product is initialized with specific properties, and users can produce multiple products.

```csharp
class Program
{
    static void Main()
    {
        bool devamEt = true;

        while (devamEt)
        {
            Console.WriteLine("Telefon üretmek için 1'e, Bilgisayar üretmek için 2'ye basın.");
            string secim = Console.ReadLine();

            if (secim == "1")
            {
                Telefon telefon = new Telefon();
                UrunBilgileriniAl(telefon);
                Console.WriteLine("TR Lisanslı mı? (Evet/Hayır): ");
                telefon.TrLisansli = Console.ReadLine().ToLower() == "evet";
                telefon.BilgileriYazdir();
                telefon.UrunAdiGetir();
            }
            else if (secim == "2")
            {
                Bilgisayar bilgisayar = new Bilgisayar();
                UrunBilgileriniAl(bilgisayar);
                Console.WriteLine("USB Giriş Sayısı (2 veya 4): ");
                bilgisayar.UsbGirisSayisi = int.Parse(Console.ReadLine());
                Console.WriteLine("Bluetooth var mı? (Evet/Hayır): ");
                bilgisayar.Bluetooth = Console.ReadLine().ToLower() == "evet";
                bilgisayar.BilgileriYazdir();
                bilgisayar.UrunAdiGetir();
            }

            Console.WriteLine("Başka bir ürün üretmek ister misiniz? (Evet/Hayır)");
            devamEt = Console.ReadLine().ToLower() == "evet";
        }
    }

    static void UrunBilgileriniAl(BaseMakine urun)
    {
        Console.WriteLine("Ürünün adı: ");
        urun.Ad = Console.ReadLine();
        Console.WriteLine("Seri Numarası: ");
        urun.SeriNumarasi = Console.ReadLine();
        Console.WriteLine("Açıklama: ");
        urun.Aciklama = Console.ReadLine();
        Console.WriteLine("İşletim Sistemi: ");
        urun.IsletimSistemi = Console.ReadLine();
    }
}
```

## Explanation
- **Abstraction** is demonstrated through the `BaseMakine` class, which contains shared properties and an abstract method `UrunAdiGetir`.
- **Encapsulation** is implemented in the `UsbGirisSayisi` property of `Bilgisayar`, restricting valid values to 2 or 4.
- **Polymorphism** is showcased by the `BilgileriYazdir` method, which is overridden in both `Telefon` and `Bilgisayar`.

## Output
The program outputs details about each created product, including any specific properties based on the product type.

## License
This project is licensed under the MIT License.
