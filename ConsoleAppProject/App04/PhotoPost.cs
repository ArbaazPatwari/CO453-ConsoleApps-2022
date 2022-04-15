using System;

namespace ConsoleAppProject.App04
{
    ///<summary>
    /// This class stores information about a post in a social network. 
    /// The main part of the post consists of a photo and a caption. 
    /// Other data, such as author and time, are also stored.
    /// Photo Post is a kind of Post.
    ///</summary>
    /// <author>
    /// By Arbaaz Patwari 
    /// Version 24/03/2022
    /// </author>
    public class PhotoPost : Post
    {
        // the name of the image file
        public String Filename { get; set; }
        
        // a one line image caption
        public String Caption { get; set; }   
      
        ///<summary>
        /// Constructor for objects of class PhotoPost.
        ///</summary>
        public PhotoPost(String author, String filename, String caption) : base(author)
        {
            this.Filename = filename;
            this.Caption = caption;
        }
        public override void Display()
        {
            Console.WriteLine("Displaying Photo Information: ");
            Console.WriteLine($"    Filename: {Filename}");
            Console.WriteLine($"    Caption: {Caption}");

            base.Display();
        }
    }
}
