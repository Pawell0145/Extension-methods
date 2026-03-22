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



    }
}
