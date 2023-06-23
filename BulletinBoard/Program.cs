using System;
using BulletinBoard;

public class Program
{
	public static void Main(string[] args)
	{
		var postSystem = new PostSystem();

		while (true)
		{
			Console.WriteLine("Welcome User          ");
			Console.WriteLine("1. Create a post");
			Console.WriteLine("2. Edit a post");
			Console.WriteLine("3. Delete a post");
			Console.WriteLine("4. List all posts");
			Console.WriteLine("5. Exit");
			

			int choice;
			if (!int.TryParse(Console.ReadLine(), out choice) || choice < 1 || choice > 5)
			{
				Console.WriteLine("Invalid choice! Please try again.");
				continue;
			}

			switch (choice)
			{
				case 1:
					Console.WriteLine("Share something: ");
					string content = Console.ReadLine();
					postSystem.CreatePost(content);
					break;
				case 2:
					Console.WriteLine("Enter number of post to Edit:");
					int editPostNumber = int.Parse(Console.ReadLine());
					Console.WriteLine("Rewrite your Post:");
					string newContent = Console.ReadLine();
					postSystem.EditPost(editPostNumber, newContent);
					break;
				case 3:
					Console.WriteLine("Enter Post Number ro Delete:");
					int deletePostNumber = int.Parse(Console.ReadLine());
					postSystem.DeletePost(deletePostNumber);
					break;
				case 4:
					postSystem.ListAllPosts();
					break;
				case 5:
					Console.WriteLine("Thank You User...");
					Environment.Exit(0);
					break;
			}

			Console.WriteLine();
		}
	}
}
