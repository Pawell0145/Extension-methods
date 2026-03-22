using System;

/// <summary>
/// Summary description for Class1
/// </summary>
public class StringManipulator
{
	public StringManipulator()
	{
        private string CapitalizeLetter(string input)
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

        static private string RemoveVowels(string input)
        {
            if (string.IsNullOrEmpty(input))
                return input;

            var chars = input
                .Where(c => c != ' ' && !"aeiouAEIOU".Contains(c))
                .ToArray();

            var result = string.Join(" ", chars);

            return result;
        }

    }
}
