
# Array Operations Project

## Introduction
This project demonstrates basic array operations in C#. It involves creating an array of integers, filling it, displaying its contents, adding a new element from user input, and sorting it in descending order.

## Technologies
- C#
- .NET Framework

## Code Overview
The project includes several fundamental operations on arrays, such as initializing an array, iterating through elements, expanding the array, and sorting elements.

### Code Breakdown

```csharp
// Initialize an array of integers with 10 elements
int[] sayilar = new int[10];
for (int i = 0; i < sayilar.Length; i++)
{
    sayilar[i] = i; // Assign each element to its index value
    Console.WriteLine(sayilar[i]); // Display each element as it's assigned
}

// Iterate through the array using foreach and display each element
foreach (int i in sayilar)
{
    Console.WriteLine(sayilar[i]);
}

// Prompt the user to enter an additional number
Console.Write("Bir sayı giriniz:");
int sayi = int.Parse(Console.ReadLine()); // Parse the input to an integer

// Create a new array with an additional element for the user input
int[] yeniDizi = new int[11];
for (int i = 0; i < sayilar.Length; i++)
{
    yeniDizi[i] = sayilar[i]; // Copy elements from the original array to the new array
}
yeniDizi[10] = sayi; // Add the user input as the last element in the new array

// Sort the new array in ascending order, then reverse to get descending order
Array.Sort(yeniDizi);
Array.Reverse(yeniDizi);

// Display the sorted array in descending order
Console.WriteLine("Oluşan dizinin büyükten küçüğe doğru sıralanmış hali:");
foreach (int eleman in yeniDizi)
{
    Console.WriteLine(eleman);
}
```

## Explanation
1. **Array Initialization**: 
   - `sayilar` array of 10 integers is created and populated with numbers from 0 to 9. Each element is printed immediately after being assigned.
   
2. **Displaying Elements with `foreach`**: 
   - The `foreach` loop iterates over each element in the `sayilar` array, displaying each value.

3. **Expanding the Array**:
   - A new array `yeniDizi` with 11 elements is created to include an additional number entered by the user. The original array's elements are copied to `yeniDizi`, and the user’s number is added as the final element.

4. **Sorting and Reversing**:
   - `Array.Sort(yeniDizi)` sorts the elements in ascending order, and `Array.Reverse(yeniDizi)` arranges them in descending order.

5. **Displaying the Result**:
   - The final sorted array `yeniDizi` is displayed, showing elements in descending order.

## Output
The program outputs each element in the initial array, prompts the user for an additional number, and then displays the final sorted array in descending order.

## License
This project is licensed under the MIT License.
