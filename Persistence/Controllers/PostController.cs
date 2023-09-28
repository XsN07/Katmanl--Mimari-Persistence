using Business.Services.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace Persistence.Controllers
{
	public class PostController : Controller
	{
		private readonly IPostService _postService;

		public PostController(IPostService postService)
		{
			_postService = postService;
		}

		public IActionResult Index()
		{
			var posts = _postService.GetAll();
			return View(posts);
		}
	}
}
