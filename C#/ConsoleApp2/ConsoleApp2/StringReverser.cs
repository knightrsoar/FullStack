namespace ConsoleApp2;

using System;

public class StringReverser
{   // Method 1: Using Array.Reverse
    public static string ReverseString(string text)
    {
        char[] array = text.ToCharArray();
        Array.Reverse(array);
        return new string(array);
    }
    
    // Method 2: Iterating Backwards
    public static string ReverseStringManual(string text)
    {
        char[] array = new char[text.Length];
        for (int i = 0; i < text.Length; i++)
        {
            array[i] = text[text.Length - 1 - i];
        }
        return new string(array);
    }
    
}