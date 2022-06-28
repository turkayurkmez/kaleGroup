using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethods
{
    public static class SpesificExtensions
    {
        public static string RemoveSpaces(this string value)
        {
            return value.Replace(" ",string.Empty);
            
        }

        public static string TitleCase(this string value)
        {
            var splitArray = value.Split(' ');
            string titleCaseResult = string.Empty;
            foreach (var word in splitArray)
            {
                var firstLetter = word[0].ToString().ToUpper();
                var anotherLetters = word.Substring(1).ToLower();
                titleCaseResult += $"{firstLetter}{anotherLetters} ";
            }

            return titleCaseResult.TrimEnd();
        }

        public static string PasswordGenerator(this Random random, int length, bool includeNumber=true, bool includeLetter=true, bool includeAlphaNumeric=true)
        {
            string password = string.Empty;
            for (int i = 0; i < length; i++)
            {
                password += random.NextChar(includeNumber: true, includeLetter: true, includeAlphaNumeric: true);

            }
            return password;
        }

        public static string NextChar(this Random random, bool includeNumber, bool includeLetter, bool includeAlphaNumeric)
        {
            if (includeLetter && includeNumber && includeAlphaNumeric)
            {
                return ((char)random.Next(33, 127)).ToString();
            }

            return ((char)random.Next(65, 91)).ToString();


        }
    }
}
