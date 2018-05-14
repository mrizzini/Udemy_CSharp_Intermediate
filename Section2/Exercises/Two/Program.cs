using System;

namespace Two
{
    class Program
    {
        static void Main(string[] args)
        {

            var post = new Post("Classes Post", "This post is about classes");
            // post.Title = "Objects";
            // post.Title = "Objects";            
            // post.Description = "This post is ABOUT how to CHANGE ";
            // post.PostTime = DateTime.Now;
            // post.Votes = 5;            
            post.UpVote();
            post.UpVote();
            post.UpVote();
            post.UpVote();
            post.DownVote();                        
            
            // post.ViewVotes();
            
            System.Console.WriteLine(post.Title + ": " + post.Description + "; created on: " + post.PostTime);
            System.Console.WriteLine("This post has " + post.Votes + " votes");
        }
    }



    public class Post
    {

        // CONSTRUCTOR?
        public Post(string newTitle, string newDescription)
        {
            this._title = newTitle;
            this._description = newDescription;
            this._postTime = DateTime.Now;
            this.Votes = 0;
        }

        private string _title;
        private string _description; 
        private DateTime _postTime;   
        // private int _votes; 

        // FIELDS?
        // public string Title { get; }
        public string Title 
        {
            get
            {
                return _title;
            }
            set
            {
                _title = value;
            }
        }

        // public string Description { get; }
        public string Description
        {
            get
            {
                return _description;
            }
            set
            {
                _description = value;
            }
        }

        // public DateTime PostTime { get; }
        public DateTime PostTime
        {
            get
            {
                return _postTime;
            }
            set
            {
                _postTime = value;
            }
        }
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

        // public void ViewVotes()
        // {
        //     System.Console.WriteLine("This post has " + Votes + " votes"); 
        // }
        
    }
}
