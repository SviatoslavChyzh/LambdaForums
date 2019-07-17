﻿using LambdaForums.Data;
using LambdaForums.Models.Forum;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace LambdaForums.Controllers
{
	public class ForumController : Controller
	{
		private readonly IForum _forumService;
		private readonly IPost _postService;

		public ForumController(IForum forumService, IPost postService)
		{
			_forumService = forumService;
		}

		public IActionResult Index()
		{
			IEnumerable<ForumListingModel> forums = _forumService.GetAll()
				.Select(forum => new ForumListingModel {
					Id = forum.Id,
					Name = forum.Title,
					Description = forum.Description
			});

			var model = new ForumIndexModel {
				ForumList = forums
			};
			

			return View(model);
		}

		public IActionResult Topic(int id)
		{
			var forum = _forumService.GetById(id);
			var posts = _postService.GetFilteredPosts(id);

			var postListings = 

			return View();
		}
	}
}
