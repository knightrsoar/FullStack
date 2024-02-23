using System;
using System.Linq;
namespace ConsoleApp2;
public class RotateAndSum
{
    public static void ExecuteRotateAndSum()
    {
        Console.WriteLine("Enter n integers separated by spaces:");
        int[] inputArray = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

        Console.WriteLine("Enter the number of rotations k:");
        int k = int.Parse(Console.ReadLine());

        int[] sumArray = new int[inputArray.Length];

        for (int r = 1; r <= k; r++)
        {
            int[] rotatedArray = new int[inputArray.Length];
            for (int i = 0; i < inputArray.Length; i++)
            {
                rotatedArray[(i + r) % inputArray.Length] = inputArray[i];
            }

            for (int i = 0; i < inputArray.Length; i++)
            {
                sumArray[i] += rotatedArray[i];
            }
        }

        Console.WriteLine("Sum of arrays after each rotation:");
        Console.WriteLine(string.Join(" ", sumArray));
    }
}