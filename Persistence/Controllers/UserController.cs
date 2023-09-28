using Business.Services.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace Persistence.Controllers
{
	public class UserController : Controller
	{
		private readonly IUserService _userService;

		public UserController(IUserService userService)
		{
			_userService = userService;
		}

	
	}
}
