using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Likes_of_a_post
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Who liked your post?");
            Console.WriteLine("Give a Name or Press enter");
            var input = Console.ReadLine();

            var names = new List<string>();
            while (!string.IsNullOrWhiteSpace(input))
            {

                names.Add(input);

                Console.WriteLine("Who else liked your post?");
                input = Console.ReadLine();

            }

            var totalLikes = names.Count;
            if (totalLikes == 0)
            {
                Console.WriteLine("No one liked your post.");
            }
            else if (totalLikes == 1)
            {
                Console.Write(string.Format("{0} likes your post", names[0]));

            }
            else if (totalLikes == 2)
            {
                Console.Write(string.Format("{0} and {1} liked your post", names[0], names[1]));
            }
            else
            {
                Console.Write(string.Format("{0}, {1} and {2} others like your post", names[0], names[1], totalLikes - 2));
            }

        }
    }
}
