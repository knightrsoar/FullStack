using System;

namespace ConsoleApp1;
// Practice number sizes and ranges
// 1.

public class TypeInformation
{
    public static void DisplayTypeInfo()
    {
        Console.WriteLine("Type Information:");
        Console.WriteLine($"{"Type",-10} {"Bytes",-10} {"Min",-30} {"Max",-30}");

        DisplayTypeSize<sbyte>("sbyte");
        DisplayTypeSize<byte>("byte");
        DisplayTypeSize<short>("short");
        DisplayTypeSize<ushort>("ushort");
        DisplayTypeSize<int>("int");
        DisplayTypeSize<uint>("uint");
        DisplayTypeSize<long>("long");
        DisplayTypeSize<ulong>("ulong");
        DisplayTypeSize<float>("float");
        DisplayTypeSize<double>("double");
        DisplayTypeSize<decimal>("decimal");
    }

    private static void DisplayTypeSize<T>(string typeName) where T : struct
    {
        int size = GetTypeSize<T>();
        Console.WriteLine($"{typeName,-10} {size,-10} {GetMinValue<T>(),-30} {GetMaxValue<T>(),-30}");
    }

    private static int GetTypeSize<T>() where T : struct
    {
        // Manual mapping of types to their sizes
        if (typeof(T) == typeof(sbyte) || typeof(T) == typeof(byte)) return 1;
        if (typeof(T) == typeof(short) || typeof(T) == typeof(ushort)) return 2;
        if (typeof(T) == typeof(int) || typeof(T) == typeof(uint) || typeof(T) == typeof(float)) return 4;
        if (typeof(T) == typeof(long) || typeof(T) == typeof(ulong) || typeof(T) == typeof(double)) return 8;
        if (typeof(T) == typeof(decimal)) return 16;

        throw new ArgumentException("Unsupported type");
    }
    
    private static string GetMinValue<T>() where T : struct
    {
        var type = typeof(T);
        if (type == typeof(int)) return int.MinValue.ToString();
        if (type == typeof(uint)) return uint.MinValue.ToString();
        if (type == typeof(short)) return short.MinValue.ToString();
        if (type == typeof(ushort)) return ushort.MinValue.ToString();
        if (type == typeof(long)) return long.MinValue.ToString();
        if (type == typeof(ulong)) return ulong.MinValue.ToString();
        if (type == typeof(float)) return float.MinValue.ToString("R");
        if (type == typeof(double)) return double.MinValue.ToString("R");
        if (type == typeof(decimal)) return decimal.MinValue.ToString();
        if (type == typeof(byte)) return byte.MinValue.ToString();
        if (type == typeof(sbyte)) return sbyte.MinValue.ToString();
        return "N/A";
    }

    private static string GetMaxValue<T>() where T : struct
    {
        var type = typeof(T);
        if (type == typeof(int)) return int.MaxValue.ToString();
        if (type == typeof(uint)) return uint.MaxValue.ToString();
        if (type == typeof(short)) return short.MaxValue.ToString();
        if (type == typeof(ushort)) return ushort.MaxValue.ToString();
        if (type == typeof(long)) return long.MaxValue.ToString();
        if (type == typeof(ulong)) return ulong.MaxValue.ToString();
        if (type == typeof(float)) return float.MaxValue.ToString("R");
        if (type == typeof(double)) return double.MaxValue.ToString("R");
        if (type == typeof(decimal)) return decimal.MaxValue.ToString();
        if (type == typeof(byte)) return byte.MaxValue.ToString();
        if (type == typeof(sbyte)) return sbyte.MaxValue.ToString();
        return "N/A";
    }
}

