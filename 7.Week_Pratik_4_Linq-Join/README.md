
# Table of Contents

- [Introduction](#introduction)
- [Technologies](#technologies)
- [Code Overview](#code-overview)
- [Usage](#usage)
- [Explanation](#explanation)
- [License](#license)

## Introduction

This project is a C# console application demonstrating the use of LINQ `join` operations to combine and relate data from two collections: `authors` and `books`. The program displays the relationship between books and their respective authors.

## Technologies

- C#
- .NET Core
- LINQ (Language Integrated Query)

## Code Overview

### Classes and Data

#### Author Class
Represents an author with the following properties:
- `AuthorId` (int): Unique identifier for the author.
- `Name` (string): Name of the author.

#### Book Class
Represents a book with the following properties:
- `BookId` (int): Unique identifier for the book.
- `Title` (string): Title of the book.
- `AuthorId` (int): Identifier linking the book to an author.

### LINQ Join Query
The program uses a LINQ `join` operation to combine the `authors` and `books` collections based on their `AuthorId` properties.

#### Example Query
```csharp
var title = from book in books
            join author in authors
            on book.AuthorId equals author.AuthorId
            select new
            {
                BookTitle = book.Title,
                AuthorName = author.Name
            };
```

This query:
1. Iterates over the `books` collection.
2. Joins it with the `authors` collection where the `AuthorId` values match.
3. Projects a new anonymous object containing `BookTitle` and `AuthorName`.

### Output
The program prints the relationship between books and their authors to the console.

#### Example Output
```
Kitap: Kar, Yazar: Orhan Pamuk
Kitap: Masumiyet Müzesi, Yazar: Orhan Pamuk
Kitap: 10 Minutes 38 Seconds in This Strange World, Yazar: Elif Şafak
Kitap: Beyoğlu Rapsodisi, Yazar: Ahmet Ümit
```

## Usage

1. Clone or download the repository.
2. Open the project in a C# development environment (e.g., Visual Studio).
3. Run the program. The output will display the book titles and their respective authors.

## Explanation

This program demonstrates:
- Defining relationships between collections using LINQ `join`.
- Combining data into a new, meaningful structure.
- Iterating through the results and displaying the combined information.

## License

This project is licensed under the MIT License.
