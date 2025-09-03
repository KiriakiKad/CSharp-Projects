   POST VOTING SYSTEM (C# PROJECT)
=============================================

This project demonstrates the implementation 
of a simple Post class with voting functionality 
(upvotes and downvotes) in C#.

The goal is to model a post that tracks its 
title, description, creation date, and votes.

---------------------------------------------
FEATURES
---------------------------------------------
- Post class
  * Properties
    - Title
    - Description
    - DateCreated
    - Votes (initialized at 0)
  * Methods
    - UpVoting(): increases votes by 1
    - DownVoting(): decreases votes by 1 
      (cannot go below 0)
    - GetVotes(): returns current vote count

- Example program
  * Creates a new Post
  * Applies multiple upvotes and downvotes
  * Displays final vote count

---------------------------------------------
EXAMPLE USAGE
---------------------------------------------
var post = new Post("My First Post", 
                    "This is the description of my first post.");

post.UpVoting();   // +1
post.UpVoting();   // +1
post.DownVoting(); // -1
Console.WriteLine("Votes: " + post.GetVotes());

---------------------------------------------
EXPECTED OUTPUT
---------------------------------------------
1 NEGATIVE VOTE: 
1 POSITIVE VOTE: 
1 POSITIVE VOTE: 
1 POSITIVE VOTE: 
1 NEGATIVE VOTE: 
Votes: 2

---------------------------------------------
KEY CONCEPTS DEMONSTRATED
---------------------------------------------
- Encapsulation of post data
- Use of DateTime for tracking creation date
- Simple voting logic with input validation
- Defensive programming: preventing negative votes
