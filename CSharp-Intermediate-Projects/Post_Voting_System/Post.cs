using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Post_Voting_System
{
    public class Post
    {
        private string _title; 
        private string _description; 
        private DateTime _dateCreated; 
        private int _votes; 
        
        public Post(string title, string description) {
            _title = title; 
            _description = description; 
            _dateCreated = DateTime.Now; 
            _votes = 0; 
        }

        public void UpVoting() {
            _votes++; 
        }
        public void DownVoting() {

            if (_votes > 0) 
                _votes--; 
            else 
                Console.WriteLine("Votes cannot be negative."); 
        }
        public int GetVotes() {
            return _votes; 
        }
    }
}
