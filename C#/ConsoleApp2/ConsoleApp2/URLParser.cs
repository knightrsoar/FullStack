namespace ConsoleApp2;
using System;
using System.Text.RegularExpressions;

public class URLParser
{
    public static void ParseUrl(string url)
    {
        var match = Regex.Match(url, @"(http[s]?|ftp)://([^/\r\n]+)(/[^\r\n]*)?");
        string protocol = match.Groups[1].Value;
        string server = match.Groups[2].Value;
        string resource = match.Groups[3].Value;

        if (string.IsNullOrEmpty(protocol))
        {
            protocol = "''"; // Assuming the '' is intentional to denote empty
        }
        if (string.IsNullOrEmpty(resource))
        {
            resource = "''";
        }

        Console.WriteLine($"[protocol] = \"{protocol}\"");
        Console.WriteLine($"[server] = \"{server}\"");
        Console.WriteLine($"[resource] = \"{resource.TrimStart('/')}\"");
    }
}