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

        public IActionResult Logout()
        {
            HttpContext.Session.Set<LoginViewModel>("loginvm", null);
            return RedirectToAction("Login");
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Login(LoginViewModel loginViewModel)
        {
            if (ModelState.IsValid)
            {
                LoginViewModel loginVM = _accountService.Login(loginViewModel);
                if (loginVM != null)
                {
                    HttpContext.Session.Set<LoginViewModel>("loginvm", loginVM);
                    return RedirectUser(loginVM);
                }
            }
            else
                return View(loginViewModel);
        }

        private IActionResult RedirectUser(LoginViewModel loginViewModel)
        {
            if (loginViewModel.Role==(int)Roles.Admin)
            {
                return RedirectToAction("Index", "Users");
            }
            else if (loginViewModel.Role==(int)Roles.Teacher)
            {
                return RedirectToAction("Index", "Exams");
            }
            return RedirectToAction("Profile", "Students");
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
