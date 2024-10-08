# Counter Program with While and Do-While Loop

This C# console application demonstrates the use of `while` and `do-while` loops by repeatedly printing a message based on a user-specified limit. The program highlights the difference between these two types of loops.

## Table of Contents

- [Introduction](#introduction)
- [Technologies](#technologies)
- [Code Overview](#code-overview)
- [Usage](#usage)
- [Explanation](#explanation)
- [Output](#output)
- [License](#license)

## Introduction

In this project, the user inputs a limit, and the program prints a message a number of times using two different loop structures: `while` and `do-while`. The key difference between the two is how they check their conditions. The `while` loop checks the condition before executing the loop's body, whereas the `do-while` loop checks the condition after executing the loop.

## Technologies

- C# 10.0 or higher
- .NET 6.0 SDK or later

## Code Overview

### 1. While Loop for Counter Increment

```csharp
while (sayaç <= limit)
{
    Console.WriteLine("Ben bir Patika'lıyım.");
    sayaç++;
}
```

- **Explanation**: The `while` loop will continue to execute as long as the counter (`sayaç`) is less than or equal to the user-defined `limit`. Each time the loop runs, the message "Ben bir Patika'lıyım." is printed, and the counter increments by one.

### 2. Do-While Loop for Counter Increment

```csharp
do
{
    Console.WriteLine("Ben bir Patika'lıyım.");
    sayaç++;
}
while (sayaç <= limit);
```

- **Explanation**: The `do-while` loop works similarly, but the key difference is that it always runs at least once because the condition is checked after the loop body is executed. Even if the initial condition is false, the body of the loop will still run one time.

### Key Difference

- The `while` loop checks the condition **before** entering the loop body.
- The `do-while` loop checks the condition **after** executing the loop body.

## Usage

To run this program, follow these steps:

1. Ensure that you have .NET 6.0 SDK or later installed.
2. Copy the code into a C# file (e.g., `Program.cs`).
3. Open a terminal and navigate to the project folder.
4. Run the code using the following command:
    ```bash
    dotnet run
    ```
5. Enter a limit when prompted, and the program will print the message as many times as specified.

Example Usage:
```bash
Lütfen bir limit değeri giriniz: 3
Ben bir Patika'lıyım.
Ben bir Patika'lıyım.
Ben bir Patika'lıyım.
Ben bir Patika'lıyım.
```

## Explanation

This project helps to illustrate:
- The basic usage of `while` and `do-while` loops.
- The difference in execution flow between the two loop types.
- User input handling and converting string values to integers in C#.

## Output

Depending on the user input, the output will vary. For example:
- If the user enters `3`, the message will be printed 4 times (0, 1, 2, and 3).
- If the user enters `5`, the message will be printed 6 times.

## License

This project is licensed under the MIT License. Feel free to use and modify it as needed.
