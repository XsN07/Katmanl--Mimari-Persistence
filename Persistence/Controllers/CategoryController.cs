using Business.Services.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace Persistence.Controllers
{
	public class CategoryController : Controller
	{
		private readonly ICategoryService _categoryService;

		public CategoryController(ICategoryService categoryService)
		{
			_categoryService = categoryService;
		}
		
	}
}
