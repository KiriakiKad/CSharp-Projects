using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Find_the_longest_word
{
    class Program
    {
        static void Main(string[] args)
        {
            var path = @"...\...\...\myFile.txt";

            var file = new FileInfo(path);

            if (file.Exists)
            {
                var longestWord = GetLongestWord(file);
                Console.WriteLine("Longest word: " + longestWord);
            }
            else
            {
                Console.WriteLine("Error");
            }
        }
        public static string GetLongestWord(FileInfo file)
        {
            var text = File.ReadAllText(file.FullName);

            var words = text.Split(new[] { ' ', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);
            var max = -1;
            var longestWord = "";
            for (int i = 0; i < words.Length; i++)
            {
                if (words[i].Length > max)
                {
                    max = words[i].Length;
                    longestWord = words[i];
                }
            }
            return longestWord;
        }
    }
}
