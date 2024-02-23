namespace ConsoleApp2;
using System;
using System.Linq;

public class PalindromeExtractor
{
    public static void ExtractPalindromes(string text)
    {
        string[] words = text.Split(new char[] { ' ', ',', '.', '?', '!' }, StringSplitOptions.RemoveEmptyEntries);
        var palindromes = words.Where(w => w.SequenceEqual(w.Reverse())).Distinct().OrderBy(w => w);
        Console.WriteLine(string.Join(", ", palindromes));
    }
}
