namespace ConsoleApp2;

// // 1. Copying an Array
// class Program
// {
//     static void Main(string[] args)
//     {
//         // Initialize the original array
//         int[] originalArray = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
//             
//         // Create a copy array of the same length as the original
//         int[] copyArray = new int[originalArray.Length];
//             
//         // Copy elements from the original to the copy
//         for (int i = 0; i < originalArray.Length; i++)
//         {
//             copyArray[i] = originalArray[i];
//         }
//             
//         // Print original array
//         Console.WriteLine("Original Array:");
//         foreach (var item in originalArray)
//         {
//             Console.Write(item + " ");
//         }
//             
//         Console.WriteLine("\nCopied Array:");
//         // Print copied array
//         foreach (var item in copyArray)
//         {
//             Console.Write(item + " ");
//         }
//     }
// }
//
// // 2. Manage a List of Elements
// class Program
// {
//     static void Main(string[] args)
//     {
//         List<string> list = new List<string>();
//
//         while (true)
//         {
//             Console.WriteLine("Enter command (+ item, - item, or -- to clear):");
//             string command = Console.ReadLine();
//
//             if (command == "--")
//             {
//                 list.Clear();
//                 Console.WriteLine("List cleared.");
//             }
//             else if (command.StartsWith("+"))
//             {
//                 string item = command.Substring(1).Trim();
//                 list.Add(item);
//                 Console.WriteLine($"Added: {item}");
//             }
//             else if (command.StartsWith("-"))
//             {
//                 string item = command.Substring(1).Trim();
//                 if (list.Remove(item))
//                 {
//                     Console.WriteLine($"Removed: {item}");
//                 }
//                 else
//                 {
//                     Console.WriteLine($"Item not found: {item}");
//                 }
//             }
//
//             Console.WriteLine("Current List:");
//             foreach (string item in list)
//             {
//                 Console.WriteLine(item);
//             }
//         }
//     }
// }
//
// // 3. Find Primes in Range
// class Program
// {
//     static void Main(string[] args)
//     {
//         int[] primes = FindPrimesInRange(1, 100);
//         Console.WriteLine("Prime numbers between 1 and 100:");
//         foreach (int prime in primes)
//         {
//             Console.Write(prime + " ");
//         }
//     }
//
//     static int[] FindPrimesInRange(int startNum, int endNum)
//     {
//         List<int> primesList = new List<int>();
//
//         for (int num = startNum; num <= endNum; num++)
//         {
//             if (IsPrime(num))
//             {
//                 primesList.Add(num);
//             }
//         }
//
//         return primesList.ToArray();
//     }
//
//     static bool IsPrime(int num)
//     {
//         if (num <= 1) return false;
//         if (num == 2) return true;
//         if (num % 2 == 0) return false;
//
//         var boundary = (int)Math.Floor(Math.Sqrt(num));
//
//         for (int i = 3; i <= boundary; i += 2)
//         {
//             if (num % i == 0) return false;
//         }
//
//         return true;
//     }
// }


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;


public class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine(
            "Enter Array4 for RotateAndSum, Array5 for MostFrequentNumber, Array6 for LongestSequenceFinder, 1 for StringReverser, 2 for SentenceReverser, 3 for PalindromeExtractor, or 4 for URLParser:");
        string choice = Console.ReadLine();

        switch (choice)
        {
            case "Array4":
                RotateAndSum.ExecuteRotateAndSum();
                break;
            case "Array5":
                MostFrequentNumber.ExecuteMostFrequentNumber();
                break;
            case "Array6":
                LongestSequenceFinder.ExecuteLongestSequenceFinder();
                break;
            case "1":
                Console.WriteLine("Enter a string to reverse:");
                string input = Console.ReadLine();
                Console.WriteLine(StringReverser.ReverseString(input));
                Console.WriteLine(StringReverser.ReverseStringManual(input));
                break;
            case "2":
                Console.WriteLine("Enter a sentence to reverse its words:");
                string sentence = Console.ReadLine();
                Console.WriteLine(SentenceReverser.ReverseWords(sentence));
                break;
            case "3":
                Console.WriteLine("Enter text to extract palindromes:");
                string text = Console.ReadLine();
                PalindromeExtractor.ExtractPalindromes(text);
                break;
            case "4":
                Console.WriteLine("Enter URL to parse:");
                string url = Console.ReadLine();
                URLParser.ParseUrl(url);
                break;
            default:
                Console.WriteLine("Invalid option.");
                break;
        }
    }
    
}