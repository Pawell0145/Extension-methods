using System;
using System.Linq;

public class StringManipulator
{
    public StringManipulator()
    { }
        public string CapitalizeLetter(string input)
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

        public string RemoveVowels(string input)
        {
            if (string.IsNullOrEmpty(input))
                return input;

            var chars = input
                .Where(c => c != ' ' && !"aeiouAEIOU.".Contains(c))
                .ToArray();

            var result = string.Join(" ", chars);

            return result;
        }

        public string LengthOfWords(string input)
        {
            if (string.IsNullOrEmpty(input))
                return input;

            var words = input.Split(' ');
            var lengths = words.Select(w => w.Length);
            var result = string.Join(" ", lengths);

            return result;
        }

        public bool IsProperSentence(string input)
        {
            if (string.IsNullOrEmpty(input))
                return false;

            return char.IsUpper(input[0]) && input.EndsWith(".");
        }
    
}
