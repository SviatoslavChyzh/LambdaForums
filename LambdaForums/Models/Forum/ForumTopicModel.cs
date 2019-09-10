using LambdaForums.Models.Post;
using System.Collections.Generic;

namespace LambdaForums.Models.Forum
{
	public class ForumTopicModel
	{
		public ForumListingModel Forum { get; set; }
		public IEnumerable<PostListingModel> Posts { get; set; }
	}
}
