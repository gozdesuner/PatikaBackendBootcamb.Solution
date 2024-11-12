
# Table of Contents

- [Introduction](#introduction)
- [Technologies](#technologies)
- [Code Overview](#code-overview)
- [Usage](#usage)
- [Explanation](#explanation)
- [License](#license)

## Introduction

This project is a simple C# console application that generates a list of random integers and performs various operations on them, such as filtering even and odd numbers, finding positive and negative numbers, and calculating squares.

## Technologies

- C#
- .NET Core

## Code Overview

### Key Functionalities

1. **Random Number Generation**: Generates a list of 10 random integers between -20 and 20.
2. **Filtering**:
   - Lists even and odd numbers.
   - Separates positive and negative numbers.
   - Filters numbers between 15 and 22.
3. **Calculating Squares**: Computes the square of each number in the list.

### Code Structure

```csharp
Random random = new Random(); // Initialize a random number generator
List<int> numbers = new List<int>(); // Create an empty list for integers

// Generate random numbers and add to list
for (int i = 0; i < 10; i++)
{
    numbers.Add(random.Next(-20, 20)); // Generates numbers between -20 and 20
}

// Filter and Display Operations
var evenNumbers = numbers.Where(n => n % 2 == 0);
var oddNumbers = numbers.Where(n => n % 2 != 0);
var negatifSayilar = numbers.Where(n => n < 0);
var pozitifSayilar = numbers.Where(n => n > 0);
var between15And22 = numbers.Where(n => n > 15 && n < 22);
var squares = numbers.Select(n => n * n).ToList();
```

## Usage

1. Clone or download this repository.
2. Open the project in a C# development environment (e.g., Visual Studio).
3. Run the program. It will display:
   - The list of generated numbers.
   - The even numbers, odd numbers, negative numbers, positive numbers, numbers between 15 and 22, and the square of each number.

## Explanation

The program demonstrates the use of **LINQ** to filter and transform a list of integers. Each operation is displayed with appropriate labels to show the list contents at each stage of processing.

## License

This project is licensed under the MIT License.
