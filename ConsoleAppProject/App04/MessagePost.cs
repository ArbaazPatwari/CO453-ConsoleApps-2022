using System;

namespace ConsoleAppProject.App04
{
    ///<summary>
    /// This class stores information about a post in a social network. 
    /// The main part of the post consists of a (possibly multi-line)
    /// text message. Other data, such as author and time, are also stored.
    /// Message Post is a kind of Post.
    /// </summary>
    /// <author>
    /// By Arbaaz Patwari
    /// Version 24/03/2022
    /// </author>
    public class MessagePost : Post
    {
        // an arbitrarily long, multi-line message
        public String Message { get; }

        /// <summary>
        /// Constructor for objects of class MessagePost.
        /// </summary>
        public MessagePost(String author, String text) : base(author)
        {
            Message = text;
        }

        public override void Display()
        {
            Console.WriteLine("Displaying Message Information: ");
            Console.WriteLine($"    Message: {Message}");

            base.Display();
        }
    }
}
