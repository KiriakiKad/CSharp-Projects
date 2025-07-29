using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Count_the_words
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var path = @"......\.....\...\myFile.txt";

            var fileInfo = new FileInfo(path);

            if (fileInfo.Exists)
            {
                var input = File.ReadAllText(path);
                var words = input.Split(new[] { ' ', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);
                var wordCount = words.Length;
                Console.Write("Total words: " + wordCount);
            }
            else
            {
                Console.WriteLine("Error");
            }
        }
    }
}
