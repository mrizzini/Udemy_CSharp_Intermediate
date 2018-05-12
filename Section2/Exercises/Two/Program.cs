using System;

namespace Two
{
    class Program
    {
        static void Main(string[] args)
        {

            var post = new Post("Classes Post", "This post is about classes");
            // post.Title = "Objects";
            // post.Description = "This post is ABOUT how to CHANGE ";
            // post.PostTime = DateTime.Now;
            // post.Votes = 5;            
            post.UpVote();
            post.UpVote();
            post.UpVote();
            post.UpVote();
            post.DownVote();                        
            
            post.ViewVotes();
            
            System.Console.WriteLine(post.Title + ": " + post.Description + "; created on: " + post.PostTime);
        }
    }



    public class Post
    {

        // CONSTRUCTOR?
        public Post(string _title, string _description)
        {
            this.Title = _title;
            this.Description = _description;
            this.PostTime = DateTime.Now;
            this.Votes = 0;
        }

        // private string _title;
        // private string _description; 
        // private DateTime _postTime;   
        // private int _votes; 

        // FIELDS?
        public string Title { get; }
        public string Description { get; }
        public DateTime PostTime { get; }
        public int Votes { get; private set; }


        // METHODS?
        public void UpVote()
        {
            Votes++;
        }

        public void DownVote()
        {
            Votes--;
        }

        public void ViewVotes()
        {
            System.Console.WriteLine("This post has " + Votes + " votes"); 
        }
        
    }
}
