
# Table of Contents

- [Introduction](#introduction)
- [Technologies](#technologies)
- [Code Overview](#code-overview)
- [Usage](#usage)
- [Explanation](#explanation)
- [License](#license)

## Introduction

This project is a C# console application that manages a list of Turkish music artists. The program performs various operations on the list, such as filtering by specific criteria, sorting, and finding artists with the highest album sales. This is a LINQ-based application that demonstrates data manipulation with collections.

## Technologies

- C#
- .NET Core

## Code Overview

### Key Functionalities

1. **List of Artists**: Contains artists with properties such as `Name`, `Music Genre`, `Debut Year`, and `Album Sales`.
2. **Filtering and Display**:
   - Artists whose names start with "S".
   - Artists with album sales exceeding 10 million.
   - Artists who debuted before 2000 and perform pop music.
3. **Sorting and Aggregation**:
   - Identifies the artist with the highest album sales.
   - Finds the most recent and oldest debuting artists.

### Code Structure

```csharp
List<Sarkici> sarkicilar = new List<Sarkici>
{
    new Sarkici { Ad = "Ajda Pekkan", MuzikTur= "Pop", CikisYili = 1968, AlbumSatis = 20000000 },
    // Additional artists added here
};

var sIleBaslayanlar = sarkicilar.Where(s => s.Ad.StartsWith("S"));
var onMilyonUstu = sarkicilar.Where(s => s.AlbumSatis > 10_000_000);
var eskiPopSarkicilar = sarkicilar
    .Where(s => s.CikisYili < 2000 && s.MuzikTur == "Pop")
    .OrderBy(s => s.CikisYili)
    .ThenBy(s => s.Ad);
var enCokAlbumSatan = sarkicilar.OrderByDescending(s => s.AlbumSatis).FirstOrDefault();
var enYeniCikisYapan = sarkicilar.OrderByDescending(s => s.CikisYili).FirstOrDefault();
var enEskiCikisYapan = sarkicilar.OrderBy(s => s.CikisYili).FirstOrDefault();
```

## Usage

1. Clone or download this repository.
2. Open the project in a C# development environment (e.g., Visual Studio).
3. Run the program. It will display:
   - Artists with names starting with "S".
   - Artists with album sales over 10 million.
   - Artists who debuted before 2000 and perform pop music.
   - The artist with the highest album sales.
   - The most recent and oldest debuting artists.

## Explanation

The program demonstrates the use of **LINQ** to filter, sort, and select items in a list of artist objects. Each operation is displayed with labels to show the list contents at each stage of processing.

## License

This project is licensed under the MIT License.
