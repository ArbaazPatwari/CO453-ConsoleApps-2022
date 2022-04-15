using ConsoleAppProject.Helpers;
using System;

namespace ConsoleAppProject.App04
{
    public class NetworkApp
    {
        private static NetworkApp networker = new NetworkApp();

        public NetworkFeed NetworkFeed { get; set; } = new NetworkFeed();

        public void RunNetwork()
        {
            ConsoleHelper.OutputHeading("App 4 - Social Network");
            Console.WriteLine();
            Console.WriteLine("1. Post Message");
            Console.WriteLine("2. Post Photo");
            Console.WriteLine("3. Remove Post");
            Console.WriteLine("4. Display All Posts");
            Console.WriteLine("5. Display By Author");
            Console.WriteLine("6. Display By Date");
            Console.WriteLine("7. Add Comment");
            Console.WriteLine("8. Like Post");
            Console.WriteLine("9. Quit");

            Console.WriteLine("Please select an option > ");
            string choice = Console.ReadLine();

            if (choice == "1")
            {
                networker.PostMessage();
            }
            else if (choice == "2")
            {
                networker.PostPhoto();
            }
            else if (choice == "3")
            {
                networker.RemovePost();
            }
            else if (choice == "4")
            {
                networker.DisplayPosts();
            }
            else if (choice == "5")
            {
                networker.DisplayByAuthor();
            }
            else if (choice == "6")
            {
                networker.DisplayByDate();
            }
            else if (choice == "7")
            {
                networker.AddComment();
            }
            else if (choice == "8")
            {
                networker.LikePost();
            }
            else if (choice == "9")
            {
                System.Environment.Exit(0);
            }
            else Console.WriteLine("Invalid choice, please try again.");
            networker.RunNetwork();
        }

        private void PostMessage()
        {
            ConsoleHelper.OutputTitle("Posting a Message");

            string author = InputName();

            Console.Write("Please enter your message > ");
            string message = Console.ReadLine();

            MessagePost post = new MessagePost(author, message);
            NetworkFeed.AddPost(post);

            ConsoleHelper.OutputTitle("You have just posted this message:");
            post.Display();
        }

        private void PostPhoto()
        {
            ConsoleHelper.OutputTitle("Posting and image/ photo");

            string author = InputName();

            Console.Write("Please enter the name of the image > ");
            string filename = Console.ReadLine();
            filename = filename + ".png";

            Console.Write("Please enter a caption > ");
            string caption = Console.ReadLine();

            PhotoPost post = new PhotoPost(author, filename, caption);
            NetworkFeed.AddPost(post);

            ConsoleHelper.OutputTitle("You have just posted this image:");
            post.Display();
        }

        private void RemovePost()
        {

        }

        private void DisplayPosts()
        {
            NetworkFeed.Display();
        }

        private void DisplayByAuthor()
        {
        }

        private void DisplayByDate()
        {
        }

        private void AddComment()
        {
        }

        private void LikePost()
        {
        }

        private string InputName()
        {
            Console.Write("Please enter your name > ");
            string author = Console.ReadLine();

            return author;
        }
    }
}
