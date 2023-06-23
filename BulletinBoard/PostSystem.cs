using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BulletinBoard
{
	internal class PostSystem
	{
		private List<Post> posts;
		private int postCount;

		public PostSystem()
		{
			posts = new List<Post>();
			postCount = 0;
		}

		public void CreatePost(string content)
		{
			var post = new Post
			{
				Content = content,
				DateTimePosted = DateTime.Now
			};

			posts.Add(post);
			postCount++;
			Console.WriteLine("Post created successfully!");
		}

		public void EditPost(int postNumber, string newContent)
		{
			if (postNumber <= 0 || postNumber > posts.Count)
			{
				Console.WriteLine("Post Cannot be found, Please try again!");
				return;
			}

			var post = posts[postNumber - 1];
			post.Content = newContent;
			Console.WriteLine("Post edited successfully!");
		}

		public void DeletePost(int postNumber)
		{
			if (postNumber <= 0 || postNumber > posts.Count)
			{
				Console.WriteLine("Post Cannot be found, Please try again!");
				return;
			}

			posts.RemoveAt(postNumber - 1);
			postCount--;
			Console.WriteLine("Post deleted successfully!");
		}

		public void ListAllPosts()
		{
			if (postCount == 0)
			{
				Console.WriteLine("Want to share something?");
				return;
			}

			Console.WriteLine("USER TIMELINE");
			for (int i = 0; i < posts.Count; i++)
			{
				var post = posts[i];
				Console.WriteLine($"#{i + 1}");
				Console.WriteLine($"Content: {post.Content}");
				Console.WriteLine($"Posted on: {post.DateTimePosted}");
				Console.WriteLine();
			}
		}
	}
}