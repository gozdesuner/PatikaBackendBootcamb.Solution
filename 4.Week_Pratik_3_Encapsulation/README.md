
# 4th Week - Practical 3: Encapsulation Example

## Introduction
This project focuses on the concept of encapsulation in C#. Encapsulation is the process of wrapping data (variables) and code (methods) together as a single unit, restricting access to some of the object's components. The goal is to control access to the `KapiSayisi` (number of doors) property in the `Araba` (Car) class, ensuring valid values are assigned.

## Technologies
- C#
- .NET Framework

## Code Overview
The project contains the `Araba` class, which models a car with properties like `marka` (brand), `model` (model), `renk` (color), and `KapiSayisi` (number of doors). The encapsulation principle is applied to ensure that the number of doors can only be set to either 2 or 4. Any invalid input will result in a warning message and the value being set to `-1`.

### Class Structure

```csharp
namespace _4.Week_Pratik_3_Encapsulation
{
    public class Araba
    {
        public string marka { get; set; }
        public string model { get; set; }
        public string renk { get; set; }

        private int _KapiSayisi;

        public int KapiSayisi
        {
            get { return _KapiSayisi; }
            set
            {
                if (value == 2 || value == 4)
                {
                    _KapiSayisi = value;
                }
                else
                {
                    Console.WriteLine("Invalid number of doors! Please enter 2 or 4.");
                    _KapiSayisi = -1;
                }
            }
        }

        public Araba(string arabaMarka, string arabaModel, string arabaRenk, int kapiSayisi)
        {
            marka = arabaMarka;
            model = arabaModel;
            renk = arabaRenk;
            KapiSayisi = kapiSayisi;
        }
    }
}
```

### Program Structure

```csharp
class Program
{
    static void Main(string[] args)
    {
        Araba araba1 = new Araba("Alfa Romeo", "Tonale", "Grey", 4);
        Console.WriteLine($"Car1: {araba1.marka}, {araba1.model}, {araba1.renk}, Number of Doors: {araba1.KapiSayisi}");

        Araba araba2 = new Araba("Mercedes", "GLC", "Blue", 5);
        Console.WriteLine($"Car2: {araba2.marka}, {araba2.model}, {araba2.renk}, Number of Doors: {araba2.KapiSayisi}");
    }
}
```

## Usage
This program demonstrates encapsulation by:
1. Creating two instances of the `Araba` class.
2. One instance with valid inputs (4 doors).
3. Another instance with an invalid door count (5 doors), triggering the validation and warning mechanism.

### Example Usage

```bash
Car1: Alfa Romeo, Tonale, Grey, Number of Doors: 4
Invalid number of doors! Please enter 2 or 4.
Car2: Mercedes, GLC, Blue, Number of Doors: -1
```

## Explanation
- The encapsulation is handled by the `KapiSayisi` property, where only valid values (2 or 4) are accepted.
- If an invalid value is set (e.g., 5), the system displays a warning and sets the value to `-1`.

## License
This project is licensed under the MIT License.
