namespace ConsoleApp2;
using System;
using System.Text.RegularExpressions;

public class SentenceReverser
{
    public static string ReverseWords(string sentence)
    {
        string[] words = Regex.Split(sentence, @"(\s|,|:|;|=|\(|\)|&|\[|\]|""|'|\/|\\|\?|!)");
        Array.Reverse(words);

        return string.Concat(words).Trim();
    }
}
