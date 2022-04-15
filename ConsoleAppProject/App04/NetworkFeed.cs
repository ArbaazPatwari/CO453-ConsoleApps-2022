using System;
using System.Collections.Generic;

namespace ConsoleAppProject.App04
{
    ///<summary>
    /// The NewsFeed class stores news posts for the news feed in a social network 
    /// application.
    /// 
    /// Display of the posts is currently simulated by printing the details to the
    /// terminal. (Later, this should display in a browser.)
    /// 
    /// This version does not save the data to disk, and it does not provide any
    /// search or ordering functions.
    ///</summary>
    ///<author>
    ///  By Arbaaz Patwari
    ///  Version 24/03/2022
    ///</author> 
    public class NetworkFeed
    {
        public const string AUTHOR = "Arbaaz";

        public List<Post> posts { get; }

        ///<summary>
        /// Construct an empty news feed.
        ///</summary>
        public NetworkFeed()
        {
            posts = new List<Post>();

            MessagePost post = new MessagePost(AUTHOR, "Hello World");
            AddMessagePost(post);

            PhotoPost photopost = new PhotoPost(AUTHOR, "Photo1.jpg", "Photo of planet");
            AddPhotoPost(photopost);
        }

        ///<summary>
        /// Add a text post to the news feed.
        ///</summary>
        public void AddPost(Post post)
        {
            posts.Add(post);
        }

        public void SubtractPost(Post post)
        {
            posts.Remove(post);
        }

        public void AddMessagePost(MessagePost message)
        {
            posts.Add(message);
        }

        public void AddPhotoPost(PhotoPost photo)
        {
            posts.Add(photo);
        }

        ///<summary>
        /// Show the news feed. Currently: print the news feed details to the
        /// terminal. (To do: replace this later with display in web browser.)
        ///</summary>
        public void Display()
        {
            // display all text posts
            foreach (Post post in posts)
            {
                post.Display();
                Console.WriteLine();   // empty line between posts
            }
        }
    }

}
