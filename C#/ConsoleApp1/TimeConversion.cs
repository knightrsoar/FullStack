namespace ConsoleApp1;
using System.Numerics; // Required for BigInteger

// Practice number sizes and ranges
// 2.

public class TimeConversion
{
    public static void ConvertCenturies(int centuries)
    {
        int years = centuries * 100;
        int days = (int)(years * 365.2422); // Average including leap years
        int hours = days * 24;
        long minutes = hours * 60L;
        long seconds = minutes * 60L;
        long milliseconds = seconds * 1000L;
        BigInteger microseconds = milliseconds * 1000L;
        BigInteger nanoseconds = microseconds * 1000L;

        Console.WriteLine($"{centuries} centuries = {years} years = {days} days = {hours} hours = {minutes} minutes");
        Console.WriteLine($"= {seconds} seconds = {milliseconds} milliseconds = {microseconds} microseconds");
        Console.WriteLine($"= {nanoseconds} nanoseconds");
    }
}