using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using SinavOlusturma.Models.ORM.Context;
using SinavOlusturma.Models.ORM.Entities;
using SinavOlusturma.Models.VM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace SinavOlusturma.Controllers
{
    public class LoginController : Controller
    {
        private readonly ExamContext _examContext;

        public LoginController(ExamContext examContext)
        {
            _examContext = examContext;
        }

        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public async Task<ActionResult> Login(LoginVM model)
        {
            if (ModelState.IsValid)
            {
                User user = _examContext.Users.FirstOrDefault(q => q.Username == model.Username && q.Password == model.Password && q.IsDeleted == false);

                if(user != null)
                {
                    var claims = new List<Claim>
                    {
                        new Claim(ClaimTypes.Name, model.Username),
                    };

                    var userIdentity = new ClaimsIdentity(claims, "login");

                    ClaimsPrincipal principal = new ClaimsPrincipal(userIdentity);

                    await HttpContext.SignInAsync(principal);

                    return RedirectToAction("Generator", "ExamGenerator");
                }
                else
                {
                    ViewBag.error = "Kullanıcı Adı veya Şifre hatalı!!!";
                    return View();
                }
            }
            else
            {
                return View();
            }
        }

        public async Task<IActionResult> LogOut()
        {
            await HttpContext.SignOutAsync();
            return Redirect("/");
        }
    }
}
