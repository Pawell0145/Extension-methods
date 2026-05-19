using System;
using System.Linq;

public static class StringManipulator
{
    public static string CapitalizeLetter(this string input)
    {
        if (string.IsNullOrEmpty(input))
            return input;

        char[] chars = input.ToCharArray();

        for (int i = 0; i < chars.Length; i++)
        {
            if (i % 2 == 0)
                chars[i] = char.ToUpper(chars[i]);
            else
                chars[i] = char.ToLower(chars[i]);
        }

        return new string(chars);
    }

    public static string RemoveVowels(this string input)
    {
        if (string.IsNullOrEmpty(input))
            return input;

        var chars = input
            .Where(c => c != ' ' && !"aeiouAEIOU.".Contains(c))
            .ToArray();

        string result = string.Join(" ", chars);

        return result;
    }

    public static string LengthOfWords(this string input)
    {
        if (string.IsNullOrEmpty(input))
            return input;

        string[] words = input.Split(' ');
        var lengths = words.Select(w => w.Length);
        string result = string.Join(" ", lengths);

        return result;
    }

    public static bool IsProperSentence(this string input)
    {
        if (string.IsNullOrEmpty(input))
            return false;

        return char.IsUpper(input[0]) && input.EndsWith(".");
    }
}
