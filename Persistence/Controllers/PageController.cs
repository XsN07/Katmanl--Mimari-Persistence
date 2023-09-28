using Business.Services.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace Persistence.Controllers
{
	public class PageController : Controller
	{
		private readonly IPageService _pageService;

		public PageController(IPageService pageService)
		{
			_pageService = pageService;
		}

		

	}
}
