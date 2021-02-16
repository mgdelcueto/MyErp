using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MyErp.Models;

namespace MyErp.Controllers
{
    public class Account : Controller
    {
        private readonly ILogger<Account> _logger;

        public Account(ILogger<Account> logger)
        {
            _logger = logger;
        }
        public IActionResult  Noauthorized(string ReturnUrl)
        {
            ViewData["link"]=ReturnUrl;
            return View();
        }

        public IActionResult  Forbidden(string ReturnUrl)
        {
            ViewData["link"]=ReturnUrl;
            return View();
        }

        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Login(string UserName, string Password)
        {
            string UserRole="User";
            string UserRole2="HR";
            if (UserName=="Manuel"){
                UserRole="Administrator";
                UserRole2="Engineer";

            }
            if (UserName=="Gabriel"){
                UserRole2="Sales";

            }
            if (UserName=="Pepe"){
                UserRole2="Engineer";

            }
            var claims = new List<Claim>
            {
                new Claim(ClaimTypes.Name, UserName),
                new Claim("FullName", UserName),
                new Claim(ClaimTypes.Role, UserRole),
                new Claim(ClaimTypes.Role, UserRole2),
            };

            var claimsIdentity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);

            var authProperties = new AuthenticationProperties
            {
                //AllowRefresh = <bool>,
                // Refreshing the authentication session should be allowed.

                //ExpiresUtc = DateTimeOffset.UtcNow.AddMinutes(10),
                // The time at which the authentication ticket expires. A 
                // value set here overrides the ExpireTimeSpan option of 
                // CookieAuthenticationOptions set with AddCookie.

                //IsPersistent = true,
                // Whether the authentication session is persisted across 
                // multiple requests. When used with cookies, controls
                // whether the cookie's lifetime is absolute (matching the
                // lifetime of the authentication ticket) or session-based.

                //IssuedUtc = <DateTimeOffset>,
                // The time at which the authentication ticket was issued.

                //RedirectUri = <string>
                // The full path or absolute URI to be used as an http 
                // redirect response value.
            };

            await HttpContext.SignInAsync(
                CookieAuthenticationDefaults.AuthenticationScheme, 
                new ClaimsPrincipal(claimsIdentity), 
                authProperties);
            
            //return View();
            return RedirectToAction("Index", "Home");
        }
        [HttpGet]
        public IActionResult LogOut()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> LogOut(string UserName)
        {
            await HttpContext.SignOutAsync(
                CookieAuthenticationDefaults.AuthenticationScheme);
            //return View();
            return RedirectToAction("Index", "Home");
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }
        public IActionResult Journal()
        {
            return View();
        }
        public IActionResult Months()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
