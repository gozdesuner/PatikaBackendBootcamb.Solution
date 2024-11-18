
# Table of Contents

- [Introduction](#introduction)
- [Technologies](#technologies)
- [Code Overview](#code-overview)
- [Usage](#usage)
- [Explanation](#explanation)
- [License](#license)

## Introduction

This project is a C# console application that demonstrates the use of a **Group Join** to combine and group related data from two collections: `students` and `classes`. The application lists each class and the students enrolled in it.

## Technologies

- C#
- .NET Core
- LINQ (Language Integrated Query)

## Code Overview

### Classes and Data

#### Class1
Represents a class with the following properties:
- `ClassId` (int): Unique identifier for the class.
- `ClassName` (string): Name of the class.

#### Student
Represents a student with the following properties:
- `StudentId` (int): Unique identifier for the student.
- `Name` (string): Name of the student.
- `ClassId` (int): Identifier linking the student to a class.

### LINQ Group Join Query
The program uses a LINQ `group join` operation to group students by their class.

#### Example Query
```csharp
var groupJoin = from c in classes
                join s in students on c.ClassId equals s.ClassId into studentGroup
                select new
                {
                    ClassName = c.ClassName,
                    Students = studentGroup
                };
```

This query:
1. Iterates over the `classes` collection.
2. Joins it with the `students` collection where the `ClassId` values match.
3. Groups students into their respective classes.

### Output
The program prints the class name and the names of the students enrolled in each class.

#### Example Output
```
Sınıf: Matematik
  Öğrenci: Ali
  Öğrenci: Mehmet
Sınıf: Türkçe
  Öğrenci: Ayşe
  Öğrenci: Ahmet
Sınıf: Kimya
  Öğrenci: Fatma
```

## Usage

1. Clone or download the repository.
2. Open the project in a C# development environment (e.g., Visual Studio).
3. Run the program. The output will display the classes and their respective students.

## Explanation

This program demonstrates:
- Using LINQ `group join` to group related data from two collections.
- Iterating through the grouped results and displaying the relationships between classes and students.

## License

This project is licensed under the MIT License.
