using System;
using System.Text;
using System.Text.RegularExpressions;

namespace DiamondKata.Helper
{
	public static class StringHelper
	{
        public static bool IsAlphabet(char input)
        {
            return Regex.IsMatch(input.ToString(), "[a-z]", RegexOptions.IgnoreCase);
        }


        public static int GetASCIIKey(char character)
        {
            return (int)char.ToUpperInvariant(character);
        }

        public static string BuildStringOfSpaces(int spaceCount)
        {
            var sb = new StringBuilder();
            for(int i=0; i< spaceCount; i++)
            {
                sb.Append(" ");
            }

            return sb.ToString();
        }

    }
}

