namespace ConsoleApp2;

public class LongestSequenceFinder
{
    public static void ExecuteLongestSequenceFinder() 
    {
        Console.WriteLine("Enter a sequence of integers separated by spaces:");
        int[] array = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

        int bestStart = 0;
        int bestLength = 1;
        int currentStart = 0;
        int currentLength = 1;

        for (int i = 1; i < array.Length; i++)
        {
            if (array[i] == array[i - 1])
            {
                currentLength++;
            }
            else
            {
                currentLength = 1;
                currentStart = i;
            }

            if (currentLength > bestLength)
            {
                bestLength = currentLength;
                bestStart = currentStart;
            }
        }

        for (int i = 0; i < bestLength; i++)
        {
            Console.Write(array[bestStart] + " ");
        }
    }
}