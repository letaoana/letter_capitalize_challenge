using System;
using System.Linq;

namespace LetterCapitalize
{
    internal class Program
    {
        private static void Main()
        {
            Console.WriteLine(LetterCapitalize("hello world!"));
        }

        public static string LetterCapitalize(string str)
        {
            var wordArray = str.Split(' ');
            for (int i = 0; i < wordArray.Length; i++)
            {
                var word = wordArray[i].ToCharArray();
                word.SetValue(char.Parse(word.FirstOrDefault().ToString().ToUpper()), 0);
                wordArray[i] = new string(word);
            }
            return string.Join(" ", wordArray);
        }
    }
}