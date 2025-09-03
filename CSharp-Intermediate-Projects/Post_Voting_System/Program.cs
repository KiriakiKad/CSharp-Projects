using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Post_Voting_System
{
    class Program
    {
        static void Main(string[] args)
        {
            var post = new Post("My First Post", "This is the description of my first post."); 
            Voting(post);
        }
        public static void Voting(Post post) {

            Console.WriteLine("1 NEGATIVE VOTE: "); 
            post.DownVoting(); 
            Console.WriteLine("1 POSITIVE VOTE: "); 
            post.UpVoting(); 
            Console.WriteLine("1 POSITIVE VOTE: "); 
            post.UpVoting(); 
            Console.WriteLine("1 POSITIVE VOTE: "); 
            post.UpVoting(); 
            Console.WriteLine("1 NEGATIVE VOTE: "); 
            post.DownVoting(); 
            Console.WriteLine("Votes: " + post.GetVotes()); 
        }
    }
}
