
# 4th Week Practice 5 - Inheritance

## Introduction
This project demonstrates the usage of inheritance in C#. Inheritance is a key concept in object-oriented programming, where a class can inherit properties and methods from another class. Here, we use base classes to store common information and derived classes to extend the functionality.

## Technologies
- C#
- .NET Framework

## Code Overview
The project consists of three classes: `BaseKisi`, `Ogrenci`, and `Ogretmen`. 

### BaseKisi Class
This class contains properties for a person's first and last name, along with a method to display the person's basic information.

```csharp
public class BaseKisi
{
    public string Ad { get; set; }
    public string Soyad { get; set; }

    public void KisiBilsisi()
    {
        Console.WriteLine($"Ad:{Ad} Soyad:{Soyad}");
    }
}
```

### Ogrenci Class
This class inherits from `BaseKisi` and adds an additional property for the student's ID number. It also contains a method to display the student's information.

```csharp
public class Ogrenci : BaseKisi
{
    public int OgrenciNo { get; set; }

    public void OgrenciBilgisi()
    {
        KisiBilsisi();
        Console.WriteLine($"Öğrenci No:{OgrenciNo}");
    }
}
```

### Ogretmen Class
The `Ogretmen` class also inherits from `BaseKisi` and adds a salary property. It contains a method to display the teacher's information, including their salary.

```csharp
public class Ogretmen : BaseKisi
{
    public decimal Maas { get; set; }

    public void OgretmenBilgi()
    {
        KisiBilsisi();
        Console.WriteLine($"Maaş: {Maas}TL");
    }
}
```

## Usage
In the `Main` method, we create instances of `Ogrenci` and `Ogretmen` classes, set their properties, and display their information using their respective methods.

### Example
```csharp
class Program
{
    static void Main(string[] args)
    {
        Ogrenci ogrenci = new Ogrenci
        {
            Ad = "Ece",
            Soyad = "Aydın",
            OgrenciNo = 1888
        };
        ogrenci.OgrenciBilgisi();

        Ogretmen ogretmen = new Ogretmen
        {
            Ad = "Caner",
            Soyad = "Demiz",
            Maas = 58000
        };
        ogretmen.OgretmenBilgi();
    }
}
```

## Output
```
Ad:Ece Soyad:Aydın
Öğrenci No:1888
Ad:Caner Soyad:Demiz
Maaş: 58000TL
```

## License
This project is open source and available under the MIT License.
