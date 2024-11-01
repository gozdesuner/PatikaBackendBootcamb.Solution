
# Guest List Program

## Introduction
This C# program creates a guest list and displays it in the console. It uses a `List<string>` to store the names of guests and then iterates through the list to display each guest's name.

## Technologies
- C#
- .NET Framework

## Code Overview
The program defines a list of names representing invited guests and displays each name on the console.

### Code Breakdown

```csharp
class Program
{
    static void Main()
    {
        // Initialize the list of guests
        List<string> davetliler = new List<string>
        {
            "Bülent Ersoy",
            "İbrahim Tatlıses",
            "Müslüm Gürses",
            "Güllü",
            "Orhan Gencebay",
            "Sezen Aksu",
            "Azer Bülbül"
        };

        Console.WriteLine("**Davetliler**");
        
        // Display each guest's name
        foreach (string isim in davetliler)
        {
            Console.WriteLine(isim);
        }
    }
}
```

## Explanation
1. **Guest List Initialization**:  
   - A list of strings named `davetliler` is initialized with names of invited guests.
   
2. **Displaying the Guest List**:  
   - A `foreach` loop iterates through each name in the `davetliler` list, displaying each one on the console.

## Output
The program displays a list of invited guests:
```
**Davetliler**
Bülent Ersoy
İbrahim Tatlıses
Müslüm Gürses
Güllü
Orhan Gencebay
Sezen Aksu
Azer Bülbül
```

## License
This project is licensed under the MIT License.
