using System;

class ShortStringArray
{
    static void Main()
    {
        string[] inputStrings = { "Hello", "2", "world", ":-)" };
        string[] shortStrings = FilterShortStrings(inputStrings);
        foreach (var s in shortStrings)
        {
            Console.Write(s + " ");
        }
        Console.WriteLine();
    }

    private static string[] FilterShortStrings(string[] strings)
    {
        string[] shortStrings = new string[strings.Length];
        int count = 0;
        for (int i = 0; i < strings.Length; i++)
        {
            if (strings[i].Length <= 3)
            {
                shortStrings[count++] = strings[i];
            }
        }
        string[] result = new string[count];
        Array.Copy(shortStrings, 0, result, 0, count);
        return result;
    }
}
