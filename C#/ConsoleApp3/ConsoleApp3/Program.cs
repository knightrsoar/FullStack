
using System;
namespace COnsoleApp3;
// Task 1: Reversing an Array
// class Program
// {
//     static void Main(string[] args)
//     {
//         Console.WriteLine("Enter the array elements separated by space (e.g., 1 2 3 4 5):");
//         string input = Console.ReadLine();
//         string[] elements = input.Split(' ');
//         int[] array = new int[elements.Length];
//             
//         for (int i = 0; i < elements.Length; i++)
//         {
//             array[i] = int.Parse(elements[i]);
//         }
//
//         Console.WriteLine("Original Array:");
//         PrintArray(array);
//             
//         ReverseArray(array);
//         Console.WriteLine("Reversed Array:");
//         PrintArray(array);
//     }
//
//     static void ReverseArray(int[] array)
//     {
//         int temp;
//         for (int i = 0; i < array.Length / 2; i++)
//         {
//             temp = array[i];
//             array[i] = array[array.Length - i - 1];
//             array[array.Length - i - 1] = temp;
//         }
//     }
//
//     static void PrintArray(int[] array)
//     {
//         foreach (int i in array)
//         {
//             Console.Write(i + " ");
//         }
//         Console.WriteLine();
//     }
// }

// Task 2: Fibonacci Sequence

// class Program
// {
//     static void Main(string[] args)
//     {
//         for (int i = 1; i <= 10; i++) // Change the number here to calculate more Fibonacci sequence, by default it's 10
//         {
//             Console.WriteLine($"Fibonacci({i}) = {Fibonacci(i)}");
//         }
//     }
//
//     static int Fibonacci(int n)
//     {
//         if (n <= 2) return 1; // Base cases for the 1st and 2nd elements
//         return Fibonacci(n - 1) + Fibonacci(n - 2); // Recursive call for other elements
//     }
// }

// Color-Ball
class Program
{
    static void Main(string[] args)
    {
        var ball1 = new Ball(new Color(255, 0, 0), 10);
        var ball2 = new Ball(new Color(0, 255, 0), 12);

        ball1.Throw();
        ball1.Throw();
        ball2.Throw();

        ball1.Pop();
        ball1.Throw(); // This should not increment the count

        Console.WriteLine($"Ball 1 was thrown {ball1.GetThrowCount()} times.");
        Console.WriteLine($"Ball 2 was thrown {ball2.GetThrowCount()} times.");
    }
}
