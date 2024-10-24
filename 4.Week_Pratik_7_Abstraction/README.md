
# 4th Week Practice 7 - Abstraction Example

## Introduction
This project demonstrates the concept of abstraction in C#. Abstraction allows the representation of essential features while hiding the implementation details. In this project, an abstract class `Calisan` (Employee) is used to model the general characteristics of employees, and specific employee types such as `YazilimGelistirici` (Software Developer), `ProjeYoneticisi` (Project Manager), and `SatisTemsilcisi` (Sales Representative) inherit from this base class and provide their unique implementations of the `Gorev` (Task) method.

## Technologies
- C#
- .NET Framework

## Code Overview
The project consists of an abstract base class `Calisan` and three derived classes that represent different types of employees. Each derived class implements its own version of the abstract `Gorev` method.

### Class Breakdown

1. **`Calisan` Class (Abstract)**
   - This class represents the general properties of an employee.
   - Properties include `Ad` (First Name), `Soyad` (Last Name), and `Departman` (Department).
   - It contains an abstract method `Gorev`, which is implemented by derived classes.

```csharp
abstract class Calisan
{
    public string Ad { get; set; }
    public string Soyad { get; set; }
    public string Departman { get; set; }

    public Calisan(string ad, string soyad, string departman)
    {
        Ad = ad;
        Soyad = soyad;
        Departman = departman;
    }
    public abstract void Gorev(); // Abstract method to be implemented by derived classes
}
```

2. **`YazilimGelistirici` Class (Software Developer)**
   - Inherits from `Calisan`.
   - Implements the `Gorev` method to print the task of a software developer.

```csharp
class YazilimGelistirici : Calisan
{
    public YazilimGelistirici(string ad, string soyad, string departman)
        : base(ad, soyad, departman) { }

    public override void Gorev()
    {
        Console.WriteLine($"{Ad} {Soyad}, Yazılım Geliştirici olarak çalışıyorum.");
    }
}
```

3. **`ProjeYoneticisi` Class (Project Manager)**
   - Inherits from `Calisan`.
   - Implements the `Gorev` method to print the task of a project manager.

```csharp
class ProjeYoneticisi : Calisan
{
    public ProjeYoneticisi(string ad, string soyad, string departman)
        : base(ad, soyad, departman) { }

    public override void Gorev()
    {
        Console.WriteLine($"{Ad} {Soyad}, Proje yöneticisi olarak çalışıyorum.");
    }
}
```

4. **`SatisTemsilcisi` Class (Sales Representative)**
   - Inherits from `Calisan`.
   - Implements the `Gorev` method to print the task of a sales representative.

```csharp
class SatisTemsilcisi : Calisan
{
    public SatisTemsilcisi(string ad, string soyad, string departman)
        : base(ad, soyad, departman) { }

    public override void Gorev()
    {
        Console.WriteLine($"{Ad} {Soyad}, Satış temsilcisi olarak çalışıyorum.");
    }
}
```

### Program Execution
In the `Main` method, we create instances of `YazilimGelistirici`, `ProjeYoneticisi`, and `SatisTemsilcisi`, and invoke their specific `Gorev` methods to display their roles.

```csharp
class Program
{
    static void Main()
    {
        Calisan yazilimci = new YazilimGelistirici("Ali", "Aygün", "Yazılım");
        Calisan projeYoneticisi = new ProjeYoneticisi("Cengiz", "Sözcü", "Proje Yönetimi");
        Calisan satisTemsilcisi = new SatisTemsilcisi("Elif", "Zeytin", "Satış");

        yazilimci.Gorev();
        projeYoneticisi.Gorev();
        satisTemsilcisi.Gorev();
    }
}
```

## Explanation
- **Abstraction** is applied by defining the abstract `Calisan` class, which contains common properties for all employees but does not define specific job roles. The `Gorev` method is abstract, meaning each derived class must implement it, providing flexibility and extensibility.
- Derived classes (`YazilimGelistirici`, `ProjeYoneticisi`, `SatisTemsilcisi`) provide specific implementations of the `Gorev` method to describe their unique roles.

## Output

```
Ali Aygün, Yazılım Geliştirici olarak çalışıyorum.
Cengiz Sözcü, Proje yöneticisi olarak çalışıyorum.
Elif Zeytin, Satış temsilcisi olarak çalışıyorum.
```

## License
This project is licensed under the MIT License.
