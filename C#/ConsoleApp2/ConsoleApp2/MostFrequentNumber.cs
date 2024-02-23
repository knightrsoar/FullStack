namespace ConsoleApp2;
using System;
using System.Collections.Generic;
using System.Linq;

public class MostFrequentNumber
{
    public static void ExecuteMostFrequentNumber()
    {
        Console.WriteLine("Enter a sequence of numbers separated by space:");
        string input = Console.ReadLine();
        string[] tokens = input.Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries);
        int[] numbers = Array.ConvertAll(tokens, int.Parse);

        var frequencyMap = new Dictionary<int, int>();
        int maxFrequency = 0;

        // Calculate the frequencies and track the maximum frequency
        foreach (int number in numbers)
        {
            if (frequencyMap.ContainsKey(number))
            {
                frequencyMap[number]++;
            }
            else
            {
                frequencyMap[number] = 1;
            }

            if (frequencyMap[number] > maxFrequency)
            {
                maxFrequency = frequencyMap[number];
            }
        }

        // Extract all numbers that have the max frequency
        var maxFreqNumbers = frequencyMap.Where(f => f.Value == maxFrequency).Select(f => f.Key).ToList();

        // Find the first (leftmost) occurrence in the original array
        int leftmostNumber = numbers.First(n => maxFreqNumbers.Contains(n));

        // If there's more than one number with max frequency, print them all
        if (maxFreqNumbers.Count > 1)
        {
            string numbersList = string.Join(", ", maxFreqNumbers.OrderBy(n => numbers.ToList().IndexOf(n)));
            Console.WriteLine($"The numbers {numbersList} have the same maximal frequency (each occurs {maxFrequency} times). The leftmost of them is {leftmostNumber}.");
        }
        else
        {
            Console.WriteLine($"The number {leftmostNumber} is the most frequent (occurs {maxFrequency} times)");
        }
    }
}
