using Microsoft.AspNetCore.Mvc;
using OnlineExaminationBLL.Services;
using OnlineExaminationViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineExaminationWeb.Controllers
{
    public class AccountController : Controller
    {
        private readonly IAccountService _accountService;

        public AccountController(IAccountService accountService)
        {
            _accountService = accountService;
        }

        public IActionResult Login()
        {
            LoginViewModel sessionVM = HttpContext.Session.Get<LoginViewModel>("loginvm");
            if (sessionVM==null)
            {
                return View();
            }
            else
            {
                return RedirectUser(sessionVM);
            }
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
