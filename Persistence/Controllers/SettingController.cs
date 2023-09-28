using Business.Services.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace Persistence.Controllers
{
	public class SettingController : Controller
	{
		private readonly ISettingService _settingService;
		public SettingController(ISettingService settingService)
		{
			_settingService = settingService;
		}

		public IActionResult Index()
		{
			var settings = _settingService.GetAll();
			return View(settings);
		}

	}
}
